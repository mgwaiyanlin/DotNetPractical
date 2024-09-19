using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DotNetPractical.WinFormsApp.Services
{
    public class DapperService
    {
        private readonly string _connectionString;

        public DapperService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<T> Query<T>(string query, object? param = null)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);

            var dataList = connection.Query<T>(query, param).ToList();
            return dataList;
        }

        public T QueryFirstOrDefault<T>(string query, object? param = null)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);

            var data = connection.Query<T>(query, param).FirstOrDefault();

            return data!;
        }

        public int Execute(string query, object? param = null)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);

            int result = connection.Execute(query, param);

            return result;
        }
    }
}
