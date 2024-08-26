using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Reflection;

namespace odev2_odeme_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            string secilenOdemeTipi = Convert.ToString(cmbOdemeTipi.SelectedValue);
            double tutar = Convert.ToDouble(txtTutar.Text);
            Odeme odeme;
            string mesaj = "";

            OdemeIslemiFactory odemeIslemiFactory = new OdemeIslemiFactory();
            var olusturulanNesne = odemeIslemiFactory.NesneOlustur(secilenOdemeTipi);
            odeme = new Odeme(olusturulanNesne);
            mesaj = odeme.ode(tutar);
            lblSonuc.Text = mesaj;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdemeTipiGetir();
        }

        public void OdemeTipiGetir()
        {
            string connectionString =
                @"
                Data Source=DESKTOP-R0UI159\SQLEXPRESS01;
                Initial Catalog=RadoreDB;
                Integrated Security=SSPI;
                ";
            List<OdemeTipi> odemeTipleri = null;
            OdemeTipi odemeTipi = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sorgu = "select * from OdemeTipleri";
                    SqlCommand sqlCommand = new SqlCommand(sorgu, conn);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi()
                    {
                        id = -1,
                        displayName = "Ödeme Tipi Seçiniz",
                        className = "Ödeme Tipi Seçiniz"
                    });
                    while (reader.Read())
                    {
                        odemeTipleri.Add(new OdemeTipi()
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            className = Convert.ToString(reader["CLASS_NAME"]),
                            displayName = Convert.ToString(reader["DISPLAY_NAME"])
                        });

                    }

                    //4 tane ödeme tipi þeklinde veri alan listenin içinde elemanýmýz var

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluþtu: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }

                cmbOdemeTipi.DataSource = odemeTipleri;
                cmbOdemeTipi.DisplayMember = "displayName";
                cmbOdemeTipi.ValueMember = "className";


            }
        }

        

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Odeme odeme;
            // ComboBox'tan seçilen ödeme tipini al
            string secilenOdemeTipi = cmbOdemeTipi.SelectedValue.ToString();


            // ClassChecker kullanarak sýnýfýn var olup olmadýðýný kontrol et
            ClassChecker checker = new ClassChecker();
            bool classVarmi = checker.ClassExists(secilenOdemeTipi);

            // Eðer sýnýf yoksa dinamik olarak oluþtur
            if (!classVarmi)
            {
                Type yeniSinif = checker.SinifKontrolVeOlustur(secilenOdemeTipi);
            }

            // OdemeIslemiFactory kullanarak nesneyi oluþtur ve iþlemi gerçekleþtir
            OdemeIslemiFactory factory = new OdemeIslemiFactory();
            IOdeme olusturulanNesne = factory.NesneOlustur(secilenOdemeTipi);
            odeme = new Odeme(olusturulanNesne);

            if (odeme != null)
            {
                odeme.ode(tutar);

            }

            MessageBox.Show("Ödeme türü seçilemedi.");
            
        }
    }
}
