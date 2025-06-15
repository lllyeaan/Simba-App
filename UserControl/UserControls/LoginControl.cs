using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.Customer;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.UserControls
{
    public partial class LoginControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;

        public LoginControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _authService = new AuthService(new UserRepository());

            // Event handler tombol
            btnLogin.Click += btnLogin_Click;
            btnSignUp.Click += btnSignUp_Click;
            btnClosePictureBox.Click += btnClosePictureBox_Click;

            // Hover effect
            btnLogin.MouseEnter += (s, e) => { btnLogin.BackColor = Color.FromArgb(65, 105, 225); btnLogin.ForeColor = Color.White; };
            btnLogin.MouseLeave += (s, e) => { btnLogin.BackColor = Color.White; btnLogin.ForeColor = Color.Black; };

            btnSignUp.MouseEnter += (s, e) => { btnSignUp.BackColor = Color.FromArgb(65, 105, 225); btnSignUp.ForeColor = Color.White; };
            btnSignUp.MouseLeave += (s, e) => { btnSignUp.BackColor = Color.White; btnSignUp.ForeColor = Color.Black; };

            btnClosePictureBox.Image = ResourceHelper.LoadImageFromResources("close_app_white.png");

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
        }

        // --- LOGIN BUTTON ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Silakan isi Username dan Password terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MaterialOrderingApp.Models.User user = _authService.Login(username, password);
                Utils.UserManager.ActiveUser = user;
                System.Diagnostics.Debug.WriteLine("ID Customer setelah login: " + user.IdCustomer);
                //System.Diagnostics.Debug.WriteLine($"Attempting login with username: {username}, password: {password}");
                if (user == null)
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    //System.Diagnostics.Debug.WriteLine("Error: _authService is null");
                    //throw new Exception("Authentication service not initialized.");
                }


                mainForm.CurrentUser = user;

                if (user.Role.ToLower() == "admin")
                {
                    mainForm.LoadUserControl(new AdminDashboardControl(mainForm));
                }
                else if (user.Role.ToLower() == "customer")
                {
                    mainForm.LoadUserControl(new CustomerDashboardControl(mainForm));
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- SIGNUP BUTTON ---
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                MessageBox.Show("Main form tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.LoadUserControl(new SignUpControl(mainForm));
        }

        // --- CLOSE BUTTON (PictureBox gambar X) ---
        private void btnClosePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
