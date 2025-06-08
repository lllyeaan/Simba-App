using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.Customer;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Utils;
using System;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.UserControls
{
    public partial class LoginControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly AuthService _authService;

        // Hanya gunakan konstruktor dengan MainForm
        public LoginControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form ?? throw new ArgumentNullException(nameof(form));
            _authService = new AuthService(new UserRepository()); // Inisialisasi _authService
        }

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
                // Debugging log
                System.Diagnostics.Debug.WriteLine($"Attempting login with username: {username}, password: {password}");
                if (_authService == null)
                {
                    System.Diagnostics.Debug.WriteLine("Error: _authService is null");
                    throw new Exception("Authentication service not initialized.");
                }

                var user = _authService.Login(username, password);
                Utils.UserManager.ActiveUser = user;
               
                

                if (user.Role.ToLower() == "admin")
                {
                    mainForm.LoadUserControl(new AdminDashboardControl());
                }
                else if (user.Role.ToLower() == "customer")
                {
                    if (string.IsNullOrWhiteSpace(user.FullName) || string.IsNullOrWhiteSpace(user.Jalan))
                    {
                        MessageBox.Show("Lengkapi profil Anda terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.LoadUserControl(new ProfileControl(mainForm));
                    }
                    else
                    {
                        mainForm.LoadUserControl(new CustomerDashboardControl());
                    }
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Login failed: {ex.Message}");
                MessageBox.Show(ex.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
            {
                System.Diagnostics.Debug.WriteLine("Error: mainForm is null");
                throw new Exception("Main form not initialized.");
            }
            mainForm.LoadUserControl(new SignUpControl(mainForm));
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e) { }

        private void textBoxPassword_TextChanged(object sender, EventArgs e) { }
    }
}