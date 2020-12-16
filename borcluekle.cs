using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class borcluekle : Form
    {
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds;
        static int kimlik;
        static bool durum;

        private void buton_kaydet_Click(object sender, EventArgs e)
        {
            if (textbox_kaydetborclufirma.Text != "" && textbox_kaydetborclutelefon1.Text != ""
                && textbox_kaydetborcluadresi.Text != "" && textbox_kaydetborcmiktari.Text != "")
            {
                Mukerrer();
                if (durum == true)
                {
                    cmd = new OleDbCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO borclular(BORCLUFIRMA, BORCLUFIRMANINYETKILISI, BORCLUNUNADI, BORCLUNUNBORCMIKTARI, BORCLUADRES, BORCLUTELEFON1, BORCLUTELEFON2, BORCLANMATARIHI) " +
                        "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
                    cmd.Parameters.AddWithValue("@p1", textbox_kaydetborclufirma.Text);
                    cmd.Parameters.AddWithValue("@p2", textbox_kaydetborclufirmayetkiliadi.Text);
                    cmd.Parameters.AddWithValue("@p3", textbox_kaydetborcluadi.Text);
                    cmd.Parameters.AddWithValue("@p4", textbox_kaydetborcmiktari.Text);
                    cmd.Parameters.AddWithValue("@p5", textbox_kaydetborcluadresi.Text);
                    cmd.Parameters.AddWithValue("@p6", textbox_kaydetborclutelefon1.Text);
                    cmd.Parameters.AddWithValue("@p7", textbox_kaydetborclutelefon2.Text);
                    cmd.Parameters.AddWithValue("@p8", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                    listele();
                    VeriTemizle();
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten var!", "Bilgi");
                    listele();
                    VeriTemizle();
                }
            }
            else if (textbox_kaydetborclufirma.Text == "" || textbox_kaydetborclutelefon1.Text == ""
               || textbox_kaydetborcluadresi.Text == "" || textbox_kaydetborcmiktari.Text == "")
            {
                MessageBox.Show("Zorunlu Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public borcluekle()
        {
            InitializeComponent();
        }
        private void borcluekle_Load(object sender, EventArgs e)
        {
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
            listele();
        }
        void listele()
        {
            da = new OleDbDataAdapter("select * from borclular", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "borclular");
            dataGridView1.DataSource = ds.Tables["borclular"];
            baglanti.Close();
        }
        void Mukerrer()
        {
            baglanti.Open();
            cmd = new OleDbCommand($"select * from borclular where BORCLUFIRMA=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textbox_kaydetborclufirmayetkiliadi.Text);
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
        private void borcluekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            menu menu = new menu();
            menu.Show();
        }
        private void textbox_kaydetborclumiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void buton_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void buton_veritemizle_Click(object sender, EventArgs e)
        {
            VeriTemizle();
        }
        void VeriTemizle()
        {
            //kaydetme kısmını temizledim
            textbox_kaydetborcluadi.Text = "";
            textbox_kaydetborcluadresi.Text = "";
            textbox_kaydetborclufirma.Text = "";
            textbox_kaydetborclufirmayetkiliadi.Text = "";
            textbox_kaydetborclutelefon1.Text = "";
            textbox_kaydetborclutelefon2.Text = "";
            textbox_kaydetborcmiktari.Text = "";

            //guncelle kısmını temizledim
            textbox_guncelleborcluadi.Text = "";
            textbox_guncelleborcluadresi.Text = "";
            textbox_guncelleborclufirma.Text = "";
            textbox_guncelleborclufirmayetkilisi.Text = "";
            textbox_guncelleborclumiktari.Text = "";
            textbox_guncelletelefon1.Text = "";
            textbox_guncelletelefon2.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textbox_guncelleborclufirma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textbox_guncelleborclufirmayetkilisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textbox_guncelleborcluadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textbox_guncelleborclumiktari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textbox_guncelleborcluadresi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textbox_guncelletelefon1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textbox_guncelletelefon2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void buton_guncelle_Click(object sender, EventArgs e)
        {
            if (textbox_guncelleborclufirma.Text != "" && textbox_guncelleborclumiktari.Text != ""
                && textbox_guncelleborcluadresi.Text != "" && textbox_guncelletelefon1.Text != "")
            {
                DialogResult dr = MessageBox.Show("kişiyi güncellemek istediginizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cmd = new OleDbCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "UPDATE borclular set BORCLUFIRMA = '" + textbox_guncelleborclufirma.Text + "', BORCLUFIRMANINYETKILISI= '" + textbox_guncelleborclufirmayetkilisi.Text + "', BORCLUNUNADI= '" + textbox_guncelleborcluadi.Text + "'" +
                        ", BORCLUNUNBORCMIKTARI= '" + textbox_guncelleborclumiktari.Text + "', BORCLUADRES= '" + textbox_guncelleborcluadresi.Text + "', BORCLUTELEFON1= '" + textbox_guncelletelefon1.Text + "'" +
                        ", BORCLUTELEFON2= '" + textbox_guncelletelefon2.Text + "' where kimlik= " + kimlik;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                    baglanti.Close();
                    VeriTemizle();
                    listele();
                }
                else if (dr == DialogResult.No)
                {
                    VeriTemizle();
                    listele();
                }
            }
            else if (textbox_guncelleborclufirma.Text == "" || textbox_guncelleborclumiktari.Text == ""
               || textbox_guncelleborcluadresi.Text == "" || textbox_guncelletelefon1.Text == "")
            {
                MessageBox.Show("Zorunlu Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buton_sil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Borçluyu silmek istediginizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "Delete from borclular where Kimlik = " + kimlik;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Borçlu başarıyla silindi!");
                baglanti.Close();
                VeriTemizle();
                listele();
            }
            else if (dr == DialogResult.No)
            {
                VeriTemizle();
            }
        }
        private void textbox_kaydetborclutelefon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textbox_kaydetborclutelefon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textbox_guncelletelefon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textbox_guncelletelefon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }   
        private void borcluekle_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_kaydetborcmiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textbox_guncelleborclumiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
