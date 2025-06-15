using MaterialOrderingApp.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MaterialOrderingApp.Repositories
{
    public class TruckRepository
    {
        public List<Truck> GetAllTrucksWithDriver()
        {
            List<Truck> list = new List<Truck>();

            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT id_truck, no_polisi, nama AS driver_name, no_hp
                    FROM truck";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Truck
                        {
                            Id = Convert.ToInt32(reader["id_truck"]),
                            NoPolisi = reader["no_polisi"].ToString()!,
                            DriverName = reader["driver_name"].ToString()!,
                            NoHP = reader["no_hp"].ToString()!
                        });
                    }
                }
            }

            return list;
        }

        public List<Truck> GetTrukTersedia()
        {
            List<Truck> list = new List<Truck>();

            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT t.id_truck, t.no_polisi, t.nama AS driver_name, t.no_hp
            FROM truck t
            WHERE NOT EXISTS (
                SELECT 1 
                FROM orders o
                WHERE o.id_truck = t.id_truck 
                  AND o.delivery_status IS DISTINCT FROM 'Delivered'
            )";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Truck
                        {
                            Id = Convert.ToInt32(reader["id_truck"]),
                            NoPolisi = reader["no_polisi"].ToString()!,
                            DriverName = reader["driver_name"].ToString()!,
                            NoHP = reader["no_hp"].ToString()!
                        });
                    }
                }
            }

            return list;
        }
    }
}
