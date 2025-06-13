using MaterialOrderingApp.Models;
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
    public partial class TansactionControl : UserControl
    {
        private readonly MainForm mainForm;
        //private readonly MaterialService _materialService;
        private readonly MaterialDipilih _materialDipilih;

        public TansactionControl(MainForm form, MaterialDipilih materialDipilih)
        {
            InitializeComponent();
            _materialDipilih = materialDipilih;
            this.mainForm = form;
            TampilkanRingkasan();
        }

        private void TampilkanRingkasan()
        {
            txtboxMaterial.Text = _materialDipilih.MaterialName;
            txtboxharga.Text = _materialDipilih.UnitPrice.ToString();
            //txtboxjumlah.Text = _materialDipilih.Jumlah.ToString();
            //txt.Text = _materialDipilih.Satuan;
        }
        private void lbltransaksi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
