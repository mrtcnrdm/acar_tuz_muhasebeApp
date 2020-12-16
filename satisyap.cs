using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class satisyap : Form
    {
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        static int kimlik, islem, stok;
        static double tutar, kdvli;
        private void buton_satisyap_Click(object sender, EventArgs e)
        {
            label_zorunlu1.Visible = false;
            label_zorunlu2.Visible = false;
            int kontrol = int.Parse(textbox_urunadet.Text);
            if (kontrol > stok)
            {
                MessageBox.Show("Stok Yetersiz!");
            }else if(kontrol <= stok)
            {
                if (textbox_satinalanfirmaadi.Text != "" && textbox_urunadet.Text != "")
                {
                    DialogResult result = new DialogResult();
                    tutar = double.Parse(textbox_urunadet.Text) * kdvli;
                    result = MessageBox.Show($"Ürün Tutarı: {tutar} \nSatış işlemini onaylıyor musunuz?", "Satış İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        islem = stok - int.Parse(textbox_urunadet.Text);
                        VeriyiEkle();
                        StokGuncelle();
                        listele();
                        Temizle();
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("İşlem İptal Edildi!", "İşlem İptal");
                        Temizle();
                    }
                }
                else if (textbox_urunadet.Text == "")
                {
                    label_zorunlu2.Visible = true;
                }
                else if (textbox_satinalanfirmaadi.Text == "")
                {
                    label_zorunlu1.Visible = true;
                }
            }            
        }
        private void StokGuncelle()
        {
            //stok listesini güncelleyecek
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "UPDATE urunler set URUNADET= '" + islem + "' where kimlik= " + kimlik;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı!", "Bilgi");
            baglanti.Close();
            listele();
            Temizle();
        }
        private void VeriyiEkle()
        {
            //veri tabanına satıs işlemini gerçekleştirecek
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO satisyap(SATILANURUNADI, SATILANURUNADET, SATILANURUNFIYAT, SATILANURUNKDV, SATILANFIRMAADI, TARIH) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6)";
            cmd.Parameters.AddWithValue("@p1", label_urunadi.Text);
            
            
            if (textbox_urunadet.Text != "")
            {
                cmd.Parameters.AddWithValue("@p2", textbox_urunadet.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", 0);
            }
            cmd.Parameters.AddWithValue("@p3", label_urunfiyati.Text);
            cmd.Parameters.AddWithValue("@p4", label_urunkdv.Text);
            cmd.Parameters.AddWithValue("@p5", textbox_satinalanfirmaadi.Text);
            cmd.Parameters.AddWithValue("@p6", DateTime.Now);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listele();
            Temizle();
        }
        public satisyap()
        {
            InitializeComponent();            
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void satisyap_Load(object sender, EventArgs e)
        {
            label_zorunlu2.Visible = false;
            label_zorunlu1.Visible = false;
            label_urunadi.ForeColor = Color.White;
            label_urunfiyati.ForeColor = Color.White;
            label_urunkdv.ForeColor = Color.White;
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
            da.Fill(ds, "urunler");
            dataGridView1.DataSource = ds.Tables["urunler"];
            baglanti.Close();
        }     
        private void satisyap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        private void textbox_urunadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            label_urunadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            stok = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            label_urunfiyati.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label_urunkdv.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kdvli = double.Parse((string)dataGridView1.CurrentRow.Cells[6].Value);
            
        }
        private void buton_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            label_zorunlu1.Visible = false;
            label_urunadi.Text = "";
            label_urunfiyati.Text = "";
            label_urunkdv.Text = "";
            textbox_satinalanfirmaadi.Text = "";
            textbox_urunadet.Text = "";
        }
    }
}
