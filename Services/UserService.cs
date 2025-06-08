using System;
using Npgsql;
using MaterialOrderingApp.Models;

namespace MaterialOrderingApp.Services
{
    public class UserService
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Nadin.15;Database=dump-DBSimbaNew-202506022112";

        public void UpdateUser(User user)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE users 
                    SET fullname = @fullname, phone = @phone, provinsi = @provinsi, 
                        kabupaten = @kabupaten, kecamatan = @kecamatan, jalan = @jalan
                    WHERE username = @username;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("fullname", user.FullName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("phone", user.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("provinsi", user.Provinsi ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("kabupaten", user.Kabupaten ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("kecamatan", user.Kecamatan ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("jalan", user.Jalan ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("username", user.Username);

                    //cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
