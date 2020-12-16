using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class tumborclular : Form
    {
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds;
        public tumborclular()
        {
            InitializeComponent();
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
        private void tumborclular_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            menu menu = new menu();
            menu.Close();
            this.Visible = true;
            DirectoryInfo dbpath = new DirectoryInfo(Directory.GetCurrentDirectory());
            string dbpath2 = dbpath.Parent.Parent.FullName + "\\database\\cariler.accdb";
            baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbpath2}");
            listele();
        }
        private void buton_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tumborclular_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
