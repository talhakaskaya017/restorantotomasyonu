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
               foreach(Control item in this.Controls)
                {
                    if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString()=="1")
                    {
                        item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.green_500x500_500x500);
                    }
                    else if(item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() =="2") 
                    {
                        cMasalar ms = new cMasalar();
                        DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2));
                        DateTime dt2 = DateTime.Now;

                        string st1 = Convert.ToDateTime(ms.SessionSum(2)).ToShortTimeString();
                        string st2 = DateTime.Now.ToShortTimeString();

                        DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                        DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                        var fark = t2 - t1;

                        item.Text =
                        string.Format("{0}{1}{2}",
                        fark.Days > 0 ? string.Format("{0} gün", fark.Days) : "",
                        fark.Hours > 0 ? string.Format("{0} gün", fark.Days) : "",
                        fark.Minutes > 0 ? string.Format("{0} dakika", fark.Minutes) : "").Trim() + "\n\n\nMasa" + dr["ID"].ToString();

                        item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.desktop_wallpaper_deep_red_for_your_mobile_tablet_explore_deep_red_deep_red_deep_red_background_deep_blue);
                    }
                    else if(item.Name == "button" + dr["ID"].ToString() && dr["DURUM"].ToString() == "3")
                    {
                        item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.images);
                    }
                    else if (item.Name == "button" + dr["ID"].ToString() && dr["DURUM"].ToString() == "4")
                    {
                        item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.efa8fccd313b6ed1c70a94fedc0f9417);
                    }
                }
            }
        }
    }
}
