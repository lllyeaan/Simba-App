using System;
using System.Windows.Forms;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Models;

namespace MaterialOrderingApp.Forms.Admin
{
    public partial class MaterialManagementControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;
        private readonly MaterialService _materialService;
        private int idMaterialTerpilih = -1;

        public MaterialManagementControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _authService = new AuthService(new UserRepository());
            _materialService = new MaterialService(new MaterialRepository());

            dgvMaterial.CellClick += dgvMaterial_CellClick;
            dgvMaterial.AutoGenerateColumns = true;

            LoadMaterial();
        }

        private void LoadMaterial()
        {
            dgvMaterial.DataSource = _materialService.AmbilSemua();
            dgvMaterial.ClearSelection();
            idMaterialTerpilih = -1;
        }

        private void ClearForm()
        {
            txtNamaMaterial.Clear();
            txtHarga.Clear();
            txtStock.Clear();
            txtSatuan.Clear();
            chkTersedia.Checked = false;
            idMaterialTerpilih = -1;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new AdminDashboardControl(mainForm));
        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaterial.Rows[e.RowIndex];

                try
                {
                    idMaterialTerpilih = Convert.ToInt32(row.Cells["Id"].Value);
                    txtNamaMaterial.Text = row.Cells["MaterialName"].Value?.ToString() ?? "";
                    txtHarga.Text = row.Cells["UnitPrice"].Value?.ToString() ?? "";
                    txtStock.Text = row.Cells["Stock"].Value?.ToString() ?? "";
                    txtSatuan.Text = row.Cells["Satuan"].Value?.ToString() ?? "";
                    chkTersedia.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membaca data: " + ex.Message);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaMaterial.Text) ||
                !int.TryParse(txtHarga.Text, out int harga) ||
                !int.TryParse(txtStock.Text, out int stock) ||
                string.IsNullOrWhiteSpace(txtSatuan.Text))
            {
                MessageBox.Show("Lengkapi semua input dan pastikan angka valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Material material = new Material
            {
                MaterialName = txtNamaMaterial.Text.Trim(),
                UnitPrice = harga,
                Stock = stock,
                Satuan = txtSatuan.Text.Trim(),
                IsAvailable = chkTersedia.Checked
            };

            _materialService.TambahMaterial(material);
            MessageBox.Show("Material berhasil ditambahkan!");
            LoadMaterial();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idMaterialTerpilih == -1)
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaMaterial.Text) ||
                !int.TryParse(txtHarga.Text, out int harga) ||
                !int.TryParse(txtStock.Text, out int stock) ||
                string.IsNullOrWhiteSpace(txtSatuan.Text))
            {
                MessageBox.Show("Lengkapi semua input dan pastikan angka valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Material material = new Material
            {
                Id = idMaterialTerpilih,
                MaterialName = txtNamaMaterial.Text.Trim(),
                UnitPrice = harga,
                Stock = stock,
                Satuan = txtSatuan.Text.Trim(),
                IsAvailable = chkTersedia.Checked
            };

            _materialService.Update(material);
            MessageBox.Show("Data berhasil diperbarui!");
            LoadMaterial();
            ClearForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idMaterialTerpilih == -1)
            {
                MessageBox.Show("Pilih data terlebih dahulu untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == DialogResult.Yes)
            {
                _materialService.Delete(idMaterialTerpilih);
                MessageBox.Show("Data berhasil dihapus.");
                LoadMaterial();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtNamaMaterial_TextChanged(object sender, EventArgs e) { }

        private void txtHarga_TextChanged(object sender, EventArgs e) { }

        private void txtStock_TextChanged(object sender, EventArgs e) { }

        private void txtSatuan_TextChanged(object sender, EventArgs e) { }

        private void chkTersedia_CheckedChanged(object sender, EventArgs e) { }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
