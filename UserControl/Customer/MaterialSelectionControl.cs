using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.Customer
{
    public partial class MaterialSelectionControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;
        private readonly MaterialService _materialService;
        private readonly TransactionService _transactionService;
        private int idMaterialTerpilih = -1;

        public MaterialSelectionControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _authService = new AuthService(new UserRepository());
            _materialService = new MaterialService(new MaterialRepository());
            _transactionService = new TransactionService(new TransactionRepository());

            // Button event dan hover style
            btnKembali.Click += btnKembali_Click;
            btnPesan.Click += btnPesan_Click;

            btnPesan.MouseEnter += (s, e) => btnPesan.BackColor = Color.FromArgb(65, 105, 225);
            btnPesan.MouseLeave += (s, e) => btnPesan.BackColor = Color.White;
            btnKembali.MouseEnter += (s, e) => btnKembali.BackColor = Color.Gray;
            btnKembali.MouseLeave += (s, e) => btnKembali.BackColor = Color.White;

            dgvMaterialSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialSelection.CellClick += dgvMaterialSelection_CellClick;
            dgvMaterialSelection.AutoGenerateColumns = true;

            LoadMaterialSelection();
        }

        private void LoadMaterialSelection()
        {
            try
            {
                dgvMaterialSelection.DataSource = _materialService.AmbilSemua();
                if (dgvMaterialSelection.Columns.Contains("Stock"))
                    dgvMaterialSelection.Columns["Stock"].Visible = false;
                dgvMaterialSelection.ClearSelection();
                idMaterialTerpilih = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data material: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaterialSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaterialSelection.Rows[e.RowIndex];
                try
                {
                    idMaterialTerpilih = Convert.ToInt32(row.Cells["Id"].Value);
                    txtNamaMaterial.Text = row.Cells["MaterialName"].Value?.ToString() ?? "";
                    txtHarga.Text = row.Cells["UnitPrice"].Value?.ToString() ?? "";
                    txtSatuan.Text = row.Cells["Satuan"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membaca data: " + ex.Message);
                }
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            var currentUser = mainForm.CurrentUser;
            if (currentUser == null)
            {
                MessageBox.Show("Pengguna tidak ditemukan");
                return;
            }

            if (idMaterialTerpilih == -1)
            {
                MessageBox.Show("Silakan pilih material terlebih dahulu.");
                return;
            }

            var selectedMaterial = new MaterialDipilih
            {
                Id = idMaterialTerpilih,
                MaterialName = txtNamaMaterial.Text.Trim(),
                UnitPrice = decimal.Parse(txtHarga.Text.Trim()),
                Satuan = txtSatuan.Text.Trim(),
            };

            var transactionControl = new TansactionControl(mainForm, selectedMaterial, _transactionService, currentUser);
            mainForm.LoadUserControl(transactionControl);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));
        }
    }
}
