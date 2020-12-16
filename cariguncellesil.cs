using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class cariguncellesil : Form
    {
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        static int kimlik;

        public cariguncellesil()
        {
            InitializeComponent();
        }
        private void carisil_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            menu menu = new menu();
            menu.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void carisil_Load(object sender, EventArgs e)
        {
            label_zorunlu1.Visible = false;
            label_zorunlu2.Visible = false;
            label_zorunlu3.Visible = false;
            this.Visible = true;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
            listele();
        }
        void listele()
        {
            da = new OleDbDataAdapter("select * from carikayit", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "cari");
            dataGridView1.DataSource = ds.Tables["cari"];
            baglanti.Close();
        }               
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textbox_carihesapadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textbox_cariyetkiliadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textbox_cariadresi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textbox_caritelefon1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textbox_caritelefon2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textbox_carihesapno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textbox_carigrubu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void buton_guncelle_Click(object sender, EventArgs e)
        {
            if (textbox_carihesapadi.Text == "")
            {
                label_zorunlu1.Visible = true;
                label_zorunlu2.Visible = false;
                label_zorunlu3.Visible = false;
            }
            else if (textbox_cariadresi.Text == "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = true;
                label_zorunlu3.Visible = false;
            }
            else if (textbox_caritelefon1.Text == "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = false;
                label_zorunlu3.Visible = true;
            }
            else if (textbox_carihesapadi.Text != "" || textbox_cariadresi.Text != "" || textbox_caritelefon1.Text != "")
            {
                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE carikayit set CARI_HESAP_ADI = '" + textbox_carihesapadi.Text + "', CARI_YETKILI_ADI= '" + textbox_cariyetkiliadi.Text + "', CARI_ADRESI= '" + textbox_cariadresi.Text + "', CARI_TELEFON_1= '" + textbox_caritelefon1.Text + "'," +
                    " CARI_TELEFON_2= '" + textbox_caritelefon2.Text + "', CARI_HESAP_NO= '" + textbox_carihesapno.Text + "', CARI_GRUBU= '" + textbox_carigrubu.Text + "' where kimlik= " + kimlik;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                baglanti.Close();
                Temizle();
                listele();
            }
        }
        private void buton_sil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("kişiyi silmek istediginizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "Delete from carikayit where Kimlik = " + kimlik;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kişi başarıyla silindi!");
                baglanti.Close();
                Temizle();
                listele();
            }
        }
        void Temizle()
        {
            textbox_carihesapadi.Text = "";
            textbox_carihesapno.Text = "";
            textbox_carigrubu.Text = "";
            textbox_cariadresi.Text = "";
            textbox_caritelefon1.Text = "";
            textbox_caritelefon2.Text = "";
            textbox_cariyetkiliadi.Text = "";
        }
        private void cariguncellesil_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_caritelefon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_caritelefon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
