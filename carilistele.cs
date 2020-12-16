using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class carilistele : Form
    {
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public carilistele()
        {
            InitializeComponent();
        }
        private void carilistele_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            menu menu = new menu();
            menu.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void carilistele_Load(object sender, EventArgs e)
        {
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
        private void carilistele_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
