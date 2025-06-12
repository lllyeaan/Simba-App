using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Utils;
using System;
using System.Windows.Forms;
using Npgsql;
using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Services;

namespace MaterialOrderingApp.Forms.Admin
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;

        public AdminDashboardControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _authService = new AuthService(new UserRepository());

            // Penting: aktifkan event Load
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
                MessageBox.Show($"Gagal memuat statistik: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SELECT COUNT(*) FROM truck 
                    WHERE id_truck NOT IN (
                        SELECT id_truck FROM orders WHERE delivery_status != 'Selesai'
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
            if (mainForm == null)
            {
                MessageBox.Show("Main form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mainForm.LoadUserControl(new MaterialManagementControl(mainForm));
        }

        private void btnManajemenPesanan_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("Main form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mainForm.LoadUserControl(new OrderManagementControl(mainForm));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("Main form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Utils.UserManager.ActiveUser = null;
            mainForm.LoadUserControl(new LoginControl(mainForm));
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }

        private void lblJumlahPesanan_Click(object sender, EventArgs e) { }

        private void lblJumlahTruk_Click(object sender, EventArgs e) { }

        private void lblMaterialHabis_Click(object sender, EventArgs e) { }

        private void lblTotalCustomer_Click(object sender, EventArgs e) { }
    }
}
