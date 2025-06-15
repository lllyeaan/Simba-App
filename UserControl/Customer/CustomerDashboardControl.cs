using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.Customer
{
    public partial class CustomerDashboardControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly OrderService _orderService;
        public CustomerDashboardControl(MainForm form)
        {
            mainForm = form;
            var deliveryRepo = new DeliveryRepository();
            _orderService = new OrderService(deliveryRepo);
            InitializeComponent();

            // Event untuk button
            btnBuatPesanan.Click += btnBuatPesanan_Click;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            btnLogOut.Click += btnLogOut_Click;

            // Hover efek: Konsisten dengan admin
            btnBuatPesanan.MouseEnter += (s, e) => btnBuatPesanan.BackColor = Color.FromArgb(65, 105, 225);
            btnBuatPesanan.MouseLeave += (s, e) => btnBuatPesanan.BackColor = Color.White;

            btnRiwayatTransaksi.MouseEnter += (s, e) => btnRiwayatTransaksi.BackColor = Color.FromArgb(65, 105, 225);
            btnRiwayatTransaksi.MouseLeave += (s, e) => btnRiwayatTransaksi.BackColor = Color.White;

            btnLogOut.MouseEnter += (s, e) => btnLogOut.BackColor = Color.FromArgb(232, 17, 35);
            btnLogOut.MouseLeave += (s, e) => btnLogOut.BackColor = Color.White;

            this.Load += CustomerDashboardControl_Load;
        }

        private void CustomerDashboardControl_Load(object sender, EventArgs e)
        {
            // Ambil user yang sedang login dari MainForm
            string namaCustomer = mainForm.CurrentUser?.Username ?? "Customer";
            int IdCustomer = mainForm.CurrentUser?.IdCustomer ?? 0;
            lblGreeting.Text = $"Selamat datang, {namaCustomer}!";

            //// Jika ada fitur total pesanan, ambil dari service (dummy sementara)
            int totalPesanan = AmbilTotalPesanan(IdCustomer);
            lblTotalPesanan.Text = $"Total Pesanan Anda: {totalPesanan}";
            //lblCompany tetap sebagai identitas
        }

        private int AmbilTotalPesanan(int IdCustomer)
        {
            var pesananList = _orderService.AmbilPesananByCustomer(IdCustomer);
            return pesananList?.Count ?? 0;
        }

        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            mainForm?.LoadUserControl(new MaterialSelectionControl(mainForm));
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            mainForm?.LoadUserControl(new HistoryControl(mainForm));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utils.UserManager.ActiveUser = null;
                mainForm.LoadUserControl(new LoginControl(mainForm));
            }
        }
    }
}
