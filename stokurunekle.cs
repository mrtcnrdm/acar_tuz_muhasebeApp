using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class stokurunekle : Form
    {
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand(); 
        static bool durum;

        public stokurunekle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void stokurunekle_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            label_zorunlu1.Visible = false;
            label_zorunlu2.Visible = false;
            label_zorunlu3.Visible = false;
            label_zorunlu4.Visible = false;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
        }       
        void Mukerrer()
        {
            baglanti.Open();
            cmd = new OleDbCommand($"select * from urunler where URUNADI=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textbox_urunadi.Text);
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
        void Temizle()
        {
            textbox_urunadet.Text = "";
            textbox_urunadi.Text = "";
            textbox_urunkalite.Text = "";
            textbox_urununfiyati.Text = "";
            textbox_urununkdvsi.Text = "";
        }
        private void buton_kaydet_Click_1(object sender, EventArgs e)
        {
            if (textbox_urunadi.Text == "")
            {
                label_zorunlu1.Visible = true;
                label_zorunlu2.Visible = false;
                label_zorunlu3.Visible = false;
                label_zorunlu4.Visible = false;
            }
            else if (textbox_urunadet.Text == "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = true;
                label_zorunlu3.Visible = false;
                label_zorunlu4.Visible = false;
            }
            else if (textbox_urununfiyati.Text == "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = false;
                label_zorunlu3.Visible = true;
                label_zorunlu4.Visible = false;
            }
            else if (textbox_urununkdvsi.Text == "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = false;
                label_zorunlu3.Visible = false;
                label_zorunlu4.Visible = true;
            }
            else if (textbox_urunadi.Text != "" && textbox_urunadet.Text != ""
                && textbox_urununfiyati.Text != "" && textbox_urununkdvsi.Text != "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = false;
                label_zorunlu3.Visible = false;
                label_zorunlu4.Visible = false;
                Mukerrer();
                if (durum == true)
                {
                    cmd = new OleDbCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO urunler(URUNADI, URUNKALITESI, URUNADET, URUNFIYAT, URUNKDV, URUNFIYATKDV) " +
                        "values (@p1, @p2, @p3, @p4, @p5, @p6)";
                    cmd.Parameters.AddWithValue("@p1", textbox_urunadi.Text);
                    cmd.Parameters.AddWithValue("@p2", textbox_urunkalite.Text);
                    cmd.Parameters.AddWithValue("@p3", textbox_urunadet.Text);
                    cmd.Parameters.AddWithValue("@p4", textbox_urununfiyati.Text);
                    cmd.Parameters.AddWithValue("@p5", textbox_urununkdvsi.Text);
                    float islem = float.Parse(textbox_urununfiyati.Text) * float.Parse(textbox_urununkdvsi.Text);
                    float islem2 = islem / 100;
                    float islem3 = islem2 + float.Parse(textbox_urununfiyati.Text);
                    cmd.Parameters.AddWithValue("@p7", islem3);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!\nBu kayıt zaten var!", "Bilgi");
                    Temizle();
                }
            }
        }
        private void buton_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void stokurunekle_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_urunadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_urununfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textbox_urununkdvsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
