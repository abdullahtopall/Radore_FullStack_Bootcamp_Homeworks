using odev2_logger_windows_form.concretes;

namespace odev2_logger_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string secilenLogger = cmbLogTipi.SelectedItem.ToString();
            string durum = txtDurum.Text;
            Logger logger;
            string mesaj = "";

            LogIslemiFactory logIslemiFactory = new LogIslemiFactory();
            var olusturulanNesne = logIslemiFactory.NesneOlustur(secilenLogger);
            logger = new Logger(olusturulanNesne);
            mesaj = durum + logger.logKaydet(mesaj);
            lblSonuc.Text = mesaj;

        }
    }
}
