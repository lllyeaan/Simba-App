using MaterialOrderingApp.Forms.Admin;
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
                //?? throw new ArgumentNullException(nameof(form));
            _authService = new AuthService(new UserRepository());

            this.Load += CustomerDashboardControl_Load;
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


        private void label1_Click(object sender, EventArgs e)
        {
        }

    }
}
