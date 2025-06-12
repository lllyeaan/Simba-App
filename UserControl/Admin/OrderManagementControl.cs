using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;

namespace MaterialOrderingApp.Forms.Admin
{
    public partial class OrderManagementControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly OrderService _orderService;
        private readonly TruckService _truckService;
        private List<Truck> daftarTruk = new();
        private int idOrderDipilih = -1;

        public OrderManagementControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));

            _orderService = new OrderService(new DeliveryRepository());
            _truckService = new TruckService(new TruckRepository());

            this.Load += OrderManagementControl_Load;
            dgvPesanan.CellContentClick += dgvPesanan_CellContentClick;
        }

        private void OrderManagementControl_Load(object sender, EventArgs e)
        {
            LoadPesanan();
            LoadTruk();
        }

        private void LoadPesanan()
        {
            try
            {
                dgvPesanan.DataSource = _orderService.AmbilSemuaPesanan();
                dgvPesanan.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data pesanan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTruk()
        {
            try
            {
                daftarTruk = _truckService.GetTersedia();
                comboBoxTruk.DataSource = null;
                comboBoxTruk.DataSource = daftarTruk;

                comboBoxTruk.DisplayMember = "Display";
                comboBoxTruk.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data truk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (idOrderDipilih == -1 || comboBoxTruk.SelectedItem == null)
            {
                MessageBox.Show("Pilih truk dan data pesanan terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTruk.SelectedItem is not Truck truk)
            {
                MessageBox.Show("Truk tidak valid.");
                return;
            }

            try
            {
                _orderService.KonfirmasiPengiriman(idOrderDipilih, truk.Id, truk.IdDriver);
                MessageBox.Show("Pengiriman berhasil diproses.");
                LoadPesanan();
                idOrderDipilih = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses pengiriman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new AdminDashboardControl(mainForm));
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e) { }
        private void txtTanggal_TextChanged(object sender, EventArgs e) { }
        private void comboBoxTruk_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPesanan.Rows[e.RowIndex];
                string status = row.Cells["DeliveryStatus"].Value?.ToString();

                if (status == "Pending")
                {
                    idOrderDipilih = Convert.ToInt32(row.Cells["IdOrder"].Value);
                    txtCustomer.Text = row.Cells["CustomerName"].Value?.ToString();
                    txtTanggal.Text = DateTime.TryParse(row.Cells["OrderDate"].Value?.ToString(), out DateTime tanggal)
                        ? tanggal.ToString("yyyy-MM-dd")
                        : string.Empty;
                }
                else
                {
                    MessageBox.Show("Pesanan ini sudah dalam proses atau selesai.");
                }
            }
        }
    }
}
