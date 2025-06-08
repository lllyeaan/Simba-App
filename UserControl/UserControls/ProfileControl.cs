using MaterialOrderingApp.Forms.Customer;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.UserControls
{
    public partial class ProfileControl : UserControl
    {
        private MainForm _mainForm;
        private readonly User _currentUser;

        public ProfileControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _currentUser = UserManager.ActiveUser;

            if (_currentUser == null)
            {
                MessageBox.Show("Pengguna belum login. Silakan login terlebih dahulu.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadAlamat();
        }

        private void LoadAlamat()
        {
            comboBoxProvinsi.Items.Clear();
            comboBoxKabupaten.Items.Clear();
            comboBoxKecamatan.Items.Clear();

            comboBoxProvinsi.Items.Add("Jawa Timur");
            comboBoxProvinsi.SelectedIndex = 0;

            comboBoxKabupaten.Items.Add("Banyuwangi");
            comboBoxKabupaten.SelectedIndex = 0;

            comboBoxKecamatan.Items.AddRange(new string[]
            {
                "Banyuwangi", "Rogojampi", "Genteng", "Kalipuro", "Cluring", "Tegaldlimo",
                "Pesanggaran", "Muncar", "Gambiran", "Srono", "Tegalsari", "Wongsorejo",
                "Glagah", "Purwoharjo", "Songgon", "Sempu", "Singojuruh", "Bangorejo",
                "Siliragung", "Glenmore", "Kalibaru", "Licin", "Giri", "Blimbingsari",
                "Temuguruh", "Taman Suruh"
            });
            comboBoxKecamatan.SelectedIndex = 0;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string provinsi = comboBoxProvinsi.Text;
            string kabupaten = comboBoxKabupaten.Text;
            string kecamatan = comboBoxKecamatan.Text;
            string jalan = textBoxJalan.Text.Trim();

            // Validasi input
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) ||
                provinsi == "-- Pilih Provinsi --" || kabupaten == "-- Pilih Kabupaten/Kota --" ||
                kecamatan == "-- Pilih Kecamatan --" || string.IsNullOrWhiteSpace(jalan))
            {
                MessageBox.Show("Silakan isi semua kolom dengan lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validasi nomor telepon
            if (!phone.StartsWith("62") || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Nomor HP harus berupa angka dan diawali dengan 62.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            _currentUser.FullName = fullName;
            _currentUser.Phone = phone;
            _currentUser.Provinsi = provinsi;
            _currentUser.Kabupaten = kabupaten;
            _currentUser.Kecamatan = kecamatan;
            _currentUser.Jalan = jalan;


            new UserService().UpdateUser(_currentUser);


            _mainForm.LoadUserControl(new CustomerDashboardControl());
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxKabupaten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan angka dan kontrol (Backspace, dll)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       


    }
}
