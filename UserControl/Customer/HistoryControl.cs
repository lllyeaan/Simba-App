using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialOrderingApp.Utils;
using MaterialOrderingApp.Models;

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
            LoadHistoryControl();
        }

        //private void LoadHistoryControl()
        //{
        //    try
        //    {
        //        dgvhistory.DataSource = _orderService.AmbilPesananByCustomer(UserManager.ActiveUser.IdCustomer);
        //        dgvhistory.ClearSelection();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal memuat data riwayat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void LoadHistoryControl()
        {
            try
            {
                int idCustomer = UserManager.ActiveUser.IdCustomer;
                var data = _orderService.AmbilPesananByCustomer(idCustomer);

                MessageBox.Show("Jumlah pesanan ditemukan: " + data.Count);

                dgvhistory.DataSource = null;
                dgvhistory.DataSource = data;
                dgvhistory.ClearSelection();
                dgvhistory.Columns["CustomerName"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data riwayat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblhistory_Click(object sender, EventArgs e) { }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));
        }

        private void dgvhistory_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
        }

        private void lblhistory2_Click(object sender, EventArgs e) { }
    }
}