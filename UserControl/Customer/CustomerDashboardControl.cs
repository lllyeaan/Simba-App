using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.UserControls;
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


namespace MaterialOrderingApp.Forms.Customer
{
    public partial class CustomerDashboardControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;

        public CustomerDashboardControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            _authService = new AuthService(new UserRepository());

            this.Load += CustomerDashboardControl_Load;
            btnBuatPesanan.Click += btnBuatPesanan_Click;
        }

        private void CustomerDashboardControl_Load(object sender, EventArgs e)
        {

        }


        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("MainForm Form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.LoadUserControl(new MaterialSelectionControl(mainForm));
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("MainForm Form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.LoadUserControl(new LoginControl(mainForm));
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("MainForm Form tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.LoadUserControl(new HistoryControl(mainForm));
        }
    }
}
