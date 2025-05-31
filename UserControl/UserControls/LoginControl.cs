using System;
using System.Windows.Forms;
using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.Customer;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Models;

namespace MaterialOrderingApp.Forms.UserControls
{
    public partial class LoginControl : UserControl
    {
        private MainForm mainForm;
        private readonly AuthService _authService = new AuthService();

        public LoginControl()
        {
            InitializeComponent();
        }

        public LoginControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
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
                // Proses login
                var user = _authService.Login(username, password);
                Utils.Session.CurrentUser = user;

                // Arahkan sesuai role
                if (user.Role.ToLower() == "admin")
                {
                    mainForm.LoadUserControl(new AdminDashboardControl());
                }
                else if (user.Role.ToLower() == "customer")
                {
                    // Cek apakah data profil sudah lengkap
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
                MessageBox.Show(ex.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new SignUpControl(mainForm));
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e) { }

        private void textBoxPassword_TextChanged(object sender, EventArgs e) { }
    }
}
