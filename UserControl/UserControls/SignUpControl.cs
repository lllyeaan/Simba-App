using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Repositories;
using MaterialOrderingApp.Utils;
using MaterialOrderingApp.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MaterialOrderingApp.Forms.UserControls
{
    public partial class SignUpControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly UserRepository _userRepository;
        private readonly ToolTip toolTip1 = new ToolTip();
        public SignUpControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            _userRepository = new UserRepository();

            // Event handler tombol
            btnSignUp.Click += btnSignUp_Click;
            btnSignIn.Click += btnSignIn_Click;
            btnClosePictureBox.Click += btnClosePictureBox_Click;

            // Hover effect
            btnSignUp.MouseEnter += (s, e) => { btnSignUp.BackColor = Color.FromArgb(65, 105, 225); btnSignUp.ForeColor = Color.White; };
            btnSignUp.MouseLeave += (s, e) => { btnSignUp.BackColor = Color.White; btnSignUp.ForeColor = Color.Black; };

            btnSignIn.MouseEnter += (s, e) => { btnSignIn.BackColor = Color.FromArgb(65, 105, 225); btnSignIn.ForeColor = Color.White; };
            btnSignIn.MouseLeave += (s, e) => { btnSignIn.BackColor = Color.White; btnSignIn.ForeColor = Color.Black; };

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

            // Event validasi realtime
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            textBoxConfirmPassword.TextChanged += textBoxConfirmPassword_TextChanged;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                pictureBoxValidationUsername.Image = null;
                return;
            }

            if (_userRepository.IsUsernameTaken(username))
            {
                pictureBoxValidationUsername.Image = ResourceHelper.LoadImageFromResources("icons8-cross-100.png");
                toolTip1.SetToolTip(pictureBoxValidationUsername, "Username sudah digunakan");
            }
            else
            {
                pictureBoxValidationUsername.Image = ResourceHelper.LoadImageFromResources("icons8-check-100.png");
                toolTip1.SetToolTip(pictureBoxValidationUsername, "Username tersedia");
            }
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                pictureBoxValidationConfirmPassword.Image = ResourceHelper.LoadImageFromResources("icons8-check-100.png");
                toolTip1.SetToolTip(pictureBoxValidationConfirmPassword, "Password cocok");
            }
            else
            {
                pictureBoxValidationConfirmPassword.Image = ResourceHelper.LoadImageFromResources("icons8-cross-100.png");
                toolTip1.SetToolTip(pictureBoxValidationConfirmPassword, "Password tidak cocok");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Konfirmasi password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userRepository.IsUsernameTaken(username))
            {
                MessageBox.Show("Username sudah digunakan, coba username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = _userRepository.CreateUser(username, password, "customer");
            UserManager.ActiveUser = newUser;

            mainForm.LoadUserControl(new ProfileControl(mainForm));
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new LoginControl(mainForm));
        }

        // --- CLOSE BUTTON (PictureBox gambar X) ---
        private void btnClosePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
