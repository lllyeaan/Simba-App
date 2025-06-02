using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialOrderingApp.Forms.UserControls;
using MaterialOrderingApp.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaterialOrderingApp.Forms.UserControls
{
    public partial class SignUpControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly UserRepository _userRepository;

        public SignUpControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _userRepository = new UserRepository();
        }
        private Image LoadImageFromResources(string fileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(basePath, "Resources", fileName);

            if (File.Exists(imagePath))
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(imagePath)))
                {
                    return Image.FromStream(stream);
                }
            }
            else
            {
                MessageBox.Show($"Gambar '{fileName}' tidak ditemukan di folder Resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
                pictureBoxValidationUsername.Image = LoadImageFromResources("check_icon.png");
                toolTip1.SetToolTip(pictureBoxValidationUsername, "Username sudah digunakan");
            }
            else
            {
                pictureBoxValidationUsername.Image = LoadImageFromResources("cross_icon.png");
                toolTip1.SetToolTip(pictureBoxValidationUsername, "Username tersedia");
            }
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                pictureBoxValidationConfirmPassword.Image = LoadImageFromResources("check_icon.png");

                toolTip1.SetToolTip(pictureBoxValidationConfirmPassword, "Password cocok");
            }
            else
            {
                pictureBoxValidationConfirmPassword.Image = LoadImageFromResources("cross_icon.png");
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

            _userRepository.CreateUser(username, password, "customer");
            mainForm.LoadUserControl(new ProfileControl(mainForm));
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new LoginControl(mainForm));
        }

        private void pictureBoxValidationUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxValidationConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
