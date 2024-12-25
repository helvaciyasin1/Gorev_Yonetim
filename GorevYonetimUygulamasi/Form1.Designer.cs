namespace GorevYonetimUygulamasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnOrtalama = new System.Windows.Forms.RadioButton();
            this.rbtnKotu = new System.Windows.Forms.RadioButton();
            this.rbtnIyi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.cmbEposta = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnOncelikli = new System.Windows.Forms.RadioButton();
            this.rbtnErtelenebilir = new System.Windows.Forms.RadioButton();
            this.rbtnAcil = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblKimdenEposta = new System.Windows.Forms.Label();
            this.lblKimdenDepartman = new System.Windows.Forms.Label();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvVerilenGorevler = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvDepartmanim = new System.Windows.Forms.DataGridView();
            this.rtxtGorevSonuAciklama = new System.Windows.Forms.RichTextBox();
            this.dgvAlinanGorevler = new System.Windows.Forms.DataGridView();
            this.btnTamamladi = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDegerlendir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerilenGorevler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlinanGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görev Başlığı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Görev Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(512, 2);
            this.txtBaslik.Margin = new System.Windows.Forms.Padding(2);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(426, 20);
            this.txtBaslik.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(79, 3);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(102, 20);
            this.dtpTarih.TabIndex = 6;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1217, 5);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(62, 62);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Oluştur";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(9, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 10);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1220, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Görev Sonu Açıklama:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnOrtalama);
            this.panel2.Controls.Add(this.rbtnKotu);
            this.panel2.Controls.Add(this.rbtnIyi);
            this.panel2.Location = new System.Drawing.Point(1220, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 70);
            this.panel2.TabIndex = 13;
            // 
            // rbtnOrtalama
            // 
            this.rbtnOrtalama.AutoSize = true;
            this.rbtnOrtalama.Location = new System.Drawing.Point(3, 26);
            this.rbtnOrtalama.Name = "rbtnOrtalama";
            this.rbtnOrtalama.Size = new System.Drawing.Size(67, 17);
            this.rbtnOrtalama.TabIndex = 2;
            this.rbtnOrtalama.Text = "Ortalama";
            this.rbtnOrtalama.UseVisualStyleBackColor = true;
            // 
            // rbtnKotu
            // 
            this.rbtnKotu.AutoSize = true;
            this.rbtnKotu.Location = new System.Drawing.Point(3, 49);
            this.rbtnKotu.Name = "rbtnKotu";
            this.rbtnKotu.Size = new System.Drawing.Size(47, 17);
            this.rbtnKotu.TabIndex = 1;
            this.rbtnKotu.Text = "Kötü";
            this.rbtnKotu.UseVisualStyleBackColor = true;
            // 
            // rbtnIyi
            // 
            this.rbtnIyi.AutoSize = true;
            this.rbtnIyi.Location = new System.Drawing.Point(3, 3);
            this.rbtnIyi.Name = "rbtnIyi";
            this.rbtnIyi.Size = new System.Drawing.Size(35, 17);
            this.rbtnIyi.TabIndex = 0;
            this.rbtnIyi.Text = "İyi";
            this.rbtnIyi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(944, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(944, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Departman:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(944, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Eposta:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(1012, 16);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(200, 21);
            this.cmbDepartman.TabIndex = 19;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged_1);
            this.cmbDepartman.TextChanged += new System.EventHandler(this.cmbDepartman_TextChanged);
            // 
            // cmbEposta
            // 
            this.cmbEposta.FormattingEnabled = true;
            this.cmbEposta.Location = new System.Drawing.Point(1012, 43);
            this.cmbEposta.Name = "cmbEposta";
            this.cmbEposta.Size = new System.Drawing.Size(200, 21);
            this.cmbEposta.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnOncelikli);
            this.panel3.Controls.Add(this.rbtnErtelenebilir);
            this.panel3.Controls.Add(this.rbtnAcil);
            this.panel3.Location = new System.Drawing.Point(228, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 23);
            this.panel3.TabIndex = 21;
            // 
            // rbtnOncelikli
            // 
            this.rbtnOncelikli.AutoSize = true;
            this.rbtnOncelikli.Location = new System.Drawing.Point(51, 3);
            this.rbtnOncelikli.Name = "rbtnOncelikli";
            this.rbtnOncelikli.Size = new System.Drawing.Size(65, 17);
            this.rbtnOncelikli.TabIndex = 2;
            this.rbtnOncelikli.Text = "Öncelikli";
            this.rbtnOncelikli.UseVisualStyleBackColor = true;
            // 
            // rbtnErtelenebilir
            // 
            this.rbtnErtelenebilir.AutoSize = true;
            this.rbtnErtelenebilir.Location = new System.Drawing.Point(122, 3);
            this.rbtnErtelenebilir.Name = "rbtnErtelenebilir";
            this.rbtnErtelenebilir.Size = new System.Drawing.Size(79, 17);
            this.rbtnErtelenebilir.TabIndex = 1;
            this.rbtnErtelenebilir.Text = "Ertelenebilir";
            this.rbtnErtelenebilir.UseVisualStyleBackColor = true;
            // 
            // rbtnAcil
            // 
            this.rbtnAcil.AutoSize = true;
            this.rbtnAcil.Location = new System.Drawing.Point(3, 3);
            this.rbtnAcil.Name = "rbtnAcil";
            this.rbtnAcil.Size = new System.Drawing.Size(42, 17);
            this.rbtnAcil.TabIndex = 0;
            this.rbtnAcil.Text = "Acil";
            this.rbtnAcil.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Eposta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Departman:";
            // 
            // lblKimdenEposta
            // 
            this.lblKimdenEposta.AutoSize = true;
            this.lblKimdenEposta.Location = new System.Drawing.Point(80, 46);
            this.lblKimdenEposta.Name = "lblKimdenEposta";
            this.lblKimdenEposta.Size = new System.Drawing.Size(41, 13);
            this.lblKimdenEposta.TabIndex = 26;
            this.lblKimdenEposta.Text = "label11";
            // 
            // lblKimdenDepartman
            // 
            this.lblKimdenDepartman.AutoSize = true;
            this.lblKimdenDepartman.Location = new System.Drawing.Point(80, 33);
            this.lblKimdenDepartman.Name = "lblKimdenDepartman";
            this.lblKimdenDepartman.Size = new System.Drawing.Size(41, 13);
            this.lblKimdenDepartman.TabIndex = 27;
            this.lblKimdenDepartman.Text = "label11";
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(318, 24);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(620, 40);
            this.rtxtAciklama.TabIndex = 28;
            this.rtxtAciklama.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Alınan Görevler:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Verilen Görevler:";
            // 
            // dgvVerilenGorevler
            // 
            this.dgvVerilenGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerilenGorevler.Location = new System.Drawing.Point(9, 243);
            this.dgvVerilenGorevler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVerilenGorevler.Name = "dgvVerilenGorevler";
            this.dgvVerilenGorevler.RowHeadersWidth = 51;
            this.dgvVerilenGorevler.RowTemplate.Height = 24;
            this.dgvVerilenGorevler.Size = new System.Drawing.Size(1204, 130);
            this.dgvVerilenGorevler.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Departmanım:";
            // 
            // dgvDepartmanim
            // 
            this.dgvDepartmanim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmanim.Location = new System.Drawing.Point(9, 390);
            this.dgvDepartmanim.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDepartmanim.Name = "dgvDepartmanim";
            this.dgvDepartmanim.RowHeadersWidth = 51;
            this.dgvDepartmanim.RowTemplate.Height = 24;
            this.dgvDepartmanim.Size = new System.Drawing.Size(1337, 130);
            this.dgvDepartmanim.TabIndex = 32;
            // 
            // rtxtGorevSonuAciklama
            // 
            this.rtxtGorevSonuAciklama.Location = new System.Drawing.Point(1217, 96);
            this.rtxtGorevSonuAciklama.Name = "rtxtGorevSonuAciklama";
            this.rtxtGorevSonuAciklama.Size = new System.Drawing.Size(128, 102);
            this.rtxtGorevSonuAciklama.TabIndex = 34;
            this.rtxtGorevSonuAciklama.Text = "";
            // 
            // dgvAlinanGorevler
            // 
            this.dgvAlinanGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlinanGorevler.Location = new System.Drawing.Point(9, 96);
            this.dgvAlinanGorevler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlinanGorevler.Name = "dgvAlinanGorevler";
            this.dgvAlinanGorevler.RowHeadersWidth = 51;
            this.dgvAlinanGorevler.RowTemplate.Height = 24;
            this.dgvAlinanGorevler.Size = new System.Drawing.Size(1204, 130);
            this.dgvAlinanGorevler.TabIndex = 35;
            // 
            // btnTamamladi
            // 
            this.btnTamamladi.Location = new System.Drawing.Point(1218, 204);
            this.btnTamamladi.Name = "btnTamamladi";
            this.btnTamamladi.Size = new System.Drawing.Size(128, 21);
            this.btnTamamladi.TabIndex = 36;
            this.btnTamamladi.Text = "Tamamlandı";
            this.btnTamamladi.UseVisualStyleBackColor = true;
            this.btnTamamladi.Click += new System.EventHandler(this.btnTamamladi_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1284, 5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(62, 62);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Sayfayı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDegerlendir
            // 
            this.btnDegerlendir.Location = new System.Drawing.Point(1220, 329);
            this.btnDegerlendir.Name = "btnDegerlendir";
            this.btnDegerlendir.Size = new System.Drawing.Size(128, 44);
            this.btnDegerlendir.TabIndex = 38;
            this.btnDegerlendir.Text = "Değerlendir";
            this.btnDegerlendir.UseVisualStyleBackColor = true;
            this.btnDegerlendir.Click += new System.EventHandler(this.btnDegerlendir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(214, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 59);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(99, 231);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1247, 10);
            this.panel5.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(99, 378);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1246, 10);
            this.panel6.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 551);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnDegerlendir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTamamladi);
            this.Controls.Add(this.dgvAlinanGorevler);
            this.Controls.Add(this.rtxtGorevSonuAciklama);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvDepartmanim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvVerilenGorevler);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtxtAciklama);
            this.Controls.Add(this.lblKimdenDepartman);
            this.Controls.Add(this.lblKimdenEposta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbEposta);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerilenGorevler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlinanGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnOrtalama;
        private System.Windows.Forms.RadioButton rbtnKotu;
        private System.Windows.Forms.RadioButton rbtnIyi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.ComboBox cmbEposta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnOncelikli;
        private System.Windows.Forms.RadioButton rbtnErtelenebilir;
        private System.Windows.Forms.RadioButton rbtnAcil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKimdenEposta;
        private System.Windows.Forms.Label lblKimdenDepartman;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvVerilenGorevler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvDepartmanim;
        private System.Windows.Forms.RichTextBox rtxtGorevSonuAciklama;
        private System.Windows.Forms.DataGridView dgvAlinanGorevler;
        private System.Windows.Forms.Button btnTamamladi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnDegerlendir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

