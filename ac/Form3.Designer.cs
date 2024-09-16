namespace ac
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
            this.giris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullanici = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Honeydew;
            this.giris.ForeColor = System.Drawing.Color.DarkGreen;
            this.giris.Location = new System.Drawing.Point(106, 138);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(98, 23);
            this.giris.TabIndex = 21;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(106, 86);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 20;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // kullanici
            // 
            this.kullanici.Location = new System.Drawing.Point(106, 60);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(100, 20);
            this.kullanici.TabIndex = 19;
            this.kullanici.TextChanged += new System.EventHandler(this.kullanici_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ŞİFRE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "KULLANICI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "GİRİŞ FORMU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 202);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}