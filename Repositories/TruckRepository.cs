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
                    SELECT t.id_truck, t.no_polisi, t.id_driver, d.nama AS driver_name
                    FROM truck t
                    JOIN driver d ON t.id_driver = d.id_driver";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Truck
                        {
                            Id = Convert.ToInt32(reader["id_truck"]),
                            NoPolisi = reader["no_polisi"].ToString()!,
                            IdDriver = Convert.ToInt32(reader["id_driver"]),
                            DriverName = reader["driver_name"].ToString()!
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
                    SELECT t.id_truck, t.no_polisi, t.id_driver, d.nama AS driver_name
                    FROM truck t
                    JOIN driver d ON t.id_driver = d.id_driver
                    WHERE t.id_truck NOT IN (
                        SELECT id_truck FROM orders WHERE delivery_status != 'Selesai'
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
                            IdDriver = Convert.ToInt32(reader["id_driver"]),
                            DriverName = reader["driver_name"].ToString()!
                        });
                    }
                }
            }

            return list;
        }
    }
}
