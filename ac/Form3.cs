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

    public partial class Form3 : Form
    {
        Baglanti baglanti;

        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {


            string username = kullanici.Text;
            string password = sifre.Text;

            // Kullanıcı adı ve şifre kontrolü
            string query = "SELECT COUNT(*) FROM üyeler WHERE kullanici = @kullanici AND sifre = @sifre";
            SqlConnection connection = baglanti.BaglantiyiAc();

            try
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullanici", username);
                command.Parameters.AddWithValue("@sifre", password);

                int result = (int)command.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Giriş başarılı!");
                    Form5 form5 = new Form5();

                    form5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.BaglantiyiKapat(connection);
            }

        }
    }
}
