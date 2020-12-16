using System;
using System.Windows.Forms;

namespace acartuz
{
    public partial class Form1 : Form
    {
        static string kadi = "acartuz";
        static string ksifre = "admin";

        public Form1()
        {
            InitializeComponent();
        }
        private void buton_girisyap_Click(object sender, EventArgs e)
        {
            if (textbox_kullaniciAdi.Text == kadi && textbox_kullaniciSifre.Text == ksifre)
            {
                menu mn = new menu();
                this.Hide();
                mn.Show();                            
            }
            else if (textbox_kullaniciAdi.Text != kadi || textbox_kullaniciSifre.Text != ksifre)
            {
                label_zorunluKullaniciAdi.Visible = true;
            }            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }
    }
}
