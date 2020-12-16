using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class stokguncellesil : Form
    {
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        static int kimlik;

        public stokguncellesil()
        {
            InitializeComponent();
        }     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void stokguncelle_Load(object sender, EventArgs e)
        {
            label_zorunlu1.Visible = false;
            label_zorunlu2.Visible = false;
            label_zorunlu3.Visible = false;
            label_zorunlu4.Visible = false;
            this.Visible = true;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
            listele();
        }
        void listele()
        {
            da = new OleDbDataAdapter("select * from urunler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            baglanti.Close();
        }        
        void Temizle()
        {
            textbox_urunkalitesi.Text = "";
            textbox_urunadi.Text = "";
            textbox_urunadet.Text = "";
            textbox_urununfiyati.Text = "";
            textbox_urununkdvsi.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textbox_urunadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textbox_urunkalitesi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textbox_urunadet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();           
            textbox_urununfiyati.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textbox_urununkdvsi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }     
        private void buton_guncelle_Click(object sender, EventArgs e)
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

                double islem = double.Parse(textbox_urununfiyati.Text) * double.Parse(textbox_urununkdvsi.Text);
                double islem2 = islem / 100;
                double islem3 = islem2 + double.Parse(textbox_urununfiyati.Text);

                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE urunler set URUNADI = '" + textbox_urunadi.Text + "', URUNKALITESI= '" + textbox_urunkalitesi.Text + "'," +
                    " URUNADET= '" + textbox_urunadet.Text + "', URUNFIYAT= '" + textbox_urununfiyati.Text + "', URUNKDV= '" + textbox_urununkdvsi.Text + "', URUNFIYATKDV= '" + islem3 + "' where kimlik= " + kimlik;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
                baglanti.Close();
                Temizle();
                listele();
            }
        }
        private void buton_temizle_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ürünü silmek istediginizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "Delete from urunler where Kimlik = " + kimlik;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla silindi!");
                baglanti.Close();
                Temizle();
                listele();
            }
        }
        private void stokguncellesil_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_urununfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
        
        private void textbox_urununkdvsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_urunadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
