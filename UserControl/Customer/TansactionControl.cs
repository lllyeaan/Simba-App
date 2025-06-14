using MaterialOrderingApp.Forms.UserControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            _transactionService = transactionService ?? throw new ArgumentNullException(nameof(transactionService)); ;
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form)); ;
            _currentUser = currentUser ?? throw new ArgumentException(nameof(currentUser));
            System.Diagnostics.Debug.WriteLine("ID Customer: " + _currentUser.IdCustomer);
            TampilkanRingkasan();
        }

        private void TampilkanRingkasan()
        {
            try
            {
                if(_materialDipilih == null)
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
        private void lbltransaksi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnbuatpesanan_Click(object sender, EventArgs e)
        { 
            try
            {
                MaterialDipilih materialDipilih = new MaterialDipilih
                {
                    Id = _materialDipilih.Id,
                    MaterialName = _materialDipilih.MaterialName,
                    UnitPrice = _materialDipilih.UnitPrice,
                    Satuan = _materialDipilih.Satuan,
                    
                };

                prosesPesanan();
                MessageBox.Show("Pesanan Berhasil Dibuat! \nPesanan Anda Akan Diproses.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuat pesanan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void prosesPesanan()
        {
            string metodePembayaran = cmbboxmethod.SelectedItem?.ToString();
            
            if (string.IsNullOrEmpty(metodePembayaran))
            {
                MessageBox.Show("Silakan pilih metode pembayaran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (_materialDipilih == null)
                {
                    throw new InvalidOperationException("Material tidak valid");
                }
                Transaction transaction = new Transaction
                {
                    IdCustomer = _currentUser.IdCustomer,
                    IdMaterial = _materialDipilih.Id,
                 
                    subtotal = _materialDipilih.Total,
                    paymentmethod = metodePembayaran,
                    unitprice = _materialDipilih.UnitPrice
                };
                _transactionService.TambahPesanan(transaction);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses pesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}