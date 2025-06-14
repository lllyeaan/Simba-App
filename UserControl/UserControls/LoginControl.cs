using MaterialOrderingApp.Forms.Admin;
using MaterialOrderingApp.Forms.Customer;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Services;
using MaterialOrderingApp.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
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
                //System.Diagnostics.Debug.WriteLine($"Login failed: {ex.Message}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}