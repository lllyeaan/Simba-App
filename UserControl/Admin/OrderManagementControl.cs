using System;
using System.Collections.Generic;
using System.Drawing;
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

            // Event handler utama
            this.Load += OrderManagementControl_Load;
            dgvPesanan.CellContentClick += dgvPesanan_CellContentClick;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            btnKembali.Click += btnKembali_Click;
            comboBoxTruk.SelectedIndexChanged += comboBoxTruk_SelectedIndexChanged;

            // Hover effect untuk tombol
            AddButtonHoverEffect(btnKonfirmasi, Color.FromArgb(65, 105, 225), Color.White);
            AddButtonHoverEffect(btnKembali, Color.FromArgb(232, 17, 35), Color.White);

            // DataGridView style biar lebih enak dilihat
            SetDataGridViewStyle(dgvPesanan);
        }

        private void OrderManagementControl_Load(object sender, EventArgs e)
        {
            LoadPesanan();
            LoadTruk();
            ClearFormOrderSelection();
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
                var result = MessageBox.Show(
                    "Anda yakin ingin mengkonfirmasi pengiriman ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                _orderService.KonfirmasiPengiriman(idOrderDipilih, truk.Id);
                MessageBox.Show("Pengiriman berhasil diproses.");
                LoadPesanan();
                LoadTruk();
                ClearFormOrderSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memproses pengiriman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Perubahan tidak akan disimpan. Anda yakin ingin kembali ke dashboard?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                mainForm.LoadUserControl(new AdminDashboardControl(mainForm));
            }
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPesanan.Rows[e.RowIndex];
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
                    MessageBox.Show("Pesanan ini sudah dalam proses atau selesai.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBoxTruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optionally show truck info detail (if you want)
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e) { }
        private void txtTanggal_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Utility: Efek hover untuk tombol
        /// </summary>
        private void AddButtonHoverEffect(Button btn, Color hoverBackColor, Color hoverForeColor)
        {
            var defaultBackColor = btn.BackColor;
            var defaultForeColor = btn.ForeColor;
            btn.MouseEnter += (s, e) => { btn.BackColor = hoverBackColor; btn.ForeColor = hoverForeColor; };
            btn.MouseLeave += (s, e) => { btn.BackColor = defaultBackColor; btn.ForeColor = defaultForeColor; };
        }

        /// <summary>
        /// Utility: Reset field konfirmasi pengiriman
        /// </summary>
        private void ClearFormOrderSelection()
        {
            idOrderDipilih = -1;
            txtCustomer.Text = "";
            txtTanggal.Text = "";
            if (comboBoxTruk.Items.Count > 0)
                comboBoxTruk.SelectedIndex = 0;
        }

        /// <summary>
        /// Utility: Style DataGridView agar lebih profesional
        /// </summary>
        private void SetDataGridViewStyle(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 105, 225);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Verdana", 10F);
            dgv.RowTemplate.Height = 32;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
