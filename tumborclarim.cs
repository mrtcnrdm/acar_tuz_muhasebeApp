using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace acartuz
{
    public partial class tumborclarim : Form
    {
        OleDbConnection baglanti;
        OleDbDataReader dr;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds;

        public tumborclarim()
        {
            InitializeComponent();
        }
        private void buton_geridon_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private void tumborclarim_Load(object sender, EventArgs e)
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
        private void tumborclarim_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
