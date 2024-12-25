namespace GorevYonetimUygulamasi
{
    partial class Form3
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
            this.txtDogrulaEposta = new System.Windows.Forms.TextBox();
            this.btnDogrulaEposta = new System.Windows.Forms.Button();
            this.btnEpostaHatirlamiyorum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDogrulaEposta
            // 
            this.txtDogrulaEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDogrulaEposta.Location = new System.Drawing.Point(71, 6);
            this.txtDogrulaEposta.Name = "txtDogrulaEposta";
            this.txtDogrulaEposta.Size = new System.Drawing.Size(208, 22);
            this.txtDogrulaEposta.TabIndex = 0;
            this.txtDogrulaEposta.TextChanged += new System.EventHandler(this.txtDogrulaEposta_TextChanged);
            // 
            // btnDogrulaEposta
            // 
            this.btnDogrulaEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDogrulaEposta.Location = new System.Drawing.Point(12, 34);
            this.btnDogrulaEposta.Name = "btnDogrulaEposta";
            this.btnDogrulaEposta.Size = new System.Drawing.Size(267, 50);
            this.btnDogrulaEposta.TabIndex = 1;
            this.btnDogrulaEposta.Text = "Şifremi  Yenile";
            this.btnDogrulaEposta.UseVisualStyleBackColor = true;
            this.btnDogrulaEposta.Click += new System.EventHandler(this.btnDogrulaEposta_Click);
            // 
            // btnEpostaHatirlamiyorum
            // 
            this.btnEpostaHatirlamiyorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEpostaHatirlamiyorum.Location = new System.Drawing.Point(12, 90);
            this.btnEpostaHatirlamiyorum.Name = "btnEpostaHatirlamiyorum";
            this.btnEpostaHatirlamiyorum.Size = new System.Drawing.Size(267, 50);
            this.btnEpostaHatirlamiyorum.TabIndex = 2;
            this.btnEpostaHatirlamiyorum.Text = "Eposta Adresimi Hatırlamıyorum";
            this.btnEpostaHatirlamiyorum.UseVisualStyleBackColor = true;
            this.btnEpostaHatirlamiyorum.Click += new System.EventHandler(this.btnEpostaHatirlamiyorum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eposta:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEpostaHatirlamiyorum);
            this.Controls.Add(this.btnDogrulaEposta);
            this.Controls.Add(this.txtDogrulaEposta);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDogrulaEposta;
        private System.Windows.Forms.Button btnDogrulaEposta;
        private System.Windows.Forms.Button btnEpostaHatirlamiyorum;
        private System.Windows.Forms.Label label1;
    }
}