using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ac
{
    public partial class Form2 : Form
    {
        Baglanti baglanti;

        public Form2()
        {
            InitializeComponent();
            // Bağlantı oluşturucuyu başlat
            baglanti = new Baglanti("SANIZ\\SQLEXPRESS", "Cafe3", "", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi al

            string username = kullanici.Text;
            string password = sifre.Text;

            // Örnek olarak, kullanıcı bilgilerini bir veritabanına kaydetmek için bir INSERT INTO sorgusu oluştur
            string query = $"INSERT INTO üyeler (kullanici, sifre) VALUES ('{username}', '{password}')";


            // Bağlantıyı aç
            SqlConnection connection = baglanti.BaglantiyiAc();
            try
            {
                // Sorguyu çalıştır
                int affectedRows = baglanti.SorguyuCalistir(query);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kayıt başarıyla tamamlandı.");
                    Form3 form3 = new Form3();

                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                string hataMesaji = ex.Message;
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu: " + hataMesaji);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.BaglantiyiKapat(connection);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Form3'yi göster
            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
