using System;
using Npgsql;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Utils;
using System.Data;
using System.Diagnostics;

namespace MaterialOrderingApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByUsername(string username)
        {

            User user = null;
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT u.id_user, u.username, u.password, u.role, u.created_at,
                           c.id_customer, c.no_hp, p.nama_provinsi, k.nama_kabupaten, kc.nama_kecamatan, c.alamat_jalan
                    FROM public.users u
                    LEFT JOIN public.customer c ON u.id_user = c.id_user
                    LEFT JOIN public.provinsi p ON c.id_provinsi = p.id_provinsi
                    LEFT JOIN public.kabupaten k ON c.id_kabupaten = k.id_kabupaten
                    LEFT JOIN public.kecamatan kc ON c.id_kecamatan = kc.id_kecamatan
                    WHERE u.username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader.GetString(reader.GetOrdinal("role"));
                            if (role == "admin")
                                user = new AdminUser();
                            else
                                user = new CustomerUser();
                            
                                user.Id = reader.GetInt32(reader.GetOrdinal("id_user"));
                                user.Username = reader.GetString(reader.GetOrdinal("username"));
                                user.Password = reader.GetString(reader.GetOrdinal("password"));
                            user.Role = reader.GetString(reader.GetOrdinal("role"));
                            user.CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at"));
                            user.IdCustomer = reader.IsDBNull(reader.GetOrdinal("id_customer"))
                                     ? 0
                                     : reader.GetInt32(reader.GetOrdinal("id_customer"));
                        }
                    }
                }
            }
            return user;
        }

        public bool IsUsernameTaken(string username)
        {
            return GetUserByUsername(username) != null;
        }

        public User CreateUser(string username, string password, string role, Customer customer = null)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string userQuery = @"
                            INSERT INTO public.users (username, password, role, created_at)
                            VALUES (@username, @password, @role, @created_at)
                            RETURNING id_user";

                        int userId;
                        using (NpgsqlCommand cmd = new NpgsqlCommand(userQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("password", password);
                            cmd.Parameters.AddWithValue("role", role);
                            cmd.Parameters.AddWithValue("created_at", DateTime.Now);
                            userId = (int)cmd.ExecuteScalar();
                        }
                        if (customer != null)
                        {
                            string customerQuery = @"
                                INSERT INTO public.customer 
                                    (id_user, nama_customer, no_hp, alamat_jalan, id_desa, id_kecamatan, id_kabupaten, id_provinsi, alamat_deskripsi)
                                VALUES 
                                    (@id_user, @nama_customer, @no_hp, @alamat_jalan, @id_desa, @id_kecamatan, @id_kabupaten, @id_provinsi, @alamat_deskripsi)";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(customerQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("id_user", userId);
                                cmd.Parameters.AddWithValue("nama_customer", (object)customer.FullName ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("no_hp", (object)customer.Phone ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("alamat_jalan", (object)customer.Jalan ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("id_desa", (object)customer.IdDesa ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("id_kecamatan", (object)customer.Kecamatan ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("id_kabupaten", (object)customer.Kabupaten ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("id_provinsi", (object)customer.Provinsi ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("alamat_deskripsi", (object)customer.AlamatDeskripsi ?? DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        return GetUserByUsername(username);
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
