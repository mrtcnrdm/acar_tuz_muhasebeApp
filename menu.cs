using System;
using System.Drawing;
using System.Windows.Forms;
using custombutton;

namespace acartuz
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        borcluekle borcluekle = new borcluekle();
        cariolustur cariolustur = new cariolustur();
        carilistele carilistele = new carilistele();
        cariguncellesil carisil = new cariguncellesil();
        stokguncellesil stokguncelle = new stokguncellesil();
        stoklistele stoklistele = new stoklistele();
        stokurunekle stokurunekle = new stokurunekle();
        borclarimlistele borclarim = new borclarimlistele();
        satisyap satisyap = new satisyap();
        borclulistele borclulistele = new borclulistele();
        tumborclular tb = new tumborclular();
        tumborclarim tbm = new tumborclarim();
        cariolustur cro = new cariolustur();
        borcekle borcekle = new borcekle();

        private void buton_cariolustur_Click(object sender, EventArgs e)
        {
            cariolustur.ShowDialog();
        }
        private void buton_carilistele_Click(object sender, EventArgs e)
        {
            carilistele.ShowDialog();
        }
        private void buton_carisil_Click(object sender, EventArgs e)
        {
            carisil.ShowDialog();
        }
        private void buton_stokguncelle_Click(object sender, EventArgs e)
        {
            stokguncelle.ShowDialog();
        }
        private void buton_stoklistele_Click(object sender, EventArgs e)
        {
            stoklistele.ShowDialog();
        }
        private void buton_stokurunekle_Click(object sender, EventArgs e)
        {
            stokurunekle.ShowDialog();
        }
        private void buton_borclarim_Click(object sender, EventArgs e)
        {
            borclarim.ShowDialog();
        }
        private void buton_satisyap_Click(object sender, EventArgs e)
        {
            satisyap.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now + "";
        }
        private void buton_borcekle_Click(object sender, EventArgs e)
        {            
            borcekle.ShowDialog();
        }
        private void buton_borcluekle_Click(object sender, EventArgs e)
        {
            borcluekle.ShowDialog();
        }
        private void buton_borclulistele_Click(object sender, EventArgs e)
        {
            borclulistele.ShowDialog();
        }
        private void buton_borclularilistele_Click(object sender, EventArgs e)
        {
            tb.ShowDialog();
        }
        private void buton_tumborclarim_Click(object sender, EventArgs e)
        {
            tbm.ShowDialog();
        }
        private void buton_cariolustur_Click_1(object sender, EventArgs e)
        {
            cro.ShowDialog();
        }
        private void menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
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
