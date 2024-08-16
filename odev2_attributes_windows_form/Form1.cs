using AttributesLibrary;

namespace odev2_attributes_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                adi = txtAdi.Text,
                soyadi = txtAdi.Text,
                bolum = txtBolum.Text
            };

            if( !ZorunlulukKontrolu.Dogrula(ogrenci) )
            {
                lblSonuc.Text = "Bilgilerin girilmesi zorunludur";
            }
            else
            {
                lblSonuc.Text = "Form baþarýlý";
            }
        }
    }
}
