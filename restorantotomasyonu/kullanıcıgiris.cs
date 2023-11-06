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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEnrtyControl(txtSifre.Text, gnl._personelId);
            if (result)
            {
                this.Hide(); //Bu sat�r, mevcut formu gizler. Yani, form penceresi kullan�c� taraf�ndan g�r�nmez hale gelir. Form kapat�lmaz, sadece kullan�c� ekran�nda g�r�nmez.
                AnaMenu menu = new AnaMenu();
                menu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}