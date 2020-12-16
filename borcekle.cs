using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class borcekle : Form
    {
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds;
        static int kimlik;
        static bool durum;        
        public borcekle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();                  
        }
        private void borcekle_Load(object sender, EventArgs e)
        {
            label_zorunlu1.Visible = false;
            label_zorunlu2.Visible = false;
            label_zorunlu3.Visible = false;
            label_zorunlu4.Visible = false;

            menu menu = new menu();
            menu.Close();
            this.Visible = true;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
            listele();
        }
        void listele()
        {
            da = new OleDbDataAdapter("select * from borc", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "borc");
            dataGridView1.DataSource = ds.Tables["borc"];
            baglanti.Close();
        }                
        void Mukerrer()
        {
            baglanti.Open();
            cmd = new OleDbCommand($"select * from borc where BORCLUOLDUGUMFIRMA=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", textbox_kaydetfirmaadi.Text);
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
        private void buton_kaydet_Click(object sender, EventArgs e)
        {
            if (textbox_kaydetfirmaadi.Text == "")
            {
                label_zorunlu1.Visible = true;
                label_zorunlu2.Visible = false;
            }
            else if (textbox_kaydetborcmiktari.Text == "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = true;
            }
            else if (textbox_kaydetfirmaadi.Text != "" || textbox_kaydetborcmiktari.Text != "")
            {
                label_zorunlu1.Visible = false;
                label_zorunlu2.Visible = false;
                Mukerrer();
                if (durum == true)
                {
                    cmd = new OleDbCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO borc(BORCLUOLDUGUMFIRMA, BORCMIKTARI) " +
                        "values (@p1, @p2)";
                    cmd.Parameters.AddWithValue("@p1", textbox_kaydetfirmaadi.Text);
                    cmd.Parameters.AddWithValue("@p2", textbox_kaydetborcmiktari.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                    listele();
                    Temizle2();
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten var!", "Bilgi");
                    listele();
                    Temizle2();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textbox_guncellefirmaadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textbox_guncelleborcmiktari.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void buton_guncelle_Click(object sender, EventArgs e)
        {

            if (textbox_guncellefirmaadi.Text == "")
            {
                label_zorunlu3.Visible = true;
                label_zorunlu4.Visible = false;
            }
            else if (textbox_guncelleborcmiktari.Text == "")
            {
                label_zorunlu3.Visible = false;
                label_zorunlu4.Visible = true;
            }
            else if (textbox_guncellefirmaadi.Text != "" || textbox_guncelleborcmiktari.Text != "")
            {
                DialogResult dr = MessageBox.Show("kişiyi güncellemek istediginizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    label_zorunlu3.Visible = false;
                    label_zorunlu4.Visible = false;
                    cmd = new OleDbCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "UPDATE borc set BORCLUOLDUGUMFIRMA = '" + textbox_guncellefirmaadi.Text + "', BORCMIKTARI= '" + textbox_guncelleborcmiktari.Text + "' where kimlik= " + kimlik;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                    baglanti.Close();
                    Temizle();
                    listele();
                }
                else if (dr == DialogResult.No)
                {
                    Temizle();
                    listele();
                }
            }
        }
        void Temizle2()
        {
            textbox_kaydetborcmiktari.Text = "";
            textbox_kaydetfirmaadi.Text = "";
        }
        void Temizle()
        {
            textbox_guncellefirmaadi.Text = "";
            textbox_guncelleborcmiktari.Text = "";
        }
        private void buton_sil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Borcu silmek istediginizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "Delete from borc where Kimlik = " + kimlik;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Borç başarıyla silindi!");
                baglanti.Close();
                Temizle();
                listele();
            }
            else if (dr == DialogResult.No)
            {
                Temizle();
            }
        }
        private void borcekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_kaydetborcmiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textbox_guncelleborcmiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
