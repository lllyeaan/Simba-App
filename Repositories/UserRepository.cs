using System;
using Npgsql;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Utils;

namespace MaterialOrderingApp.Repositories
{
    public class UserRepository
    {
        public User GetUserByUsername(string username)
        {
            User user = null;
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Username = reader.GetString(reader.GetOrdinal("username")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                Role = reader.GetString(reader.GetOrdinal("role")),
                                FullName = reader.GetString(reader.GetOrdinal("nama_customer")),
                                Phone = reader.GetString(reader.GetOrdinal("no_hp")),
                                Provinsi = reader.GetString(reader.GetOrdinal("provinsi")),
                                Kabupaten = reader.GetString(reader.GetOrdinal("kabupaten")),
                                Kecamatan = reader.GetString(reader.GetOrdinal("kecamatan")),
                                Jalan = reader.GetString(reader.GetOrdinal("jalan"))
                            };
                        }
                    }
                }
            }
            return user;
        }
    }
}