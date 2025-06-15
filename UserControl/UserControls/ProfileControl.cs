using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Utils;
using MaterialOrderingApp.Repositories;
using Npgsql;
using System;
using System.Drawing;
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

            // --- SETUP CLOSE BUTTON (PictureBox) ---
            btnClosePictureBox.Image = ResourceHelper.LoadImageFromResources("close_app_white.png");
            btnClosePictureBox.Click += (s, e) => Application.Exit();
            btnClosePictureBox.MouseEnter += (s, e) =>
            {
                btnClosePictureBox.Image = ResourceHelper.LoadImageFromResources("close_app.png");
                btnClosePictureBox.BackColor = Color.Transparent;
            };
            btnClosePictureBox.MouseLeave += (s, e) =>
            {
                btnClosePictureBox.Image = ResourceHelper.LoadImageFromResources("close_app_white.png");
                btnClosePictureBox.BackColor = Color.Transparent;
            };

            // --- PANEL KIRI: BUTTON BACK ---
            btnBack.Click += (s, e) => _mainForm.LoadUserControl(new LoginControl(_mainForm));
            btnBack.MouseEnter += (s, e) => { btnBack.BackColor = Color.FromArgb(65, 105, 225); btnBack.ForeColor = Color.White; };
            btnBack.MouseLeave += (s, e) => { btnBack.BackColor = Color.White; btnBack.ForeColor = Color.Black; };

            // --- BUTTON SIMPAN/NEXT ---
            btnNext.Click += btnNext_Click;
            btnNext.MouseEnter += (s, e) => { btnNext.BackColor = Color.FromArgb(65, 105, 225); btnNext.ForeColor = Color.White; };
            btnNext.MouseLeave += (s, e) => { btnNext.BackColor = Color.White; btnNext.ForeColor = Color.Black; };

            // --- TEXTBOX PHONE ONLY NUMBER ---
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;

            // --- AUTOFILL jika ada data user lama ---
            if (_currentUser != null)
            {
                textBoxFullName.Text = _currentUser.FullName ?? "";
                textBoxPhone.Text = _currentUser.Phone ?? "";
                textBoxJalan.Text = _currentUser.Jalan ?? "";
            }
            else
            {
                MessageBox.Show("Pengguna belum login. Silakan login terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Load pilihan alamat ---
            LoadProvinsiDanKabupaten();
            LoadDataKecamatan();

            // --- Pre-select jika ada data user lama ---
            if (!string.IsNullOrWhiteSpace(_currentUser.Provinsi))
                comboBoxProvinsi.SelectedItem = _currentUser.Provinsi;
            if (!string.IsNullOrWhiteSpace(_currentUser.Kabupaten))
                comboBoxKabupaten.SelectedItem = _currentUser.Kabupaten;
            if (!string.IsNullOrWhiteSpace(_currentUser.Kecamatan))
            {
                for (int i = 0; i < comboBoxKecamatan.Items.Count; i++)
                {
                    if (comboBoxKecamatan.Items[i] is ComboBoxItem item && item.Text == _currentUser.Kecamatan)
                    {
                        comboBoxKecamatan.SelectedIndex = i;
                        break;
                    }
                }
            }
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
            try
            {
                using (NpgsqlConnection koneksiDB = DbConnectionHelper.GetConnection())
                {
                    koneksiDB.Open();
                    string query = "SELECT id_kecamatan, nama_kecamatan FROM kecamatan ORDER BY nama_kecamatan ASC";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, koneksiDB))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
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
            public override string ToString() => Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string provinsi = comboBoxProvinsi.Text;
            string kabupaten = comboBoxKabupaten.Text;
            string jalan = textBoxJalan.Text.Trim();
            ComboBoxItem selectedKecamatan = comboBoxKecamatan.SelectedItem as ComboBoxItem;

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

            _currentUser.FullName = fullName;
            _currentUser.Phone = phone;
            _currentUser.Provinsi = provinsi;
            _currentUser.Kabupaten = kabupaten;
            _currentUser.Kecamatan = selectedKecamatan.Text;
            _currentUser.Jalan = jalan;

            UserService userService = new UserService();
            userService.UpdateUser(_currentUser);
            userService.InsertCustomerFromProfile(_currentUser, selectedKecamatan.Value, jalan);

            MessageBox.Show("Profil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadUserControl(new LoginControl(_mainForm));
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
