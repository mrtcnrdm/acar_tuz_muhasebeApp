using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class borclarimlistele : Form
    {
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds;
        static int kimlik;
        static double borcguncelle, odememiktari = 0, guncelle, eklememiktari = 0;       
        static string info = "", secim = "";
        
        void KayitSorgu(string deger)
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
                        // tablo yoksa olusturdum
                        // ilk verileri olusturdum
                        // borc tablosundaki veriyi de güncelledim
                        // en son datagrid güncelemesi yaptım
                        
                        Tabloolustur();
                        IlkVerileriOlustur();
                        BorcTabloGuncelle();
                        listele();
                        Temizle();
                        break;
                    }
                    catch (OleDbException)
                    {
                        MessageBox.Show("hata");
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
            label_firmaadi.Text = "";
            label_borcmiktari.Text = "";
            textbox_odememiktari.Text = "";
            textbox_aciklama.Text = "";
            textbox_eklenecekborc.Text = "";
            groupBox1.Text = "";
            eklememiktari = 0;
            odememiktari = 0;
            listele();            
        }      
        private void GuncellemeKodlari()
        {
            //burada borclunun verileri güncellenecek          
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }

            if (rb_nakit.Checked == true)
            {
                secim = "Nakit";
            }
            else if (rb_havaleeft.Checked == true)
            {
                secim = "Havale";
            }
            else
            {
                secim = "";
            }
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO " + label_firmaadi.Text + "(BORCLUOLDUGUMFIRMA, BORCUM, BORCODEMETURU, ODEMEMIKTARI, YENIEKLENECEKBORC, KALANBORCUM, BORCODEMETARIHI, ACIKLAMA) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
            cmd.Parameters.AddWithValue("@p1", label_firmaadi.Text);
            cmd.Parameters.AddWithValue("@p2", info);
            if (rb_havaleeft.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p3", "Havale");
            }
            else if (rb_nakit.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p3", "Nakit");
            }
            else
            {
                cmd.Parameters.AddWithValue("p3", "");
            }
            if (textbox_odememiktari.Text != "" && textbox_eklenecekborc.Text == "")
            {
                odememiktari = double.Parse(textbox_odememiktari.Text);
                guncelle = double.Parse(label_firmaadi.Text) - odememiktari;
            }
            else if (textbox_eklenecekborc.Text != "" && textbox_odememiktari.Text == "")
            {
                eklememiktari = double.Parse(textbox_eklenecekborc.Text);
                guncelle = double.Parse(label_firmaadi.Text) + eklememiktari;
            }
            cmd.Parameters.AddWithValue("@p4", odememiktari);
            cmd.Parameters.AddWithValue("@p5", eklememiktari);
            cmd.Parameters.AddWithValue("@p6", guncelle);
            cmd.Parameters.AddWithValue("@p7", DateTime.Now);
            cmd.Parameters.AddWithValue("@p8", textbox_aciklama.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("güncelleme bloguna girdim");
            listele();
        }
        private void BorcTabloGuncelle2()
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "UPDATE Borc set BORCMIKTARI = '" + guncelle + "' where kimlik= " + kimlik;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
            baglanti.Close();
        }
        private void BorcTabloGuncelle()
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "UPDATE Borc set BORCMIKTARI = '" + borcguncelle + "' where kimlik= " + kimlik;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
            baglanti.Close();
        }
        void Tabloolustur()
        {
            baglanti.Open();
            cmd = new OleDbCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = ("CREATE TABLE " + label_firmaadi.Text +
                      "(Kimlik INTEGER IDENTITY(1) PRIMARY KEY NOT NULL,BORCLUOLDUGUMFIRMA varchar(255), BORCUM varchar(255), BORCODEMETURU varchar(255), ODEMEMIKTARI varchar(255), YENIEKLENECEKBORC varchar(255), KALANBORCUM varchar(255),BORCODEMETARIHI varchar(255), ACIKLAMA varchar(255))");
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            baglanti.Close();
        }
        void IlkVerileriOlustur()
        {
            baglanti.Open();
            cmd = new OleDbCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO " + label_firmaadi.Text + "(BORCLUOLDUGUMFIRMA, BORCUM, BORCODEMETURU, ODEMEMIKTARI, YENIEKLENECEKBORC, KALANBORCUM, BORCODEMETARIHI, ACIKLAMA) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
            cmd.Parameters.AddWithValue("@p1", label_firmaadi.Text);//firma adını yazdık
            cmd.Parameters.AddWithValue("@p2", label_borcmiktari.Text);//firmaya borcumuzu yazdık
            //havale-nakit bilgisini cekiyor ona göre yazıyorum.
            if (rb_havaleeft.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p3", "Havale");
            }
            else if (rb_nakit.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p3", "Nakit");
            }
            else if (rb_havaleeft.Checked == false && rb_nakit.Checked == false)
            {
                cmd.Parameters.AddWithValue("@p3", "");
            }
            cmd.Parameters.AddWithValue("@p4", textbox_odememiktari.Text);//yapılan ödeme miktarını yazdık
            cmd.Parameters.AddWithValue("@p5", textbox_eklenecekborc.Text);//yapılan borc miktarını yazdık

            if (textbox_odememiktari.Text == "" && textbox_eklenecekborc.Text != "")
            {//yeni borc ekleyecegim
                borcguncelle = double.Parse(label_borcmiktari.Text) + double.Parse(textbox_eklenecekborc.Text);
            }
            else if (textbox_odememiktari.Text != "" && textbox_eklenecekborc.Text == "")
            {
                borcguncelle = double.Parse(label_borcmiktari.Text) - double.Parse(textbox_odememiktari.Text);
            }
            else { borcguncelle = 0; }


            cmd.Parameters.AddWithValue("@p6", borcguncelle);//kalan borc kısmına miktarımızı yazdık cünkü bu ilk veri olusturma ekranı
            cmd.Parameters.AddWithValue("@p7", DateTime.Now);//işlemin yapıldıgı tarihi yazdık
            cmd.Parameters.AddWithValue("@p8", textbox_aciklama.Text);//bununla ilgili acıklama olusturduk
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("tablo olusturdum, ilk verilerde hazır");
            //MessageBox.Show("Güncelleme Başarılı! \nAna ekrana dönebilirsiniz...", "Bilgi");
        }
        private void buton_odemeyapborcekle_Click(object sender, EventArgs e)
        {
            KayitSorgu(label_firmaadi.Text);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            label_firmaadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label_borcmiktari.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void borclarimlistele_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void textbox_eklenecekborc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textbox_odememiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
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
        public borclarimlistele()
        {
            InitializeComponent();
        }
        private void borclarim_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}