using MaterialOrderingApp.Forms.Customer;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Utils;
using Npgsql;
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

            LoadDataKecamatan();
            LoadProvinsiDanKabupaten();
        }

        private void LoadProvinsiDanKabupaten()
        {
            comboBoxProvinsi.Items.Clear();
            comboBoxKabupaten.Items.Clear();

            comboBoxProvinsi.Items.Add("Jawa Timur");
            comboBoxProvinsi.SelectedIndex = 0;

            comboBoxKabupaten.Items.Add("Banyuwangi");
            comboBoxKabupaten.SelectedIndex = 0;
        }

        private void LoadDataKecamatan()
        {
            string koneksi = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=DBSimbaNew;";

            try
            {
                using (var koneksiDB = new NpgsqlConnection(koneksi))
                {
                    koneksiDB.Open();

                    string query = "SELECT id_kecamatan, nama_kecamatan FROM kecamatan ORDER BY nama_kecamatan ASC";

                    using (var cmd = new NpgsqlCommand(query, koneksiDB))
                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBoxKecamatan.Items.Clear();

                        while (reader.Read())
                        {
                            string idKecamatan = reader.GetString(0);
                            string namaKecamatan = reader.GetString(1);

                            comboBoxKecamatan.Items.Add(new ComboBoxItem
                            {
                                Text = namaKecamatan,
                                Value = idKecamatan
                            });
                        }

                        if (comboBoxKecamatan.Items.Count > 0)
                        {
                            comboBoxKecamatan.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kecamatan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string provinsi = comboBoxProvinsi.Text;
            string kabupaten = comboBoxKabupaten.Text;
            string jalan = textBoxJalan.Text.Trim();
            var selectedKecamatan = comboBoxKecamatan.SelectedItem as ComboBoxItem;

            if (_currentUser == null)
            {
                MessageBox.Show("User belum login. Tidak bisa update profil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(provinsi) || string.IsNullOrWhiteSpace(kabupaten) ||
                selectedKecamatan == null || string.IsNullOrWhiteSpace(jalan))
            {
                MessageBox.Show("Silakan isi semua kolom dengan lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!phone.StartsWith("62") || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Nomor HP harus berupa angka dan diawali dengan 62.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan ke properti user
            _currentUser.FullName = fullName;
            _currentUser.Phone = phone;
            _currentUser.Provinsi = provinsi;
            _currentUser.Kabupaten = kabupaten;
            _currentUser.Kecamatan = selectedKecamatan.Text;
            _currentUser.Jalan = jalan;

            var userService = new UserService();
            userService.UpdateUser(_currentUser); // update tabel 'users'

            // insert ke tabel 'customer'
            userService.InsertCustomerFromProfile(_currentUser, selectedKecamatan.Value, jalan);

            MessageBox.Show("Profil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadUserControl(new LoginControl(_mainForm));
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e) { }

        private void comboBoxKabupaten_SelectedIndexChanged(object sender, EventArgs e) { }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
