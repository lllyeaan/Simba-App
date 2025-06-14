using MaterialOrderingApp.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Repositories
{
    public class TransactionRepository
    {
        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> list = new List<Transaction>();
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT o.id_order, o.id_material, o.quantity, o.total, 
                           m.material_name, m.unit_price
                    FROM orders o
                    JOIN materials m ON o.id_material = m.id_material
                    ORDER BY o.id_order DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            IdOrder = Convert.ToInt32(reader["id_order"]),
                            IdMaterial = Convert.ToInt32(reader["id_material"]),
                            quantity = Convert.ToInt32(reader["quantity"]),
                            subtotal = Convert.ToInt32(reader["subtotal"]),
                        });
                    }
                }
            }
            return list;
        }
        public void Insert(Transaction transaction)
        {
            using (NpgsqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO orders
                                 (id_customer, id_material,unit_price, quantity, total, payment_method, payment_status)
                                 VALUES (@customer, @material, @unitprice, @quantity, @total, @payment, @status)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@material", transaction.IdMaterial);
                    cmd.Parameters.AddWithValue("@quantity", transaction.quantity);
                    cmd.Parameters.AddWithValue("@total", transaction.subtotal);
                    cmd.Parameters.AddWithValue("@customer", transaction.IdCustomer);
                    cmd.Parameters.AddWithValue("@payment", transaction.paymentmethod);
                    cmd.Parameters.AddWithValue("@status", "Pending");
                    cmd.Parameters.AddWithValue("@unitprice", transaction.IdMaterial);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
