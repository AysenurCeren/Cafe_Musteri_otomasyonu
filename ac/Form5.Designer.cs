
namespace ac
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Kart_Tarih = new System.Windows.Forms.Label();
            this.Kart_Güvenlik = new System.Windows.Forms.Label();
            this.Kart_No = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.Label();
            this.odeme = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Kart_Tarih);
            this.groupBox1.Controls.Add(this.Kart_Güvenlik);
            this.groupBox1.Controls.Add(this.Kart_No);
            this.groupBox1.Controls.Add(this.AD);
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖDEME İŞLEMLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 20);
            this.textBox3.TabIndex = 41;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 20);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Kart_Tarih
            // 
            this.Kart_Tarih.AutoSize = true;
            this.Kart_Tarih.BackColor = System.Drawing.Color.DarkGray;
            this.Kart_Tarih.Location = new System.Drawing.Point(27, 117);
            this.Kart_Tarih.Name = "Kart_Tarih";
            this.Kart_Tarih.Size = new System.Drawing.Size(117, 13);
            this.Kart_Tarih.TabIndex = 7;
            this.Kart_Tarih.Text = "Kart son Kullanım Tarihi";
            this.Kart_Tarih.Click += new System.EventHandler(this.Kart_Tarih_Click);
            // 
            // Kart_Güvenlik
            // 
            this.Kart_Güvenlik.AutoSize = true;
            this.Kart_Güvenlik.BackColor = System.Drawing.Color.DarkGray;
            this.Kart_Güvenlik.Location = new System.Drawing.Point(26, 91);
            this.Kart_Güvenlik.Name = "Kart_Güvenlik";
            this.Kart_Güvenlik.Size = new System.Drawing.Size(118, 13);
            this.Kart_Güvenlik.TabIndex = 6;
            this.Kart_Güvenlik.Text = "Kart Güvenlik Numarası";
            this.Kart_Güvenlik.Click += new System.EventHandler(this.Kart_Güvenlik_Click);
            // 
            // Kart_No
            // 
            this.Kart_No.AutoSize = true;
            this.Kart_No.BackColor = System.Drawing.Color.DarkGray;
            this.Kart_No.Location = new System.Drawing.Point(27, 68);
            this.Kart_No.Name = "Kart_No";
            this.Kart_No.Size = new System.Drawing.Size(73, 13);
            this.Kart_No.TabIndex = 5;
            this.Kart_No.Text = "Kart Numarası";
            this.Kart_No.Click += new System.EventHandler(this.Kart_No_Click);
            // 
            // AD
            // 
            this.AD.AutoSize = true;
            this.AD.BackColor = System.Drawing.Color.DarkGray;
            this.AD.Location = new System.Drawing.Point(26, 45);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(53, 13);
            this.AD.TabIndex = 4;
            this.AD.Text = "Ad-Soyad";
            this.AD.Click += new System.EventHandler(this.AD_Click);
            // 
            // odeme
            // 
            this.odeme.BackColor = System.Drawing.Color.Ivory;
            this.odeme.ForeColor = System.Drawing.Color.Olive;
            this.odeme.Location = new System.Drawing.Point(178, 239);
            this.odeme.Name = "odeme";
            this.odeme.Size = new System.Drawing.Size(58, 23);
            this.odeme.TabIndex = 38;
            this.odeme.Text = "ÖDEME";
            this.odeme.UseVisualStyleBackColor = false;
            this.odeme.Click += new System.EventHandler(this.odeme_Click);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Ivory;
            this.iptal.ForeColor = System.Drawing.Color.Olive;
            this.iptal.Location = new System.Drawing.Point(261, 239);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(58, 23);
            this.iptal.TabIndex = 39;
            this.iptal.Text = "İPTAL";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 284);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.odeme);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Kart_Tarih;
        private System.Windows.Forms.Label Kart_Güvenlik;
        private System.Windows.Forms.Label Kart_No;
        private System.Windows.Forms.Label AD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button odeme;
        private System.Windows.Forms.Button iptal;
    }
}