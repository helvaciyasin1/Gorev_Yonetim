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
    public partial class Form1 : Form
    {
        // Veritabanı bağlantı dizesi (kendi sunucu ve veritabanı bilgilerinizi girin)
        string connectionString = ("Server=NBTHNK09;Database=GorevYonetim;Integrated Security=True;");

        string girisEposta;
        string girisDepartman;

        public Form1()
        {
            InitializeComponent();
            // Form yüklendiğinde departmanları çek
            LoadDepartmanlar();
        }

        // Parametreli constructor (Form2'den gelen değerler ile)
        public Form1(string eposta, string departman)
        {
            InitializeComponent();
            girisEposta = eposta;
            girisDepartman = departman;

            // Label'ları güncelliyoruz
            lblKimdenEposta.Text = girisEposta;
            lblKimdenDepartman.Text = girisDepartman;
        }

        // Veritabanı bağlantısını açan metot
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddToolTips(); // ToolTip'leri yükleme sırasında ekle

            // Bağlantıyı test et
            TestDatabaseConnection();

            // E-posta adresini küçük harfe çeviriyoruz
            string eposta = lblKimdenEposta.Text.ToLower().Trim();

            // Departmanı alırken baş harfi büyük tutuyoruz
            string departman = lblKimdenDepartman.Text.Trim();

            // Alınan görevler için veri yükle
            LoadAlinanGorevler(eposta);

            // Verilen görevler için veri yükle
            LoadVerilenGorevler(eposta);

            // Departman görevleri için veri yükle
            LoadDepartmanim(eposta, departman);


            // Departmanları yükle
            LoadDepartmanlar();

            // Tüm DataGridView'lerin CellFormatting olaylarına abone ol
            dgvAlinanGorevler.CellFormatting += dgvGorevler_CellFormatting;
            dgvVerilenGorevler.CellFormatting += dgvGorevler_CellFormatting;
            dgvDepartmanim.CellFormatting += dgvGorevler_CellFormatting;

        }

        private void dgvGorevler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Durum sütununu kontrol et
            if (e.ColumnIndex == dgvAlinanGorevler.Columns["Durum"].Index ||
                e.ColumnIndex == dgvVerilenGorevler.Columns["Durum"].Index ||
                e.ColumnIndex == dgvDepartmanim.Columns["Durum"].Index)
            {
                // Eğer hücrede 0 değeri varsa "Devam Ediyor", 1 değeri varsa "Tamamlandı" olarak göster
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "0")
                    {
                        e.Value = "Devam Ediyor";
                    }
                    else if (e.Value.ToString() == "1")
                    {
                        e.Value = "Tamamlandı";
                    }
                }
            }
        }

        private void TestDatabaseConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Bağlantı başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }

        // Departmanları combobox'a yükle
        private void LoadDepartmanlar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT departman FROM Personel";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbDepartman.Items.Clear();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("departman")))
                        {
                            string departman = reader.GetString(reader.GetOrdinal("departman")).Trim();
                            if (!cmbDepartman.Items.Contains(departman)) // Daha önce eklenmişse tekrar eklenmesin
                            {
                                cmbDepartman.Items.Add(departman);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departman yükleme hatası: " + ex.Message);
            }
        }

        // Epostaları combobox'a yükle
        private void LoadEpostalar(string departman)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT eposta FROM Personel WHERE departman = @departman";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@departman", SqlDbType.NVarChar).Value = departman;
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbEposta.Items.Clear();
                    bool hasEposta = false;
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("eposta")))
                        {
                            string eposta = reader.GetString(reader.GetOrdinal("eposta")).Trim();
                            if (!string.IsNullOrEmpty(eposta))
                            {
                                cmbEposta.Items.Add(eposta);
                                hasEposta = true;
                            }
                        }
                    }

                    if (!hasEposta)
                    {
                        MessageBox.Show("Seçilen departmanda e-posta bulunmamaktadır.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta yükleme hatası: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Görev başlığı kontrolü
            if (string.IsNullOrWhiteSpace(txtBaslik.Text))
            {
                MessageBox.Show("Görev başlığı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tarih kontrolü
            if (dtpTarih.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Görev tarihi bugünden eski olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Görev bilgilerini al
            string baslik = txtBaslik.Text.Trim();
            string aciklama = rtxtAciklama.Text.Trim();
            string tarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            int durum = 0; // Yeni görevler başlangıçta yapılmadı

            // Görevi veritabanına ekleme
            using (var conn = GetConnection())
            {
                string query = "INSERT INTO gorevler (baslik, aciklama, tarih, durum) VALUES (@baslik, @aciklama, @tarih, @durum)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@baslik", baslik);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@durum", durum);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Görev başarıyla veritabanına kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Alanları temizle
            txtBaslik.Clear();
            rtxtAciklama.Clear();
            dtpTarih.Value = DateTime.Now;
        }





       

        private void cmbDepartman_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedItem != null)
            {
                string selectedDepartman = cmbDepartman.SelectedItem.ToString().Trim();
                if (!string.IsNullOrEmpty(selectedDepartman))
                {
                    LoadEpostalar(selectedDepartman);
                }
            }
            else
            {
                // Seçim yapılmadığında işlem yapma
                MessageBox.Show("Lütfen bir departman seçiniz.");
            }
        }

        public void SetKimdenEposta(string eposta)
        {
            lblKimdenEposta.Text = eposta; // Etiketi e-posta ile güncelle
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kullanıcıdan onay al
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal et
            }
            else
            {
                // Tüm uygulamayı kapat
                Environment.Exit(0);
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            // Görev bilgilerini form alanlarından al
            string baslik = txtBaslik.Text.Trim();
            string aciklama = rtxtAciklama.Text.Trim();
            string kimdenDepartman = lblKimdenDepartman.Text.Trim();
            string kimeDepartman = cmbDepartman.SelectedItem?.ToString();
            string kimdenEposta = lblKimdenEposta.Text.Trim();
            string kimeEposta = cmbEposta.SelectedItem?.ToString();
            string aciliyet = "";

            // Aciliyet durumunu belirle
            if (rbtnAcil.Checked)
                aciliyet = "Acil";
            else if (rbtnOncelikli.Checked)
                aciliyet = "Oncelikli";
            else if (rbtnErtelenebilir.Checked)
                aciliyet = "Ertelenebilir";

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(baslik) || string.IsNullOrWhiteSpace(aciklama) ||
                string.IsNullOrWhiteSpace(kimdenDepartman) || string.IsNullOrWhiteSpace(kimeDepartman) ||
                string.IsNullOrWhiteSpace(kimdenEposta) || string.IsNullOrWhiteSpace(kimeEposta) ||
                string.IsNullOrWhiteSpace(aciliyet))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Görev ekleme SQL sorgusu
                string query = "INSERT INTO Gorevler (Baslik, Aciklama, KimdenDepartman, KimeDepartman, Kimden, Kime, Aciliyet, AtamaTarihi) " +
                               "VALUES (@Baslik, @Aciklama, @KimdenDepartman, @KimeDepartman, @Kimden, @Kime, @Aciliyet, @AtamaTarihi)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@Baslik", baslik);
                        cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                        cmd.Parameters.AddWithValue("@KimdenDepartman", kimdenDepartman);
                        cmd.Parameters.AddWithValue("@KimeDepartman", kimeDepartman);
                        cmd.Parameters.AddWithValue("@Kimden", kimdenEposta);
                        cmd.Parameters.AddWithValue("@Kime", kimeEposta);
                        cmd.Parameters.AddWithValue("@Aciliyet", aciliyet);
                        cmd.Parameters.AddWithValue("@AtamaTarihi", DateTime.Now);

                        // Sorguyu çalıştır
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Görev başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Görev eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDepartman_TextChanged(object sender, EventArgs e)
        {
            // E-posta combobox'ındaki seçimi kaldır
            cmbEposta.SelectedIndex = -1; // Seçilen öğeyi kaldırır
                                          // veya
            cmbEposta.SelectedItem = null; // Seçilen öğeyi null yapar
        }

        private void LoadAlinanGorevler(string eposta)
        {
            try
            {
                string query = "SELECT * FROM Gorevler WHERE Kime = @eposta";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@eposta", eposta);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAlinanGorevler.DataSource = dt;

                    // Sütun sırasını değiştirmek ve gizlemek
                    // Gizlemek istediğiniz sütunları gizleyin
                    dgvAlinanGorevler.Columns["Kime"].Visible = false;
                    dgvAlinanGorevler.Columns["KimeDepartman"].Visible = false;

                    // Sütun sırasını belirleyin
                    dgvAlinanGorevler.Columns["id"].DisplayIndex = 0;
                    dgvAlinanGorevler.Columns["Durum"].DisplayIndex = 1;
                    dgvAlinanGorevler.Columns["AtamaTarihi"].DisplayIndex = 2;
                    dgvAlinanGorevler.Columns["Aciliyet"].DisplayIndex = 3;
                    dgvAlinanGorevler.Columns["KimdenDepartman"].DisplayIndex = 4;
                    dgvAlinanGorevler.Columns["Kimden"].DisplayIndex = 5;
                    dgvAlinanGorevler.Columns["Baslik"].DisplayIndex = 6;
                    dgvAlinanGorevler.Columns["Aciklama"].DisplayIndex = 7;
                    dgvAlinanGorevler.Columns["TamamlanmaTarihi"].DisplayIndex = 8;
                    dgvAlinanGorevler.Columns["SonAciklama"].DisplayIndex = 9;
                    dgvAlinanGorevler.Columns["Sonuc"].DisplayIndex = 10;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alınan görevler yüklenirken hata oluştu: " + ex.Message);
            }
        }


        private void LoadVerilenGorevler(string eposta)
        {
            try
            {
                string query = "SELECT * FROM Gorevler WHERE Kimden = @eposta";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@eposta", eposta);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvVerilenGorevler.DataSource = dt;

                    // Sütun sırasını değiştirme ve gizleme
                    dgvVerilenGorevler.Columns["Kimden"].Visible = false;
                    dgvVerilenGorevler.Columns["KimdenDepartman"].Visible = false;

                    // Sütun sırasını belirleyin
                    dgvVerilenGorevler.Columns["id"].DisplayIndex = 0;
                    dgvVerilenGorevler.Columns["Durum"].DisplayIndex = 1;
                    dgvVerilenGorevler.Columns["AtamaTarihi"].DisplayIndex = 2;
                    dgvVerilenGorevler.Columns["Aciliyet"].DisplayIndex = 3;
                    dgvVerilenGorevler.Columns["KimeDepartman"].DisplayIndex = 4;
                    dgvVerilenGorevler.Columns["Kime"].DisplayIndex = 5;
                    dgvVerilenGorevler.Columns["Baslik"].DisplayIndex = 6;
                    dgvVerilenGorevler.Columns["Aciklama"].DisplayIndex = 7;
                    dgvVerilenGorevler.Columns["TamamlanmaTarihi"].DisplayIndex = 8;
                    dgvVerilenGorevler.Columns["SonAciklama"].DisplayIndex = 9;
                    dgvVerilenGorevler.Columns["Sonuc"].DisplayIndex = 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verilen görevler yüklenirken hata oluştu: " + ex.Message);
            }
        }


        private void LoadDepartmanim(string eposta, string departman)
        {
            try
            {
                // Kullanıcı Yöneticimi kontrol et
                string checkQuery = "SELECT Yonetici FROM Personel WHERE Eposta = @eposta";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(checkQuery, connection);
                    cmd.Parameters.AddWithValue("@eposta", eposta);
                    connection.Open();
                    var result = cmd.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) == 1) // Yöneticiyse
                    {
                        // Yöneticilere ait görevleri al
                        string query = "SELECT * FROM Gorevler WHERE KimeDepartman = @departman OR KimdenDepartman = @departman";
                        SqlDataAdapter da = new SqlDataAdapter(query, connection);
                        da.SelectCommand.Parameters.AddWithValue("@departman", departman);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvDepartmanim.DataSource = dt;

                        // Sütun sırasını değiştirme
                        dgvDepartmanim.Columns["id"].DisplayIndex = 0;
                        dgvDepartmanim.Columns["Durum"].DisplayIndex = 1;
                        dgvDepartmanim.Columns["Aciliyet"].DisplayIndex = 2;
                        dgvDepartmanim.Columns["AtamaTarihi"].DisplayIndex = 3;
                        dgvDepartmanim.Columns["KimdenDepartman"].DisplayIndex = 4;
                        dgvDepartmanim.Columns["KimeDepartman"].DisplayIndex = 5;
                        dgvDepartmanim.Columns["Baslik"].DisplayIndex = 6;
                        dgvDepartmanim.Columns["Aciklama"].DisplayIndex = 7;
                        dgvDepartmanim.Columns["TamamlanmaTarihi"].DisplayIndex = 8;
                        dgvDepartmanim.Columns["SonAciklama"].DisplayIndex = 9;
                        dgvDepartmanim.Columns["Sonuc"].DisplayIndex = 10;
                        dgvDepartmanim.Columns["Kimden"].DisplayIndex = 11;
                        dgvDepartmanim.Columns["Kime"].DisplayIndex = 12;
                    }
                    else
                    {
                        MessageBox.Show("Yalnızca yöneticiler görevleri görebilir.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departman görevleri yüklenirken hata oluştu: " + ex.Message);
            }
        }


        private void btnTamamladi_Click(object sender, EventArgs e)
        {
            if (dgvAlinanGorevler.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçili satırdan GorevID değerini al
                    int gorevID = Convert.ToInt32(dgvAlinanGorevler.SelectedRows[0].Cells["id"].Value);

                    // rtxtGorevSonuAciklama'dan metni al
                    string sonAciklama = rtxtGorevSonuAciklama.Text;

                    using (SqlConnection connection = new SqlConnection("Server=NBTHNK09;Database=GorevYonetim;Integrated Security=True;"))
                    {
                        connection.Open();

                        // Görevi tamamlanmış olarak işaretlemek için SQL komutu
                        string query = @"
        UPDATE Gorevler 
        SET 
            TamamlanmaTarihi = @TamamlanmaTarihi, 
            SonAciklama = @SonAciklama,
            Durum = 1  -- Durum sütununu 1 yap
        WHERE 
            id = @GorevID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@TamamlanmaTarihi", DateTime.Now);
                            command.Parameters.AddWithValue("@SonAciklama", sonAciklama);
                            command.Parameters.AddWithValue("@GorevID", gorevID);

                            // Komutu çalıştır
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Görev başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Görev tamamlanamadı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının e-posta ve departman bilgilerini alıyoruz
                string eposta = lblKimdenEposta.Text; // E-posta bilgisi txtEposta TextBox'ından alınacak
                string departman = lblKimdenDepartman.Text; // Departman bilgisi txtDepartman TextBox'ından alınacak

                // LoadAlinanGorevler fonksiyonunu çağırıyoruz
                LoadAlinanGorevler(eposta);

                // LoadVerilenGorevler fonksiyonunu çağırıyoruz
                LoadVerilenGorevler(eposta);

                // LoadDepartmanim fonksiyonunu çağırıyoruz
                LoadDepartmanim(eposta, departman);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnDegerlendir_Click(object sender, EventArgs e)
        {
            if (dgvVerilenGorevler.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçili satırdan GorevID değerini al
                    int gorevID = Convert.ToInt32(dgvVerilenGorevler.SelectedRows[0].Cells["id"].Value);

                    // Seçilen radio button'a göre Sonuc değeri belirle
                    string sonucValue = string.Empty;
                    if (rbtnIyi.Checked)
                    {
                        sonucValue = "İyi";
                    }
                    else if (rbtnOrtalama.Checked)
                    {
                        sonucValue = "Ortalama";
                    }
                    else if (rbtnKotu.Checked)
                    {
                        sonucValue = "Kötü";
                    }

                    // Veritabanına bağlan
                    using (SqlConnection connection = new SqlConnection("Server=NBTHNK09;Database=GorevYonetim;Integrated Security=True;"))
                    {
                        connection.Open();

                        // Sonuç bilgilerini güncellemek için SQL komutu
                        string query = @"
                    UPDATE Gorevler 
                    SET 
                        Sonuc = @Sonuc
                    WHERE 
                        id = @GorevID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@Sonuc", sonucValue);
                            command.Parameters.AddWithValue("@GorevID", gorevID);

                            // Komutu çalıştır
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Değerlendirme başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Değerlendirme kaydedilemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToolTips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnEkle, "Yeni bir görev eklemek için tıklayın.");
            toolTip.SetToolTip(btnTamamladi, "Seçili görevi tamamlandı olarak işaretleyin.");
            toolTip.SetToolTip(btnDegerlendir, "Görev değerlendirmesi yapmak için tıklayın.");
        }

        private void ExampleFunction()
        {
            try
            {
                // Örnek bir işlem
                string query = "SELECT * FROM Gorevler";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    // Veri işleme kodları
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
