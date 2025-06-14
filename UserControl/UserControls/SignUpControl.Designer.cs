namespace MaterialOrderingApp.Forms.UserControls
{
    partial class SignUpControl
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
            labelCreate = new Label();
            labelAccount = new Label();
            labelAlready = new Label();
            btnSignIn = new Button();
            tableLayoutPanelSignUp = new TableLayoutPanel();
            btnClosePictureBox = new PictureBox();
            pictureBoxLogo = new PictureBox();
            labelTitle = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            pictureBoxValidationUsername = new PictureBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            pictureBoxValidationConfirmPassword = new PictureBox();
            btnSignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelKiri.SuspendLayout();
            tableLayoutPanelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationConfirmPassword).BeginInit();
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
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanelSignUp);
            splitContainer1.Size = new Size(1100, 560);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tablePanelKiri
            // 
            tablePanelKiri.BackColor = Color.Transparent;
            tablePanelKiri.ColumnCount = 1;
            tablePanelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKiri.Controls.Add(labelCreate, 0, 0);
            tablePanelKiri.Controls.Add(labelAccount, 0, 1);
            tablePanelKiri.Controls.Add(labelAlready, 0, 2);
            tablePanelKiri.Controls.Add(btnSignIn, 0, 3);
            tablePanelKiri.Dock = DockStyle.Fill;
            tablePanelKiri.Location = new Point(0, 0);
            tablePanelKiri.Name = "tablePanelKiri";
            tablePanelKiri.RowCount = 4;
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.Size = new Size(380, 560);
            tablePanelKiri.TabIndex = 0;
            // 
            // labelCreate
            // 
            labelCreate.Dock = DockStyle.Fill;
            labelCreate.Font = new Font("Verdana", 38F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelCreate.ForeColor = Color.White;
            labelCreate.Location = new Point(3, 0);
            labelCreate.Name = "labelCreate";
            labelCreate.Size = new Size(374, 196);
            labelCreate.TabIndex = 0;
            labelCreate.Text = "CREATE";
            labelCreate.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelAccount
            // 
            labelAccount.Dock = DockStyle.Fill;
            labelAccount.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelAccount.ForeColor = Color.White;
            labelAccount.Location = new Point(3, 196);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(374, 84);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "ACCOUNT";
            labelAccount.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelAlready
            // 
            labelAlready.Dock = DockStyle.Fill;
            labelAlready.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelAlready.ForeColor = Color.White;
            labelAlready.Location = new Point(3, 280);
            labelAlready.Name = "labelAlready";
            labelAlready.Size = new Size(374, 84);
            labelAlready.TabIndex = 2;
            labelAlready.Text = "Already have an account?";
            labelAlready.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.None;
            btnSignIn.BackColor = Color.White;
            btnSignIn.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.Black;
            btnSignIn.Location = new Point(110, 439);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(160, 45);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelSignUp
            // 
            tableLayoutPanelSignUp.BackColor = Color.FromArgb(33, 33, 33);
            tableLayoutPanelSignUp.ColumnCount = 3;
            tableLayoutPanelSignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelSignUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelSignUp.Controls.Add(btnClosePictureBox, 2, 0);
            tableLayoutPanelSignUp.Controls.Add(pictureBoxLogo, 1, 1);
            tableLayoutPanelSignUp.Controls.Add(labelTitle, 1, 2);
            tableLayoutPanelSignUp.Controls.Add(labelUsername, 1, 3);
            tableLayoutPanelSignUp.Controls.Add(textBoxUsername, 1, 4);
            tableLayoutPanelSignUp.Controls.Add(pictureBoxValidationUsername, 2, 4);
            tableLayoutPanelSignUp.Controls.Add(labelPassword, 1, 5);
            tableLayoutPanelSignUp.Controls.Add(textBoxPassword, 1, 6);
            tableLayoutPanelSignUp.Controls.Add(labelConfirmPassword, 1, 7);
            tableLayoutPanelSignUp.Controls.Add(textBoxConfirmPassword, 1, 8);
            tableLayoutPanelSignUp.Controls.Add(pictureBoxValidationConfirmPassword, 2, 8);
            tableLayoutPanelSignUp.Controls.Add(btnSignUp, 1, 9);
            tableLayoutPanelSignUp.Dock = DockStyle.Fill;
            tableLayoutPanelSignUp.Location = new Point(0, 0);
            tableLayoutPanelSignUp.Name = "tableLayoutPanelSignUp";
            tableLayoutPanelSignUp.RowCount = 10;
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelSignUp.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            tableLayoutPanelSignUp.Size = new Size(714, 560);
            tableLayoutPanelSignUp.TabIndex = 0;
            // 
            // btnClosePictureBox
            // 
            btnClosePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClosePictureBox.Cursor = Cursors.Hand;
            btnClosePictureBox.Image = Properties.Resources.icons8_close_window_100__1_;
            btnClosePictureBox.Location = new Point(708, 5);
            btnClosePictureBox.Margin = new Padding(0, 5, 10, 0);
            btnClosePictureBox.Name = "btnClosePictureBox";
            btnClosePictureBox.Size = new Size(46, 40);
            btnClosePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            btnClosePictureBox.TabIndex = 0;
            btnClosePictureBox.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Image = Properties.Resources.simba_logo;
            pictureBoxLogo.Location = new Point(266, 54);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(180, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Verdana", 22F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(145, 163);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(422, 45);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Sign Up";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Verdana", 11F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(145, 208);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(422, 28);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Font = new Font("Verdana", 13F);
            textBoxUsername.Location = new Point(162, 239);
            textBoxUsername.Margin = new Padding(20, 0, 20, 0);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(388, 39);
            textBoxUsername.TabIndex = 4;
            // 
            // pictureBoxValidationUsername
            // 
            pictureBoxValidationUsername.Anchor = AnchorStyles.Left;
            pictureBoxValidationUsername.BackColor = Color.Transparent;
            pictureBoxValidationUsername.Location = new Point(573, 246);
            pictureBoxValidationUsername.Name = "pictureBoxValidationUsername";
            pictureBoxValidationUsername.Size = new Size(25, 25);
            pictureBoxValidationUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxValidationUsername.TabIndex = 5;
            pictureBoxValidationUsername.TabStop = false;
            // 
            // labelPassword
            // 
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Font = new Font("Verdana", 11F, FontStyle.Bold);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(145, 281);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(422, 28);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Verdana", 13F);
            textBoxPassword.Location = new Point(162, 312);
            textBoxPassword.Margin = new Padding(20, 0, 20, 0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(388, 39);
            textBoxPassword.TabIndex = 7;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.Dock = DockStyle.Fill;
            labelConfirmPassword.Font = new Font("Verdana", 11F, FontStyle.Bold);
            labelConfirmPassword.ForeColor = Color.White;
            labelConfirmPassword.Location = new Point(145, 354);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(422, 28);
            labelConfirmPassword.TabIndex = 8;
            labelConfirmPassword.Text = "Confirm Password";
            labelConfirmPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmPassword.Font = new Font("Verdana", 13F);
            textBoxConfirmPassword.Location = new Point(162, 385);
            textBoxConfirmPassword.Margin = new Padding(20, 0, 20, 0);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '●';
            textBoxConfirmPassword.Size = new Size(388, 39);
            textBoxConfirmPassword.TabIndex = 9;
            // 
            // pictureBoxValidationConfirmPassword
            // 
            pictureBoxValidationConfirmPassword.Anchor = AnchorStyles.Left;
            pictureBoxValidationConfirmPassword.BackColor = Color.Transparent;
            pictureBoxValidationConfirmPassword.Location = new Point(573, 392);
            pictureBoxValidationConfirmPassword.Name = "pictureBoxValidationConfirmPassword";
            pictureBoxValidationConfirmPassword.Size = new Size(25, 25);
            pictureBoxValidationConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxValidationConfirmPassword.TabIndex = 10;
            pictureBoxValidationConfirmPassword.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.BackColor = Color.White;
            btnSignUp.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(271, 469);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(170, 48);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // SignUpControl
            // 
            Controls.Add(splitContainer1);
            Name = "SignUpControl";
            Size = new Size(1100, 560);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelKiri.ResumeLayout(false);
            tableLayoutPanelSignUp.ResumeLayout(false);
            tableLayoutPanelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationConfirmPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tablePanelKiri;
        private Label labelCreate;
        private Label labelAccount;
        private Label labelAlready;
        private Button btnSignIn;
        private TableLayoutPanel tableLayoutPanelSignUp;
        private PictureBox btnClosePictureBox;
        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private PictureBox pictureBoxValidationUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private PictureBox pictureBoxValidationConfirmPassword;
        private Button btnSignUp;
    }
}
