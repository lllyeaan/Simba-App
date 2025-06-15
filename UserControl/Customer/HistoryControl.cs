using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.Customer
{
    public partial class HistoryControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly OrderService _orderService;

        public HistoryControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _orderService = new OrderService(new DeliveryRepository());

            // Hover effect untuk button kembali (biar konsisten sama tombol lain)
            btnkembali.MouseEnter += (s, e) => btnkembali.BackColor = Color.FromArgb(232, 17, 35);
            btnkembali.MouseLeave += (s, e) => btnkembali.BackColor = Color.White;

            // Style DataGridView
            SetupDataGridViewStyle();

            LoadHistoryControl(mainForm);
        }

        private void LoadHistoryControl(MainForm mainForm)
        {
            try
            {
                int? idCustomerNullable = mainForm.CurrentUser?.IdCustomer;
                if (idCustomerNullable == null)
                {
                    MessageBox.Show("ID Customer tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idCustomer = idCustomerNullable.Value;
                var data = _orderService.AmbilPesananByCustomer(idCustomer);

                dgvhistory.DataSource = null;
                dgvhistory.DataSource = data;
                dgvhistory.ClearSelection();

                // Sembunyikan kolom internal kalau ada
                if (dgvhistory.Columns.Contains("CustomerName"))
                    dgvhistory.Columns["CustomerName"].Visible = false;

                if (data == null || data.Count == 0)
                {
                    // Buat label info jika kosong
                    Label lblKosong = new Label()
                    {
                        Text = "Belum ada riwayat transaksi.",
                        ForeColor = Color.White,
                        Font = new Font("Verdana", 16, FontStyle.Bold),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.Transparent
                    };
                    dgvhistory.Controls.Add(lblKosong);
                    lblKosong.BringToFront();
                }
                else
                {
                    // Hapus label info jika ada data
                    foreach (Control c in dgvhistory.Controls)
                    {
                        if (c is Label && c.Text.Contains("riwayat"))
                        {
                            dgvhistory.Controls.Remove(c);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data riwayat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridViewStyle()
        {
            dgvhistory.EnableHeadersVisualStyles = false;
            dgvhistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 105, 225);
            dgvhistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvhistory.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Bold);

            dgvhistory.DefaultCellStyle.Font = new Font("Verdana", 11);
            dgvhistory.DefaultCellStyle.BackColor = Color.White;
            dgvhistory.DefaultCellStyle.ForeColor = Color.Black;
            dgvhistory.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvhistory.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvhistory.RowHeadersVisible = false;
            dgvhistory.AllowUserToAddRows = false;
            dgvhistory.AllowUserToDeleteRows = false;
            dgvhistory.ReadOnly = true;
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));
        }

        // Event kosong (jika tidak digunakan bisa dihapus)
        private void dgvhistory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblhistory_Click(object sender, EventArgs e) { }
        private void lblhistory2_Click(object sender, EventArgs e) { }
    }
}
