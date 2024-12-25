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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri al
            string girisEposta = txtGirisEposta.Text.Trim();
            string girisSifre = txtGirisSifre.Text.Trim();

            // Kullanıcının girdiği şifreyi SHA-256 ile hash'le
            string hashedSifre = HashPassword(girisSifre);

            // Kullanıcı girişini doğrulama
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=NBTHNK09;Database=GorevYonetim;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Personel WHERE Eposta = @Eposta AND SifreHash = @SifreHash";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Eposta", girisEposta);
                    cmd.Parameters.AddWithValue("@SifreHash", hashedSifre);

                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        // Giriş başarılı, ana forma geç
                        MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Departman bilgisini al
                        string departman = GetDepartmanByEposta(girisEposta);

                        // Form1'i parametreli constructor ile aç
                        Form1 mainForm = new Form1(girisEposta, departman);

                        // Ana formu aç
                        mainForm.Show();

                        // Login formunu gizle
                        this.Hide();
                    }
                    else
                    {
                        // Hatalı giriş
                        string enteredHash = HashPassword(girisSifre); // Girilen şifrenin hash'ini al
                        MessageBox.Show($"E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDepartmanByEposta(string eposta)
        {
            string departman = "";
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=NBTHNK09;Database=GorevYonetim;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "SELECT Departman FROM Personel WHERE Eposta = @Eposta";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Eposta", eposta);

                    departman = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departman alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return departman;
        }




        // Şifreyi hash'leyen fonksiyon
        private string HashPassword(string password)
        {
            using (var sha512 = new System.Security.Cryptography.SHA512Managed())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha512.ComputeHash(bytes);
                string hashResult = BitConverter.ToString(hash).Replace("-", "").ToLower(); // Küçük harflerle hex formatında döndür
                return hashResult.ToUpper(); // Tüm harfleri büyük yap
            }
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            // Başlangıçta şifreyi gizle (yıldızlarla göster)
            txtGirisSifre.PasswordChar = '*';
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox işaretli ise şifreyi göster, işaretli değilse gizle
            if (chkSifreGoster.Checked)
            {
                txtGirisSifre.PasswordChar = '\0'; // Şifreyi göster
            }
            else
            {
                txtGirisSifre.PasswordChar = '*'; // Şifreyi gizle (yıldızla göster)
            }
        }

        private void btnGirisSifremiUnuttum_Click(object sender, EventArgs e)
        {
            // Şifremi unuttum butonuna tıklanınca Form3 açılır
            Form3 form3 = new Form3();
            form3.ShowDialog();  // ShowDialog() ile modül form olarak açılır, Form2 kapanmaz

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
