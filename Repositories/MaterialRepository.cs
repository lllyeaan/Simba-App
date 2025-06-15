using MaterialOrderingApp.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Repositories
{
    public class MaterialRepository
    {
        public List<Material> GetAll()
        {
            List<Material> list = new List<Material>();
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM materials ORDER BY id_material ASC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Material
                        {
                            Id = Convert.ToInt32(reader["id_material"]),
                            MaterialName = reader["material_name"].ToString()!,
                            UnitPrice = Convert.ToInt32(reader["unit_price"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Satuan = reader["satuan"].ToString()!,
                            IsAvailable = Convert.ToBoolean(reader["is_available"])
                        });
                    }
                }
            }
            return list;
        }

        public void Insert(Material material)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO materials
                                 (material_name, unit_price, stock, satuan, is_available) 
                                 VALUES (@name, @price, @stock, @satuan, @avail)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", material.MaterialName);
                    cmd.Parameters.AddWithValue("@price", material.UnitPrice);
                    cmd.Parameters.AddWithValue("@stock", material.Stock);
                    cmd.Parameters.AddWithValue("@satuan", material.Satuan);
                    cmd.Parameters.AddWithValue("@avail", material.IsAvailable);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Material material)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE materials
                                 SET material_name=@name, unit_price=@price, stock=@stock, 
                                     satuan=@satuan, is_available=@avail 
                                 WHERE id_material=@id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", material.MaterialName);
                    cmd.Parameters.AddWithValue("@price", material.UnitPrice);
                    cmd.Parameters.AddWithValue("@stock", material.Stock);
                    cmd.Parameters.AddWithValue("@satuan", material.Satuan);
                    cmd.Parameters.AddWithValue("@avail", material.IsAvailable);
                    cmd.Parameters.AddWithValue("@id", material.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM materials WHERE id_material = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
