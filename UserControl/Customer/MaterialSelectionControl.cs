using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MaterialOrderingApp.Forms.Customer
{
    public partial class MaterialSelectionControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;
        private readonly MaterialService _materialService;
        private readonly TransactionService _transactionService;
        private readonly MaterialDipilih _materialDipilih;
        private int idMaterialTerpilih = -1;
        public MaterialSelectionControl(MainForm form)
        {
            try
            {
                InitializeComponent();
                this.mainForm = form;
                _authService = new AuthService(new UserRepository());
                _materialService = new MaterialService(new MaterialRepository());
                _transactionService = new TransactionService(new TransactionRepository());

                dgvMaterialSelection.CellContentClick += dgvMaterialSelection_CellContentClick;
                dgvMaterialSelection.AutoGenerateColumns = true;

                LoadMaterialSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat kontrol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaterialSelection()
        {
            try
            {
                dgvMaterialSelection.DataSource = _materialService.AmbilSemua();
                dgvMaterialSelection.Columns["Stock"].Visible = false;
                dgvMaterialSelection.ClearSelection();
                idMaterialTerpilih = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data material: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaterialSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {

            if (idMaterialTerpilih == -1)
            {
                MessageBox.Show("Silakan pilih material terlebih dahulu.");
                return;
            }

            if (!int.TryParse(txtJumlah.Text, out int jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus angka positif");
                return;
            }

            MaterialDipilih ringkasan = new MaterialDipilih
            {
                Id = idMaterialTerpilih,
                MaterialName = txtNamaMaterial.Text.Trim(),
                UnitPrice = decimal.Parse(txtHarga.Text.Trim()),
                Satuan = txtSatuan.Text.Trim(),
                Jumlah = jumlah
                
            };

            TansactionControl ringkasanControl = new TansactionControl(mainForm, ringkasan, _transactionService);
            mainForm.LoadUserControl(ringkasanControl);

        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));

        }
        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaMaterial_Click(object sender, EventArgs e)
        {

        }

        private void lblStok_Click(object sender, EventArgs e)
        {

        }

        private void lblSatuan_Click(object sender, EventArgs e)
        {

        }

        private void txtNamaMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSatuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPemesanan_Click(object sender, EventArgs e)
        {

        }


        private void lblJumlah_Click(object sender, EventArgs e)
        {

        }


        private void btnPesan_Click(object sender, EventArgs e)
        {

        }


        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStok_Click_1(object sender, EventArgs e)
        {

        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
