
using System.Data.SqlClient;

namespace DotNetPractical.WinFormsApp
{
    public class ConnectionsString
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
