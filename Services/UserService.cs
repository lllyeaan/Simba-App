using System;
using System.Windows.Forms;
using Npgsql;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;

namespace MaterialOrderingApp.Services
{
    public class UserService
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=DBSimbaNew";

        public void UpdateUser(User user)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string getIdQuery = "SELECT id_user FROM users WHERE username = @username";
                    int userId;

                    using (NpgsqlCommand getIdCmd = new NpgsqlCommand(getIdQuery, conn))
                    {
                        getIdCmd.Parameters.AddWithValue("username", user.Username);
                        object result = getIdCmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("User tidak ditemukan di tabel users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        userId = (int)result;
                    }

                    string checkCustomerQuery = "SELECT COUNT(*) FROM customer WHERE id_user = @id_user";
                    bool isCustomerExist;

                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkCustomerQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("id_user", userId);
                        long count = (long)checkCmd.ExecuteScalar();
                        isCustomerExist = count > 0;
                    }

                    if (isCustomerExist)
                    {
                        string updateCustomerQuery = @"
                            UPDATE customer
                            SET nama_customer = @full_name,
                                no_hp = @phone,
                                id_provinsi = @provinsi,
                                id_kabupaten = @kabupaten,
                                id_kecamatan = @kecamatan,
                                alamat_jalan = @jalan
                            WHERE id_user = @id_user";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(updateCustomerQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("full_name", user.FullName ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("phone", user.Phone ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("provinsi", user.Provinsi ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("kabupaten", user.Kabupaten ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("kecamatan", user.Kecamatan ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("jalan", user.Jalan ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("id_user", userId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = @"
                            INSERT INTO customer (id_user, nama_customer, no_hp, id_provinsi, id_kabupaten, id_kecamatan, alamat_jalan)
                            VALUES (@id_user, @full_name, @phone, @provinsi, @kabupaten, @kecamatan, @jalan)
                            RETURNING id_customer";

                        int newIdCustomer;

                        using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("id_user", userId);
                            cmd.Parameters.AddWithValue("full_name", user.FullName ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("phone", user.Phone ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("provinsi", user.Provinsi ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("kabupaten", user.Kabupaten ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("kecamatan", user.Kecamatan ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("jalan", user.Jalan ?? (object)DBNull.Value);
                            //cmd.ExecuteNonQuery();
                            newIdCustomer = (int)cmd.ExecuteScalar();
                        }

                        string updateUserQuery = "UPDATE users SET id_customer = @id_customer WHERE id_user = @id_user";
                        using (NpgsqlCommand updateCmd = new NpgsqlCommand(updateUserQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("id_customer", newIdCustomer);
                            updateCmd.Parameters.AddWithValue("id_user", userId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Gagal menyimpan ke database: " + ex.Message,
                                "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertCustomerFromProfile(User user, string idKecamatan, string alamatJalan)
        {

            string koneksi = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=DBSimbaNew;";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(koneksi))
                {
                    conn.Open();

                    string query = @"
                INSERT INTO customer (id_user, nama_customer, no_hp, alamat_jalan, id_kecamatan, id_kabupaten, id_provinsi, alamat_deskripsi)
                VALUES (@id_user, @nama_customer, @no_hp, @alamat_jalan, @id_kecamatan,
                    (SELECT id_kabupaten FROM kecamatan WHERE id_kecamatan = @id_kecamatan),
                    (SELECT id_provinsi FROM kecamatan JOIN kabupaten ON kecamatan.id_kabupaten = kabupaten.id_kabupaten WHERE kecamatan.id_kecamatan = @id_kecamatan),
                    @alamat_jalan)
                RETURNING id_customer;
            ";
                    int newIdCustomer;
  
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        //Console.WriteLine("DEBUG: id_user = " + user.Id);
                        //Console.WriteLine("DEBUG: nama_customer = " + user.FullName);
                        //Console.WriteLine("DEBUG: no_hp = " + user.Phone);
                        //Console.WriteLine("DEBUG: alamat_jalan = " + alamatJalan);
                        //Console.WriteLine("DEBUG: id_kecamatan = " + idKecamatan);


                        cmd.Parameters.AddWithValue("id_user", user.Id);
                        cmd.Parameters.AddWithValue("nama_customer", user.FullName);
                        cmd.Parameters.AddWithValue("no_hp", user.Phone);
                        cmd.Parameters.AddWithValue("alamat_jalan", alamatJalan);
                        cmd.Parameters.AddWithValue("id_kecamatan", idKecamatan);

                        newIdCustomer = (int)cmd.ExecuteScalar();

                        //cmd.ExecuteNonQuery();
                    }

                    string updateUserQuery = "UPDATE users SET id_customer = @id_customer WHERE id_user = @id_user";

                    using (NpgsqlCommand updateCmd = new NpgsqlCommand(updateUserQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("id_customer", newIdCustomer);
                        updateCmd.Parameters.AddWithValue("id_user", user.Id);
                        updateCmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data customer: " + ex.Message,
                                "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}


