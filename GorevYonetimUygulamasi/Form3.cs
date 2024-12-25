using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GorevYonetimUygulamasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


            // Form3'ü küçük yapmak için
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit pencere sınırları
            this.StartPosition = FormStartPosition.CenterParent; // Form2'nin ortasında açılması için
            this.MaximizeBox = false; // Pencerenin büyütülmesini engelle
            this.MinimizeBox = false; // Pencerenin küçültülmesini engelle
            this.ClientSize = new Size(300, 200); // Küçük bir boyut belirleyin
        }

        private void btnDogrulaEposta_Click(object sender, EventArgs e)
        {
            string eposta = txtDogrulaEposta.Text.Trim();

            if (IsValidEmail(eposta))
            {
                // Doğrulama başarılı
                MessageBox.Show("Doğrulama bağlantınız e-posta adresinize gönderilmiştir.",
                                "Başarılı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close(); // Form3 kapanır
            }
            else
            {
                // Geçersiz e-posta
                MessageBox.Show("Geçersiz bir e-posta adresi girdiniz. Lütfen tekrar deneyin.",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnEpostaHatirlamiyorum_Click(object sender, EventArgs e)
        {
            // Rastgele iletişim bilgileri oluşturuluyor
            Random rnd = new Random();
            string[] telefonNumaralari = { "0531 123 45 67", "0554 234 56 78", "0532 345 67 89" };
            string[] ePostalar = { "iletisim@firma.com", "yardim@firma.com", "destek@firma.com" };

            // Rastgele telefon numarası ve e-posta seç
            string telefon = telefonNumaralari[rnd.Next(telefonNumaralari.Length)];
            string eposta = ePostalar[rnd.Next(ePostalar.Length)];

            // MessageBox ile kullanıcıya bilgi ver
            MessageBox.Show($"Şifrenizi unuttuysanız, lütfen aşağıdaki iletişim bilgileri ile bizimle iletişime geçiniz:\n\n" +
                            $"Telefon: {telefon}\nE-posta: {eposta}\n\nLütfen iletişime geçiniz.",
                            "Şifremi Unuttum",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close(); // Form3 kapanır
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                // SQL bağlantısını açıyoruz
                using (SqlConnection connection = new SqlConnection("Server=NBTHNK09;Database=GorevYonetim;Integrated Security=True;"))
                {
                    connection.Open();

                    // Veritabanında girilen e-posta adresinin var olup olmadığını kontrol ediyoruz
                    string query = "SELECT COUNT(*) FROM Personel WHERE Eposta = @Eposta";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Eposta", email);

                    // Eğer sonuç 0'dan büyükse, e-posta veritabanında bulunuyor demektir
                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        return true; // E-posta veritabanında mevcut
                    }
                    else
                    {
                        return false; // E-posta veritabanında mevcut değil
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Eğer bir hata olursa, geçerli e-posta kontrolü başarısız
            }
        }

        private void txtDogrulaEposta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
