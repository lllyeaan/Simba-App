using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.Customer
{
    public partial class TansactionControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly MaterialDipilih _materialDipilih;
        private readonly TransactionService _transactionService;
        private readonly User _currentUser;

        public TansactionControl(MainForm form, MaterialDipilih materialDipilih, TransactionService transactionService, User currentUser)
        {
            InitializeComponent();

            _materialDipilih = materialDipilih ?? throw new ArgumentNullException(nameof(materialDipilih));
            _transactionService = transactionService ?? throw new ArgumentNullException(nameof(transactionService));
            mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));

            // Button Hover Effects (konsisten dengan halaman admin/customer)
            btnbatal.MouseEnter += (s, e) => btnbatal.BackColor = Color.FromArgb(232, 17, 35);
            btnbatal.MouseLeave += (s, e) => btnbatal.BackColor = Color.White;
            btnbuatpesanan.MouseEnter += (s, e) => btnbuatpesanan.BackColor = Color.FromArgb(65, 105, 225);
            btnbuatpesanan.MouseLeave += (s, e) => btnbuatpesanan.BackColor = Color.White;

            // Event handler
            btnbatal.Click += btnbatal_Click;
            cmbboxmethod.SelectedIndexChanged += cmbboxmethod_SelectedIndexChanged;

            // Show transaction summary
            TampilkanRingkasan();
        }

        private void TampilkanRingkasan()
        {
            try
            {
                if (_materialDipilih == null)
                {
                    MessageBox.Show("Material tidak valid");
                    return;
                }
                txtboxMaterial.Text = _materialDipilih.MaterialName;
                txtboxharga.Text = _materialDipilih.UnitPrice.ToString();
                txtboxtotal.Text = _materialDipilih.Total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan ringkasan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("MainForm Form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.LoadUserControl(new MaterialSelectionControl(mainForm));
        }

        private void btnbuatpesanan_Click(object sender, EventArgs e)
        {
            try
            {
                string metodePembayaran = cmbboxmethod.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(metodePembayaran))
                {
                    MessageBox.Show("Silakan pilih metode pembayaran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_materialDipilih == null)
                {
                    throw new InvalidOperationException("Material tidak valid");
                }

                // Membuat data transaksi
                Transaction transaction = new Transaction
                {
                    IdCustomer = _currentUser.IdCustomer,
                    IdMaterial = _materialDipilih.Id,
                    subtotal = _materialDipilih.Total,
                    paymentmethod = metodePembayaran,
                    quantity = 1,
                    unitprice = _materialDipilih.UnitPrice
                };

                _transactionService.TambahPesanan(transaction);
                var materialRepo = new MaterialRepository(); 
                materialRepo.UpdateStock(_materialDipilih.Id, 1);

                MessageBox.Show("Pesanan Berhasil Dibuat!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuat pesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbboxmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bisa diisi behavior jika ingin menampilkan instruksi khusus berdasarkan metode pembayaran
        }

        // Event label dll (optional, jika tidak dipakai bisa dihapus)
        private void lbltransaksi_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
