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
        private int idMaterialTerpilih = -1;
        public MaterialSelectionControl(MainForm form)
        {
            try
            {
                InitializeComponent();
                this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
                _authService = new AuthService(new UserRepository());
                _materialService = new MaterialService(new MaterialRepository());

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
                    txtStock.Text = row.Cells["Stock"].Value?.ToString() ?? "";
                    txtSatuan.Text = row.Cells["Satuan"].Value?.ToString() ?? "";
                    chkPemesanan.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
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

            var ringkasan = new MaterialDipilih
            {
                Id = idMaterialTerpilih,
                MaterialName= txtNamaMaterial.Text.Trim(),
                UnitPrice = decimal.Parse(txtHarga.Text.Trim()),
                Satuan = txtSatuan.Text.Trim(),
                //Jumlah = int.Parse(txtJumlah.Text.Trim())
            };

            var ringkasanControl = new TansactionControl(mainForm, ringkasan);
            mainForm.LoadUserControl(ringkasanControl);
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

        private void chkPemesanan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblJumlah_Click(object sender, EventArgs e)
        {

        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
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

    }
}
