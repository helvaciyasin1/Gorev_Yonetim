namespace GorevYonetimUygulamasi
{
    partial class Form2
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
            this.txtGirisEposta = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnGirisSifremiUnuttum = new System.Windows.Forms.Button();
            this.chkSifreGoster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eposta:";
            // 
            // txtGirisEposta
            // 
            this.txtGirisEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGirisEposta.Location = new System.Drawing.Point(71, 6);
            this.txtGirisEposta.Name = "txtGirisEposta";
            this.txtGirisEposta.Size = new System.Drawing.Size(208, 22);
            this.txtGirisEposta.TabIndex = 1;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGirisSifre.Location = new System.Drawing.Point(71, 34);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(208, 22);
            this.txtGirisSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Location = new System.Drawing.Point(149, 88);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(130, 50);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnGirisSifremiUnuttum
            // 
            this.btnGirisSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisSifremiUnuttum.Location = new System.Drawing.Point(15, 88);
            this.btnGirisSifremiUnuttum.Name = "btnGirisSifremiUnuttum";
            this.btnGirisSifremiUnuttum.Size = new System.Drawing.Size(130, 50);
            this.btnGirisSifremiUnuttum.TabIndex = 5;
            this.btnGirisSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnGirisSifremiUnuttum.UseVisualStyleBackColor = true;
            this.btnGirisSifremiUnuttum.Click += new System.EventHandler(this.btnGirisSifremiUnuttum_Click);
            // 
            // chkSifreGoster
            // 
            this.chkSifreGoster.AutoSize = true;
            this.chkSifreGoster.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSifreGoster.Location = new System.Drawing.Point(71, 62);
            this.chkSifreGoster.Name = "chkSifreGoster";
            this.chkSifreGoster.Size = new System.Drawing.Size(98, 20);
            this.chkSifreGoster.TabIndex = 6;
            this.chkSifreGoster.Text = "Şifremi göster";
            this.chkSifreGoster.UseVisualStyleBackColor = true;
            this.chkSifreGoster.CheckedChanged += new System.EventHandler(this.chkSifreGoster_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 149);
            this.Controls.Add(this.chkSifreGoster);
            this.Controls.Add(this.btnGirisSifremiUnuttum);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGirisEposta);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGirisEposta;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnGirisSifremiUnuttum;
        private System.Windows.Forms.CheckBox chkSifreGoster;
    }
}