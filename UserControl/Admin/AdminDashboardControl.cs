using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Utils;
using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.Admin
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly MainForm mainForm;

        public AdminDashboardControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));

            // Event handler tombol
            btnManajemenMaterial.Click += btnManajemenMaterial_Click;
            btnManajemenPesanan.Click += btnManajemenPesanan_Click;
            btnLogOut.Click += btnLogOut_Click;

            // Hover effect
            btnManajemenMaterial.MouseEnter += (s, e) => { btnManajemenMaterial.BackColor = Color.FromArgb(65, 105, 225); btnManajemenMaterial.ForeColor = Color.White; };
            btnManajemenMaterial.MouseLeave += (s, e) => { btnManajemenMaterial.BackColor = Color.White; btnManajemenMaterial.ForeColor = Color.Black; };

            btnManajemenPesanan.MouseEnter += (s, e) => { btnManajemenPesanan.BackColor = Color.FromArgb(65, 105, 225); btnManajemenPesanan.ForeColor = Color.White; };
            btnManajemenPesanan.MouseLeave += (s, e) => { btnManajemenPesanan.BackColor = Color.White; btnManajemenPesanan.ForeColor = Color.Black; };

            btnLogOut.MouseEnter += (s, e) => { btnLogOut.BackColor = Color.FromArgb(232, 17, 35); btnLogOut.ForeColor = Color.White; };
            btnLogOut.MouseLeave += (s, e) => { btnLogOut.BackColor = Color.White; btnLogOut.ForeColor = Color.Black; };

            // Load statistik ketika UserControl tampil
            this.Load += AdminDashboardControl_Load;
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            TampilkanStatistikDashboard();
        }

        private void TampilkanStatistikDashboard()
        {
            try
            {
                lblJumlahPesanan.Text = AmbilJumlahPesananBaru().ToString();
                lblJumlahTruk.Text = AmbilJumlahTrukTersedia().ToString();
                lblMaterialHabis.Text = AmbilJumlahMaterialHabis().ToString();
                lblTotalCustomer.Text = AmbilTotalCustomer().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat statistik: {ex.Message}\nSilakan cek koneksi database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"Error: {ex.ToString()}");
            }
        }

        private int AmbilJumlahPesananBaru()
        {
            using (NpgsqlConnection koneksi = DbConnectionHelper.GetConnection())
            {
                koneksi.Open();
                string query = "SELECT COUNT(*) FROM orders WHERE id_truck IS NULL";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, koneksi))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private int AmbilJumlahTrukTersedia()
        {
            using (NpgsqlConnection koneksi = DbConnectionHelper.GetConnection())
            {
                koneksi.Open();
                string query = @"
            SELECT COUNT(*) 
            FROM truck t
            WHERE NOT EXISTS (
                SELECT 1 
                FROM orders o
                WHERE o.id_truck = t.id_truck 
                  AND o.delivery_status IS DISTINCT FROM 'Delivered'
            )";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, koneksi))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        private int AmbilJumlahMaterialHabis()
        {
            using (NpgsqlConnection koneksi = DbConnectionHelper.GetConnection())
            {
                koneksi.Open();
                string query = "SELECT COUNT(*) FROM materials WHERE stock = 0";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, koneksi))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private int AmbilTotalCustomer()
        {
            using (NpgsqlConnection koneksi = DbConnectionHelper.GetConnection())
            {
                koneksi.Open();
                string query = "SELECT COUNT(*) FROM customer";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, koneksi))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        private void btnManajemenMaterial_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new MaterialManagementControl(mainForm));
        }

        private void btnManajemenPesanan_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new OrderManagementControl(mainForm));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.UserManager.ActiveUser = null;
                mainForm.LoadUserControl(new LoginControl(mainForm));
            }
        }
    }
}