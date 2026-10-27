using System;
using System.Data.SqlClient;

namespace SOHATS
{
    public static class DBHelper
    {
        // Bağlantı dizesini kendi sunucu ayarlarınıza göre düzenleyin.
        // Integrated Security=True; Windows Authentication kullanır.
        private static string connectionString = "Server=.;Database=SOHATS;Integrated Security=True;";

        /// <summary>
        /// Veritabanı bağlantı nesnesini döndürür.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
