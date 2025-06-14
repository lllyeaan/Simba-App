namespace MaterialOrderingApp.Forms.UserControls
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            splitContainer1 = new SplitContainer();
            btnSignUp = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBoxUsername = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            button1 = new Button();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnSignUp);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(textBoxUsername);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(textBoxPassword);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(btnLogin);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.ForeColor = SystemColors.ControlText;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1306, 800);
            splitContainer1.SplitterDistance = 434;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.AllowDrop = true;
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.BackColor = Color.White;
            btnSignUp.BackgroundImageLayout = ImageLayout.Stretch;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(129, 443);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(147, 55);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Javanese Text", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(274, 54);
            label5.TabIndex = 7;
            label5.Text = "Don't you have account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(411, 136);
            label4.TabIndex = 6;
            label4.Text = "WELCOME !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 302);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Font = new Font("Verdana", 12F);
            textBoxUsername.Location = new Point(188, 362);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(400, 59);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ImeMode = ImeMode.On;
            flowLayoutPanel1.Location = new Point(243, 253);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.TabStop = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(243, 426);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.cross;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(769, 32);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(50, 55);
            button1.TabIndex = 5;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 12F);
            textBoxPassword.Location = new Point(247, 453);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(400, 61);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(335, 32);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.AllowDrop = true;
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.White;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(316, 572);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Javanese Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(335, 197);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 127);
            label3.TabIndex = 5;
            label3.Text = "Sign In";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginControl";
            Size = new Size(1306, 800);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private TextBox textBoxPassword;
        private Button btnLogin;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSignUp;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
