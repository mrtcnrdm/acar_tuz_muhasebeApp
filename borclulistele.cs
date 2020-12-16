using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class borclulistele : Form
    {
        OleDbConnection baglanti;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds;
        static int kimlik;
        static double kalanborc;  
        private void KayitSorgu(string deger)
        {
            //kayıtları sorgula o isimde tablo varsa iç birimini güncelleyecegiz
            //degere = firma adı geliyor
            baglanti.Open();
            DataTable dt = baglanti.GetSchema("Tables");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //tablo var mı onun kontrolunu yapıyoruz
                if (dt.Rows[i]["TABLE_TYPE"].ToString() != deger)
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                    try
                    {
                        Tabloolustur();
                        IlkVerileriOlustur();
                        BorcTabloGuncelle();
                        listele();
                        Temizle();
                        break;
                    }
                    catch (OleDbException)
                    {
                        GuncellemeKodlari();
                        BorcTabloGuncelle2();
                        listele();
                        Temizle();
                        break;
                    }
                }
            }
            baglanti.Close();
        }
        private void Temizle()
        {
            textbox_borcluborceklememiktari.Text = "";
            textbox_borcluaciklama.Text = "";
            textbox_borcluborcodememiktari.Text = "";
            textbox_borcluborcyapilmaturu.Text = "";
            label_firmaadi.Text = "";
            label_borclufirmaborcmiktari.Text = "0";            
            kalanborc = 0;
            listele();
        }
        private void BorcTabloGuncelle2()
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "UPDATE borclular set BORCLUNUNBORCMIKTARI = '" + kalanborc + "' where kimlik= " + kimlik;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
            baglanti.Close();
        }
        private void GuncellemeKodlari()
        {
            //burada borclunun verileri güncellenecek          
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO " + label_firmaadi.Text + "(BORCLUFIRMAADI, BORCLUFIRMABORCMIKTARI, BORCLUFIRMAODEMESI, BORCLUFIRMAODEMETURU, BORCLUFIRMAYENIBORCLU, BORCLUFIRMAYENIBORCTURU, BORCLUFIRMAKALANBORCU, ACIKLAMA, TARIH) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
            cmd.Parameters.AddWithValue("@p1", label_firmaadi.Text);
            cmd.Parameters.AddWithValue("@p2", label_borclufirmaborcmiktari.Text);
            cmd.Parameters.AddWithValue("@p3", textbox_borcluborcodememiktari.Text);
            //havale-nakit bilgisini cekiyor ona göre yazıyorum.
            if (rb_havele_eft.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p4", "Havale-EFT");
            }
            else if (rb_nakit.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p4", "Nakit");
            }
            else if (rb_havele_eft.Checked == false && rb_nakit.Checked == false)
            {
                cmd.Parameters.AddWithValue("@p4", "");
            }

            cmd.Parameters.AddWithValue("@p5", textbox_borcluborceklememiktari.Text);
            cmd.Parameters.AddWithValue("@p6", textbox_borcluborcyapilmaturu.Text);

            //ödeme yapıldıgındaki işlem
            if (textbox_borcluborcodememiktari.Text != "" && textbox_borcluborceklememiktari.Text == "")
            {
                kalanborc = double.Parse(label_borclufirmaborcmiktari.Text) - double.Parse(textbox_borcluborcodememiktari.Text);
            }
            else if (textbox_borcluborcodememiktari.Text == "" && textbox_borcluborceklememiktari.Text != "")
            {
                kalanborc = double.Parse(label_borclufirmaborcmiktari.Text) + double.Parse(textbox_borcluborceklememiktari.Text);
            }

            cmd.Parameters.AddWithValue("@p7", kalanborc);
            cmd.Parameters.AddWithValue("@p8", textbox_borcluaciklama.Text);
            cmd.Parameters.AddWithValue("@p9", DateTime.Now);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("güncelleme bloguna girdim");
            listele();
        }
        private void BorcTabloGuncelle()
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "UPDATE borclular set BORCLUNUNBORCMIKTARI = '" + kalanborc + "' where kimlik= " + kimlik;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
            baglanti.Close();
        }        
        void IlkVerileriOlustur()
        {
            baglanti.Open();
            cmd = new OleDbCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO " + label_firmaadi.Text + "(BORCLUFIRMAADI, BORCLUFIRMABORCMIKTARI, BORCLUFIRMAODEMESI, BORCLUFIRMAODEMETURU, BORCLUFIRMAYENIBORCLU, BORCLUFIRMAYENIBORCTURU, BORCLUFIRMAKALANBORCU, ACIKLAMA, TARIH) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
            cmd.Parameters.AddWithValue("@p1", label_firmaadi.Text);
            cmd.Parameters.AddWithValue("@p2", label_borclufirmaborcmiktari.Text);
            cmd.Parameters.AddWithValue("@p3", textbox_borcluborcodememiktari.Text);
            //havale-nakit bilgisini cekiyor ona göre yazıyorum.
            if (rb_havele_eft.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p4", "Havale-EFT");
            }
            else if (rb_nakit.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p4", "Nakit");
            }
            else if (rb_havele_eft.Checked == false && rb_nakit.Checked == false)
            {
                cmd.Parameters.AddWithValue("@p4", "");
            }
            
            cmd.Parameters.AddWithValue("@p5", textbox_borcluborceklememiktari.Text);
            cmd.Parameters.AddWithValue("@p6", textbox_borcluborcyapilmaturu.Text);

            //ödeme yapıldıgındaki işlem
            if (textbox_borcluborcodememiktari.Text != "" && textbox_borcluborceklememiktari.Text == "")
            {
                kalanborc = double.Parse(label_borclufirmaborcmiktari.Text) - double.Parse(textbox_borcluborcodememiktari.Text);
            }
            else if (textbox_borcluborcodememiktari.Text == "" && textbox_borcluborceklememiktari.Text != "")
            {
                kalanborc = double.Parse(label_borclufirmaborcmiktari.Text) + double.Parse(textbox_borcluborceklememiktari.Text);
            }

            cmd.Parameters.AddWithValue("@p7", kalanborc);
            cmd.Parameters.AddWithValue("@p8", textbox_borcluaciklama.Text);
            cmd.Parameters.AddWithValue("@p9", DateTime.Now);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("tablo olusturdum, ilk verilerde hazır");
            //MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
        }
        void Tabloolustur()
        {
            baglanti.Open();
            cmd = new OleDbCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = ("CREATE TABLE " + label_firmaadi.Text +
                      "(Kimlik INTEGER IDENTITY(1) PRIMARY KEY NOT NULL,BORCLUFIRMAADI varchar(255), BORCLUFIRMABORCMIKTARI varchar(255), BORCLUFIRMAODEMESI varchar(255), BORCLUFIRMAODEMETURU varchar(255), BORCLUFIRMAYENIBORCLU varchar(255), BORCLUFIRMAYENIBORCTURU varchar(255), BORCLUFIRMAKALANBORCU varchar(255), ACIKLAMA varchar(255), TARIH varchar(255))");
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            baglanti.Close();
        }
        private void buton_islemigerceklestir_Click(object sender, EventArgs e)
        {
            KayitSorgu(label_firmaadi.Text);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            label_firmaadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label_borclufirmaborcmiktari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();           
        }
        void listele()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            da = new OleDbDataAdapter("select * from borclular", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "borclular");
            dataGridView1.DataSource = ds.Tables["borclular"];
            baglanti.Close();
        }
        public borclulistele()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void borclulistele_Load(object sender, EventArgs e)
        {
            label_firmaadi.ForeColor = Color.White;
            this.Visible = true;
            menu menu = new menu();
            menu.Close();
            this.Visible = true;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
            listele();
        }          
        private void borclulistele_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_borcluborcodememiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textbox_borcluborceklememiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}