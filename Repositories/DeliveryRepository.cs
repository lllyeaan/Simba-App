using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MaterialOrderingApp.Models;
using Npgsql;

namespace MaterialOrderingApp.Repositories
{
    public class DeliveryRepository
    {
        public List<Delivery> GetAllDeliveries()
        {
            List<Delivery> list = new List<Delivery>();
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT o.id_order, o.order_date, o.delivery_status, 
                           c.nama_customer
                    FROM orders o
                    JOIN customer c ON o.id_customer = c.id_customer
                    ORDER BY o.id_order DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Delivery
                        {
                            IdOrder = Convert.ToInt32(reader["id_order"]),
                            OrderDate = Convert.ToDateTime(reader["order_date"]),
                            DeliveryStatus = reader["delivery_status"].ToString()!,
                            CustomerName = reader["nama_customer"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public List<Order> GetByCustomer(int idCustomer)
        {
            var list = new List<Order>();
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT o.id_order, o.order_date, o.delivery_status, c.nama_customer 
            FROM orders o
            JOIN customer c ON o.id_customer = c.id_customer
            WHERE o.id_customer = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCustomer);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Order
                            {
                                IdOrder = Convert.ToInt32(reader["id_order"]),
                                OrderDate = Convert.ToDateTime(reader["order_date"]),
                                DeliveryStatus = reader["delivery_status"].ToString(),
                                CustomerName = reader["nama_customer"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void KonfirmasiPengiriman(int idOrder, int idTruck, int idDriver)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    UPDATE orders 
                    SET id_truck = @id_truck,
                        id_driver = @id_driver,
                        delivery_status = 'Dikirim'
                    WHERE id_order = @id_order";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_order", idOrder);
                    cmd.Parameters.AddWithValue("@id_truck", idTruck);
                    cmd.Parameters.AddWithValue("@id_driver", idDriver);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

