using System;
using System.Configuration;
using Npgsql;

namespace MaterialOrderingApp.Repositories
{
    public class DbConnectionHelper
    {
        private static string _connectionString = null!;

        static DbConnectionHelper()
        {
            try
            {
                ConnectionStringSettings connectionStringSettings= ConfigurationManager.ConnectionStrings["DbConnection"];
                if (connectionStringSettings == null)
                {
                    Console.WriteLine("Connection string 'DbConnection' not found in App.config.");
                    throw new InvalidOperationException("Connection string 'DbConnection' not found in App.config.");
                }
                _connectionString = connectionStringSettings.ConnectionString;
                Console.WriteLine($"Connection string loaded: {_connectionString}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading connection string: {ex.Message}");
                throw new InvalidOperationException("Database connection string not found in App.config.", ex);
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Database connection string is not initialized. Check App.config and application references.");
            }
            return new NpgsqlConnection(_connectionString);
        }

        public static string GetConnectionString()
        {
            return _connectionString;
        }

        public static bool TestConnection()
        {
            try
            {
                using (NpgsqlConnection conn = GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("Database connection successful!");
                    return true;
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Database connection failed: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }
    }
}