namespace MaterialOrderingApp.Forms.UserControls
{
    partial class SignUpControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpControl));
            splitContainer1 = new SplitContainer();
            btnSignIn = new Button();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            flowLayoutPanelSignUp = new FlowLayoutPanel();
            panelflowlayoutSignUp = new Panel();
            pictureBoxValidationConfirmPassword = new PictureBox();
            pictureBoxValidationUsername = new PictureBox();
            btnSignUp = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            textBoxConfirmPassword = new TextBox();
            textBoxUsername = new TextBox();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanelSignUp.SuspendLayout();
            panelflowlayoutSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationUsername).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnSignIn);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanelSignUp);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(914, 480);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.TabIndex = 0;
            // 
            // btnSignIn
            // 
            btnSignIn.AllowDrop = true;
            btnSignIn.Anchor = AnchorStyles.None;
            btnSignIn.BackColor = Color.White;
            btnSignIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.Black;
            btnSignIn.Location = new Point(90, 282);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(105, 33);
            btnSignIn.TabIndex = 10;
            btnSignIn.Text = "Sign In";
            btnSignIn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.UseWaitCursor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Javanese Text", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 243);
            label5.Name = "label5";
            label5.Size = new Size(193, 36);
            label5.TabIndex = 9;
            label5.Text = "Already have an account?";
            label5.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 188);
            label1.Name = "label1";
            label1.Size = new Size(243, 91);
            label1.TabIndex = 8;
            label1.Text = "ACCOUNT";
            label1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 137);
            label4.Name = "label4";
            label4.Size = new Size(206, 91);
            label4.TabIndex = 7;
            label4.Text = "CREATE";
            label4.UseWaitCursor = true;
            // 
            // flowLayoutPanelSignUp
            // 
            flowLayoutPanelSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelSignUp.BackColor = Color.Transparent;
            flowLayoutPanelSignUp.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanelSignUp.Controls.Add(panelflowlayoutSignUp);
            flowLayoutPanelSignUp.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelSignUp.Location = new Point(171, 116);
            flowLayoutPanelSignUp.Name = "flowLayoutPanelSignUp";
            flowLayoutPanelSignUp.Size = new Size(327, 255);
            flowLayoutPanelSignUp.TabIndex = 6;
            flowLayoutPanelSignUp.TabStop = true;
            flowLayoutPanelSignUp.UseWaitCursor = true;
            // 
            // panelflowlayoutSignUp
            // 
            panelflowlayoutSignUp.Controls.Add(pictureBoxValidationConfirmPassword);
            panelflowlayoutSignUp.Controls.Add(pictureBoxValidationUsername);
            panelflowlayoutSignUp.Controls.Add(btnSignUp);
            panelflowlayoutSignUp.Controls.Add(textBoxPassword);
            panelflowlayoutSignUp.Controls.Add(label3);
            panelflowlayoutSignUp.Controls.Add(label7);
            panelflowlayoutSignUp.Controls.Add(label2);
            panelflowlayoutSignUp.Controls.Add(textBoxConfirmPassword);
            panelflowlayoutSignUp.Controls.Add(textBoxUsername);
            panelflowlayoutSignUp.Location = new Point(3, 3);
            panelflowlayoutSignUp.Name = "panelflowlayoutSignUp";
            panelflowlayoutSignUp.Size = new Size(319, 248);
            panelflowlayoutSignUp.TabIndex = 8;
            panelflowlayoutSignUp.UseWaitCursor = true;
            // 
            // pictureBoxValidationConfirmPassword
            // 
            pictureBoxValidationConfirmPassword.BackColor = Color.White;
            pictureBoxValidationConfirmPassword.Location = new Point(276, 152);
            pictureBoxValidationConfirmPassword.Name = "pictureBoxValidationConfirmPassword";
            pictureBoxValidationConfirmPassword.Size = new Size(25, 22);
            pictureBoxValidationConfirmPassword.TabIndex = 8;
            pictureBoxValidationConfirmPassword.TabStop = false;
            pictureBoxValidationConfirmPassword.UseWaitCursor = true;
            pictureBoxValidationConfirmPassword.Click += pictureBoxValidationConfirmPassword_Click;
            // 
            // pictureBoxValidationUsername
            // 
            pictureBoxValidationUsername.BackColor = Color.White;
            pictureBoxValidationUsername.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxValidationUsername.Location = new Point(276, 27);
            pictureBoxValidationUsername.Name = "pictureBoxValidationUsername";
            pictureBoxValidationUsername.Size = new Size(25, 22);
            pictureBoxValidationUsername.TabIndex = 7;
            pictureBoxValidationUsername.TabStop = false;
            pictureBoxValidationUsername.UseWaitCursor = true;
            pictureBoxValidationUsername.Click += pictureBoxValidationUsername_Click;
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
            btnSignUp.Location = new Point(101, 202);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(118, 33);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.UseWaitCursor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 12F);
            textBoxPassword.Location = new Point(2, 81);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(312, 37);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 65);
            label3.Name = "label3";
            label3.Size = new Size(72, 14);
            label3.TabIndex = 1;
            label3.Text = "Password";
            label3.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 129);
            label7.Name = "label7";
            label7.Size = new Size(122, 14);
            label7.TabIndex = 5;
            label7.Text = "Confim Password";
            label7.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 3);
            label2.Name = "label2";
            label2.Size = new Size(74, 14);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.UseWaitCursor = true;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Verdana", 12F);
            textBoxConfirmPassword.Location = new Point(2, 146);
            textBoxConfirmPassword.Multiline = true;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(312, 36);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.UseWaitCursor = true;
            textBoxConfirmPassword.TextChanged += textBoxConfirmPassword_TextChanged;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Verdana", 12F);
            textBoxUsername.Location = new Point(3, 20);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(312, 37);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.UseWaitCursor = true;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Javanese Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(223, 50);
            label6.Name = "label6";
            label6.Size = new Size(170, 84);
            label6.TabIndex = 7;
            label6.Text = "Sign Up";
            label6.UseWaitCursor = true;
            // 
            // SignUpControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "SignUpControl";
            Size = new Size(914, 480);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanelSignUp.ResumeLayout(false);
            panelflowlayoutSignUp.ResumeLayout(false);
            panelflowlayoutSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxValidationUsername).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btnSignIn;
        private FlowLayoutPanel flowLayoutPanelSignUp;
        private Label label2;
        private TextBox textBoxUsername;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label7;
        private TextBox textBoxConfirmPassword;
        private Button btnSignUp;
        private Label label6;
        private Panel panelflowlayoutSignUp;
        private PictureBox pictureBoxValidationConfirmPassword;
        private PictureBox pictureBoxValidationUsername;
        private ToolTip toolTip1;
    }
}
