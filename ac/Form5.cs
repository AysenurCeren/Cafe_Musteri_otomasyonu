using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ac
{
    public partial class Form5 : Form
    {
        Baglanti baglanti;

        public Form5()
        {
            InitializeComponent();
            textBox2.TextChanged += textBox2_TextChanged; // TextBox2'de metin değiştiğinde olayı tanımla
            textBox3.TextChanged += textBox3_TextChanged; // TextBox2'de metin değiştiğinde olayı tanımla
            // Bağlantı oluşturucuyu başlat
            baglanti = new Baglanti("SANIZ\\SQLEXPRESS", "Cafe3", "", "");


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          


        }

        private void AD_Click(object sender, EventArgs e)
        {

        }

        private void Kart_No_Click(object sender, EventArgs e)
        {

        }

        private void Kart_Güvenlik_Click(object sender, EventArgs e)
        {

        }

        private void Kart_Tarih_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //11 sayı sınırı gelicek ve harf olmama sınırı
            string input = textBox2.Text;

            // Sadece rakamlardan oluşup oluşmadığını kontrol etmek için TryParse kullanılır
            long number;
            if (!long.TryParse(input, out number))
            {
                textBox2.BackColor = System.Drawing.Color.Red; // Geçersiz girişte TextBox arka planını kırmızı yap
            }
            else
            {
                // Sayının 11 haneli olup olmadığını kontrol et
                if (input.Length != 11)
                {
                    textBox2.BackColor = System.Drawing.Color.Yellow; // 11 haneli olmayan girişler için arka planı sarı yap
                }
                else
                {
                    textBox2.BackColor = System.Drawing.Color.White; // Geçerli girişler için arka planı beyaz yap
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // 3 sayı sınırı ve harf olmama
            string input2 = textBox3.Text;

            // Sadece rakamlardan oluşup oluşmadığını kontrol etmek için TryParse kullanılır
            long number;
            if (!long.TryParse(input2, out number))
            {
                textBox3.BackColor = System.Drawing.Color.Red; // Geçersiz girişte TextBox arka planını kırmızı yap
            }
            else
            {
                // Sayının 3 haneli olup olmadığını kontrol et
                if (input2.Length != 3)
                {
                    textBox3.BackColor = System.Drawing.Color.Yellow; // 11 haneli olmayan girişler için arka planı sarı yap
                }
                else
                {
                    textBox3.BackColor = System.Drawing.Color.White; // Geçerli girişler için arka planı beyaz yap
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void odeme_Click(object sender, EventArgs e)
        {
            //veritabanına bilgiler kaydolucak
            //mesajla işlem tamamlandı tutar: denilerek tutar yazacak

            // SQL sorgusu
            string sql = "INSERT INTO satis (ad, kart_numarasi, son_tarih) VALUES (@ad, @kart_numarasi, @son_tarih)";
            // Bağlantıyı al
            SqlConnection connection = baglanti.BaglantiyiAc();

            // SQL komutunu oluştur
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Parametreleri ata
                command.Parameters.AddWithValue("@ad", textBox1.Text);
                command.Parameters.AddWithValue("@kart_numarasi", textBox2.Text);
                command.Parameters.AddWithValue("@son_tarih", dateTimePicker1.Value);

                try
                {
                    // Komutu çalıştır
                    int rowsAffected = command.ExecuteNonQuery();

                    // Başarılı mesajı göster
                    MessageBox.Show("Ödeme başarıyla gerçekleştirildi. Bizi tercih ettiğiniz için teşekkür ederiz :)" );
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesajı göster
                    MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message);
                    this.Close();

                }
            }

            // Bağlantıyı kapat
            baglanti.BaglantiyiKapat(connection);
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            //onayla mesajı çıkacak ardından işlem sonlandırılacak iptal edildiğine dair mesaj verilecek ve form kapatılacak
            this.Close();

        }

        
       

        
    }
}
