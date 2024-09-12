using System.Data.SqlClient;

namespace DotNetPractical.RestAPI
{
    public class ConnectionStrings
    {
        public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "localhost",
            InitialCatalog = "DotNetPractical",
            UserID = "myserver",
            Password = "password",
            TrustServerCertificate = true,
        };
    }
}

