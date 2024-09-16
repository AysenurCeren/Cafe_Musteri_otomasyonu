
using System;
using System.Data.SqlClient;

namespace ac
{
    public class Baglanti
    {
        private string connectionString;

        public Baglanti(string server, string database, string username, string password)
        {
            // Bağlantı dizesini oluştur
            connectionString = $"Data Source=SANIZ\\SQLEXPRESS;Initial Catalog=Cafe3;Integrated Security=True;";//Trust Server Certificate=True":
        }

        public SqlConnection BaglantiyiAc()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void BaglantiyiKapat(SqlConnection connection)
        {
            connection.Close();
        }

        public int SorguyuCalistir(string query)
        {
            int affectedRows = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            return affectedRows;
        }
    }
}