using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class cariolustur : Form
    {        
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();  
        static bool durum;    

        public cariolustur()
        {
            InitializeComponent();
        }
        void temizle()
        {
            textbox_cariadresi.Text = "";
            textbox_carihesapadi.Text = "";
            textbox_carihesapno.Text = "";
            textbox_caritelefon1.Text = "";
            textbox_caritelefon2.Text = "";
            textbox_cariyetkiliadi.Text = "";
        }
        private void cariolustur_Load(object sender, System.EventArgs e)
        {
            menu menu = new menu();
            menu.Close();
            this.Visible = true;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
        }        
        void Mukerrer()
        {
            baglanti.Open();
            cmd = new OleDbCommand($"select * from carikayit where CARI_HESAP_ADI=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textbox_carihesapadi.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }
        private void buton_kaydet_Click(object sender, System.EventArgs e)
        {
            if (textbox_carihesapadi.Text == "")
            {
                label_hata.Visible = true;
                label_hata2.Visible = false;
                label_hata3.Visible = false;
            }
            else if (textbox_cariadresi.Text == "")
            {
                label_hata.Visible = false;
                label_hata2.Visible = true;
                label_hata3.Visible = false;
            }
            else if (textbox_caritelefon1.Text == "")
            {
                label_hata.Visible = false;
                label_hata2.Visible = false;
                label_hata3.Visible = true;
            }
            else if (textbox_carihesapadi.Text != "" || textbox_cariadresi.Text != "" || textbox_caritelefon1.Text != "")
            {
                label_hata.Visible = false;
                label_hata2.Visible = false;
                label_hata3.Visible = false;
                Mukerrer();
                if (durum == true)
                {
                    foreach (object item in checkboxlist_saticimusteri.CheckedItems)
                    {
                        string checkedItem = item.ToString();
                        label8.Text = label8.Text + checkedItem + ",";
                    }
                    cmd = new OleDbCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO carikayit(CARI_HESAP_ADI, CARI_YETKILI_ADI, CARI_ADRESI, CARI_TELEFON_1, CARI_TELEFON_2, CARI_HESAP_NO, CARI_GRUBU) " +
                        "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                    cmd.Parameters.AddWithValue("@p1", textbox_carihesapadi.Text);
                    cmd.Parameters.AddWithValue("@p2", textbox_cariyetkiliadi.Text);
                    cmd.Parameters.AddWithValue("@p3", textbox_cariadresi.Text);
                    cmd.Parameters.AddWithValue("@p4", textbox_caritelefon1.Text);
                    cmd.Parameters.AddWithValue("@p5", textbox_caritelefon2.Text);
                    cmd.Parameters.AddWithValue("@p6", textbox_carihesapno.Text);
                    cmd.Parameters.AddWithValue("@p7", label8.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    label8.Text = "";
                    MessageBox.Show("Kayıt başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                    temizle();
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten var!", "Bilgi");
                    temizle();
                }
            }
        }
        private void buton_geridon_MouseHover(object sender, System.EventArgs e)
        {
            buton_geridon.BackColor = System.Drawing.Color.Yellow;
        }
        private void buton_geridon_MouseLeave(object sender, System.EventArgs e)
        {
            buton_geridon.BackColor = System.Drawing.Color.Transparent;
        }
        private void buton_geridon_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
        private void cariolustur_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_caritelefon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_caritelefon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
