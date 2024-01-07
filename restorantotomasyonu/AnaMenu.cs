using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restorantotomasyonu
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masalar masa = new Masalar();
            this.Close();
            masa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rezervasyon rezer = new rezervasyon();
            this.Close();
            rezer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            this.Close();
            ps.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musteriler mus = new musteriler();
            this.Close();
            mus.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kasa ks = new kasa();
            this.Close();
            ks.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mutfak mf = new mutfak();
            this.Close();
            mf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            raporlar rp = new raporlar();
            this.Close();
            rp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ayarlar ay = new ayarlar();
            this.Close();
            ay.Show();
        }

        private void ccik_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bgeri_Click(object sender, EventArgs e)
        {


        }
    }
}
