using System;
using System.Windows.Forms;
using MaterialOrderingApp.Forms.UserControls;

namespace MaterialOrderingApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadControl(new LoginControl(this));
        }

        public void LoadControl(UserControl control)
        {
            panelMainForm.Controls.Clear();       
            control.Dock = DockStyle.Fill;
            panelMainForm.Controls.Add(control);  
        }

        public void LoadUserControl(UserControl control)
        {
            if (control == null) return;
            panelMainForm.Controls.Clear();       
            control.Dock = DockStyle.Fill;
            panelMainForm.Controls.Add(control);  
        }

        private void panelMainForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
