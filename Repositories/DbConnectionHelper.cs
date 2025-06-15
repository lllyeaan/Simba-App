using System;
using System.Configuration;
using Npgsql;

namespace MaterialOrderingApp.Repositories
{
    public static class DbConnectionHelper
    {
        private static readonly string? _connectionString;

        static DbConnectionHelper()
        {
            _connectionString = Environment.GetEnvironmentVariable("MATERIALORDERING_DB")
                ?? ConfigurationManager.ConnectionStrings["DbConnection"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                Console.Error.WriteLine("Database connection string is missing. Please check environment variables or App.config!");
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
                throw new InvalidOperationException("Database connection string is not initialized. Check App.config or environment variable.");

            return new NpgsqlConnection(_connectionString);
        }

        public static string GetConnectionString() => _connectionString ?? "";

        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = "";
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                        return true;

                    errorMessage = "Connection state is not open.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"Database connection failed: {ex.Message}";
                Console.Error.WriteLine(errorMessage);
                return false;
            }
        }
    }
}
