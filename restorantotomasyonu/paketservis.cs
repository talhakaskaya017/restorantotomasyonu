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
    public partial class paketservis : Form
    {
        public paketservis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {

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
            Masalar masa = new Masalar();
            this.Close();
            masa.Show();
        }
        //Hesap Makinesi
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtadet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtadet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtadet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtadet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtadet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtadet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtadet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtadet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtadet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtadet.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("Sayı Gir:");
                    break;
            }
        }
        private void paketservis_Load(object sender, EventArgs e)
        {

            label1.Text = cGenel._buttonValue; //burası sıkıntılı

            cMasalar ms = new cMasalar();
            int tableId = ms.TableGetbyNumber(cGenel._buttonName);
            if (ms.TableGetbyState(tableId, 2) == true || ms.TableGetbyState(tableId, 4) == true)
            {
                cAdisyon Ad = new cAdisyon();
                int AdditionId = Ad.getByAddition(tableId);
                cSiparis orders = new cSiparis();
                orders.getByOrder(lvSiparisler, AdditionId);
            }


            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);

        }






        cUruncesitleri Uc = new cUruncesitleri();
        private void btnAnaYemek3_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnAnaYemek3);
        }

        private void btnİcecek8_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnİcecek8);
        }

        private void btnFastfood5_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnFastfood5);
        }

        private void btnSalatalar6_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnSalatalar6);
        }

        private void btnTatlı7_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnTatlı7);
        }

        private void btnÇorba1_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnÇorba1);
        }

        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnMakarna4);
        }

        private void btnArasicak2_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnArasicak2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
