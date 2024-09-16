namespace ac
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
            this.giris = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullanici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Honeydew;
            this.giris.ForeColor = System.Drawing.Color.DarkGreen;
            this.giris.Location = new System.Drawing.Point(105, 167);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(98, 23);
            this.giris.TabIndex = 15;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.Color.Honeydew;
            this.kayit.ForeColor = System.Drawing.Color.DarkGreen;
            this.kayit.Location = new System.Drawing.Point(103, 125);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(100, 23);
            this.kayit.TabIndex = 14;
            this.kayit.Text = "Kayıt Ol";
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(103, 76);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 13;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // kullanici
            // 
            this.kullanici.Location = new System.Drawing.Point(103, 50);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(100, 20);
            this.kullanici.TabIndex = 12;
            this.kullanici.TextChanged += new System.EventHandler(this.kullanici_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(17, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hesabım var ->";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ŞİFRE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "KULLANICI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "KAYIT FORMU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullanici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}