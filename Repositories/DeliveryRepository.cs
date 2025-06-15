using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialOrderingApp.Models;
using Npgsql;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            SELECT o.id_order, o.order_date, o.delivery_status, c.nama_customer,
                   t.no_polisi AS TruckNoPolisi, t.nama AS DriverName,
                   CASE 
                        WHEN o.delivery_status = 'Pending' THEN 'Belum Diproses'
                        WHEN o.delivery_status = 'Shipped' THEN 'Dikirim'
                        ELSE 'Tidak Diketahui'
                   END AS StatusLabel
            FROM orders o
            JOIN customer c ON o.id_customer = c.id_customer
            LEFT JOIN truck t ON o.id_truck = t.id_truck
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
                            CustomerName = reader["nama_customer"].ToString()!,
                            TruckNoPolisi = reader["TruckNoPolisi"]?.ToString() ?? "-",
                            DriverName = reader["DriverName"]?.ToString() ?? "-",
                        });
                    }
                }
            }
            return list;
        }


        public List<Order> GetByCustomer(int idCustomer)
        {
            List<Order> orders = new List<Order>();
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT
                    o.id_order,
                    o.order_date,
                    o.delivery_status,
                    o.total,
                    c.nama_customer,
                    c.alamat_jalan || ', ' || kec.nama_kecamatan || ', ' || kab.nama_kabupaten || ', ' || prov.nama_provinsi AS alamat
                FROM orders o
                JOIN customer c ON o.id_customer = c.id_customer
                JOIN kecamatan kec ON c.id_kecamatan = kec.id_kecamatan
                JOIN kabupaten kab ON kec.id_kabupaten = kab.id_kabupaten
                JOIN provinsi prov ON kab.id_provinsi = prov.id_provinsi
                WHERE o.id_customer = @id_customer
                ORDER BY o.order_date DESC";


                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_customer", idCustomer);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                IdOrder = reader.GetInt32(reader.GetOrdinal("id_order")),
                                //IdCustomer = reader.GetInt32(reader.GetOrdinal("id_customer")),
                                OrderDate = reader.GetDateTime(reader.GetOrdinal("order_date")),
                                DeliveryStatus = reader.GetString(reader.GetOrdinal("delivery_status")),
                                Total = reader.GetDecimal(reader.GetOrdinal("total")),
                                CustomerName = reader.GetString(reader.GetOrdinal("nama_customer")),
                                Alamat = reader.GetString(reader.GetOrdinal("alamat")),
                            };

                            orders.Add(order);
                        }
                    }
                }
            }
            return orders;
        }

        public void KonfirmasiPengiriman(int idOrder, int idTruck)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE orders 
            SET id_truck = @id_truck,
                delivery_status = 'Shipped'
            WHERE id_order = @id_order";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_order", idOrder);
                    cmd.Parameters.AddWithValue("@id_truck", idTruck);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void KonfirmasiSelesai(int idOrder)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE orders 
            SET delivery_status = 'Delivered'
            WHERE id_order = @id_order";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_order", idOrder);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

