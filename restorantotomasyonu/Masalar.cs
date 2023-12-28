using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restorantotomasyonu
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button1.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button1.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button1.Text;
            }

            cGenel._buttonName = button1.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaMenu ana = new AnaMenu();
            this.Close();
            ana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button2.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button2.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button2.Text;
            }

            cGenel._buttonName = button2.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button3.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button3.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button3.Text;
            }

            cGenel._buttonName = button3.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button4.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button4.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button4.Text;
            }

            cGenel._buttonName = button4.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button5.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button5.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button5.Text;
            }

            cGenel._buttonName = button5.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button7.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button1.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button1.Text;
            }

            cGenel._buttonName = button1.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button8.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button8.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button8.Text;
            }

            cGenel._buttonName = button8.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button9.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button9.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button9.Text;
            }

            cGenel._buttonName = button9.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button10.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button10.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button10.Text;
            }

            cGenel._buttonName = button10.Name;
            this.Close();
            ps.ShowDialog();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            paketservis ps = new paketservis();
            int uzunluk = button16.Text.Length;

            if (uzunluk >= 6)
            {
                cGenel._buttonValue = button16.Text.Substring(uzunluk - 6, 6);
            }
            else
            {
                // Eğer düğme metni 6 karakterden kısa ise, tüm metni kullanabilirsiniz veya başka bir işlem yapabilirsiniz.
                cGenel._buttonValue = button16.Text;
            }

            cGenel._buttonName = button16.Name;
            this.Close();
            ps.ShowDialog();

        }
        cGenel gnl = new cGenel();
        private void Masalar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM,ID from Masalar", con);
            SqlDataReader dr = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (true)
                {

                }
            }
        }
    }
}
