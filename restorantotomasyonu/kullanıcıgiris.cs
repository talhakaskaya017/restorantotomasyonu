namespace restorantotomasyonu
{
    public partial class kullanıcıgiris : Form
    {
        public kullanıcıgiris()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();
        private void kullanıcıgiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEnrtyControl(textBox1.Text, cGenel._personelId);
            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş yapıldı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide(); //Bu sat�r, mevcut formu gizler. Yani, form penceresi kullan�c� taraf�ndan g�r�nmez hale gelir. Form kapat�lmaz, sadece kullan�c� ekran�nda g�r�nmez.
                AnaMenu menu = new AnaMenu();
                menu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
                if(MessageBox.Show("Çıkmak istediğinize emin misiniz?","Uyarı !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)comboBox1.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}