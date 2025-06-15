namespace MaterialOrderingApp.Forms.UserControls
{
    partial class LoginControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tablePanelKiri = new TableLayoutPanel();
            labelWelcome = new Label();
            labelSub = new Label();
            btnSignUp = new Button();
            tableLayoutPanelLogin = new TableLayoutPanel();
            btnClosePictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelKiri.SuspendLayout();
            tableLayoutPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClosePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Black;
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(tablePanelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanelLogin);
            splitContainer1.Size = new Size(1151, 561);
            splitContainer1.SplitterDistance = 373;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tablePanelKiri
            // 
            tablePanelKiri.BackColor = Color.Transparent;
            tablePanelKiri.ColumnCount = 1;
            tablePanelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKiri.Controls.Add(labelWelcome, 0, 0);
            tablePanelKiri.Controls.Add(labelSub, 0, 2);
            tablePanelKiri.Controls.Add(btnSignUp, 0, 3);
            tablePanelKiri.Dock = DockStyle.Fill;
            tablePanelKiri.Location = new Point(0, 0);
            tablePanelKiri.Name = "tablePanelKiri";
            tablePanelKiri.Padding = new Padding(30, 40, 30, 40);
            tablePanelKiri.RowCount = 4;
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.Size = new Size(373, 561);
            tablePanelKiri.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.Dock = DockStyle.Fill;
            labelWelcome.Font = new Font("Verdana", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(33, 40);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(307, 168);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "WELCOME !";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSub
            // 
            labelSub.Dock = DockStyle.Fill;
            labelSub.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSub.ForeColor = Color.White;
            labelSub.Location = new Point(33, 280);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(307, 72);
            labelSub.TabIndex = 1;
            labelSub.Text = "Belum punya akun?";
            labelSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Top;
            btnSignUp.BackColor = Color.White;
            btnSignUp.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(106, 355);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(160, 50);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelLogin
            // 
            tableLayoutPanelLogin.BackColor = Color.FromArgb(33, 33, 33);
            tableLayoutPanelLogin.ColumnCount = 3;
            tableLayoutPanelLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanelLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanelLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanelLogin.Controls.Add(btnClosePictureBox, 2, 0);
            tableLayoutPanelLogin.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanelLogin.Controls.Add(label3, 1, 2);
            tableLayoutPanelLogin.Controls.Add(label1, 1, 3);
            tableLayoutPanelLogin.Controls.Add(textBoxUsername, 1, 4);
            tableLayoutPanelLogin.Controls.Add(label2, 1, 5);
            tableLayoutPanelLogin.Controls.Add(textBoxPassword, 1, 6);
            tableLayoutPanelLogin.Controls.Add(btnLogin, 1, 7);
            tableLayoutPanelLogin.Dock = DockStyle.Fill;
            tableLayoutPanelLogin.Location = new Point(0, 0);
            tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
            tableLayoutPanelLogin.Padding = new Padding(10, 30, 10, 30);
            tableLayoutPanelLogin.RowCount = 8;
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            tableLayoutPanelLogin.Size = new Size(772, 561);
            tableLayoutPanelLogin.TabIndex = 0;
            // 
            // btnClosePictureBox
            // 
            btnClosePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClosePictureBox.Cursor = Cursors.Hand;
            btnClosePictureBox.Image = Properties.Resources.icons8_close_window_100__1_;
            btnClosePictureBox.Location = new Point(706, 35);
            btnClosePictureBox.Margin = new Padding(0, 5, 10, 0);
            btnClosePictureBox.Name = "btnClosePictureBox";
            btnClosePictureBox.Size = new Size(46, 40);
            btnClosePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            btnClosePictureBox.TabIndex = 0;
            btnClosePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.simba_logo;
            pictureBox1.Location = new Point(285, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Verdana", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(148, 176);
            label3.Name = "label3";
            label3.Size = new Size(475, 55);
            label3.TabIndex = 2;
            label3.Text = "Sign In";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(148, 231);
            label1.Name = "label1";
            label1.Size = new Size(475, 45);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Font = new Font("Verdana", 13F);
            textBoxUsername.Location = new Point(165, 284);
            textBoxUsername.Margin = new Padding(20, 0, 20, 0);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(441, 39);
            textBoxUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 331);
            label2.Name = "label2";
            label2.Size = new Size(475, 45);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Verdana", 13F);
            textBoxPassword.Location = new Point(165, 384);
            textBoxPassword.Margin = new Padding(20, 0, 20, 0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(441, 39);
            textBoxPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(300, 434);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // LoginControl
            // 
            Controls.Add(splitContainer1);
            Name = "LoginControl";
            Size = new Size(1151, 561);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelKiri.ResumeLayout(false);
            tableLayoutPanelLogin.ResumeLayout(false);
            tableLayoutPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClosePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tablePanelKiri;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox btnClosePictureBox;
    }
}
