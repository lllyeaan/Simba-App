namespace MaterialOrderingApp.Forms.UserControls
{
    partial class ProfileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            splitContainer1 = new SplitContainer();
            btnNext = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            textBoxFullName = new TextBox();
            label5 = new Label();
            textBoxPhone = new TextBox();
            groupBoxAddress = new GroupBox();
            comboBoxKecamatan = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            comboBoxKabupaten = new ComboBox();
            label7 = new Label();
            textBoxJalan = new TextBox();
            comboBoxProvinsi = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBoxAddress.SuspendLayout();
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
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnNext);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(914, 480);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.AllowDrop = true;
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.White;
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(86, 284);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(105, 33);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.UseWaitCursor = true;
            btnNext.Click += btnSignIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 215);
            label3.Name = "label3";
            label3.Size = new Size(219, 91);
            label3.TabIndex = 11;
            label3.Text = "PROFILE";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Javanese Text", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 180);
            label2.Name = "label2";
            label2.Size = new Size(107, 62);
            label2.TabIndex = 10;
            label2.Text = "YOUR";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 124);
            label1.Name = "label1";
            label1.Size = new Size(272, 91);
            label1.TabIndex = 9;
            label1.Text = "COMPLETE";
            label1.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBoxFullName);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(textBoxPhone);
            flowLayoutPanel1.Controls.Add(groupBoxAddress);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(173, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(284, 378);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.TabStop = true;
            flowLayoutPanel1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 14);
            label4.TabIndex = 0;
            label4.Text = "Full  Name";
            label4.UseWaitCursor = true;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 12F);
            textBoxFullName.Location = new Point(3, 17);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(281, 37);
            textBoxFullName.TabIndex = 2;
            textBoxFullName.UseWaitCursor = true;
            textBoxFullName.TextChanged += textBoxUsername_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 57);
            label5.Name = "label5";
            label5.Size = new Size(48, 14);
            label5.TabIndex = 1;
            label5.Text = "Phone";
            label5.UseWaitCursor = true;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Verdana", 12F);
            textBoxPhone.Location = new Point(3, 74);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(281, 34);
            textBoxPhone.TabIndex = 3;
            textBoxPhone.UseWaitCursor = true;
            // 
            // groupBoxAddress
            // 
            groupBoxAddress.Controls.Add(comboBoxKecamatan);
            groupBoxAddress.Controls.Add(label9);
            groupBoxAddress.Controls.Add(label8);
            groupBoxAddress.Controls.Add(comboBoxKabupaten);
            groupBoxAddress.Controls.Add(label7);
            groupBoxAddress.Controls.Add(textBoxJalan);
            groupBoxAddress.Controls.Add(comboBoxProvinsi);
            groupBoxAddress.Controls.Add(label6);
            groupBoxAddress.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBoxAddress.ForeColor = SystemColors.ButtonHighlight;
            groupBoxAddress.Location = new Point(3, 114);
            groupBoxAddress.Name = "groupBoxAddress";
            groupBoxAddress.Size = new Size(281, 252);
            groupBoxAddress.TabIndex = 4;
            groupBoxAddress.TabStop = false;
            groupBoxAddress.Text = "Address";
            groupBoxAddress.UseWaitCursor = true;
            // 
            // comboBoxKecamatan
            // 
            comboBoxKecamatan.Font = new Font("Verdana", 12F, FontStyle.Bold);
            comboBoxKecamatan.FormattingEnabled = true;
            comboBoxKecamatan.Items.AddRange(new object[] { "Bangorejo", "Banyuwangi", "Blimbingsari", "Cluring", "Gambiran", "Genteng", "Giri", "Glagah", "Glenmore", "Kabat", "Kalibaru", "Kalipuro", "Licin", "Muncar", "Pesanggaran", "Purwoharjo", "Rogojampi", "Sempu", "Siliragung", "Singojuruh", "Songgon", "Srono", "Tegaldlimo", "Tegalsari", "Wongsorejo" });
            comboBoxKecamatan.Location = new Point(10, 148);
            comboBoxKecamatan.Name = "comboBoxKecamatan";
            comboBoxKecamatan.Size = new Size(262, 26);
            comboBoxKecamatan.TabIndex = 13;
            comboBoxKecamatan.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(13, 185);
            label9.Name = "label9";
            label9.Size = new Size(96, 14);
            label9.TabIndex = 12;
            label9.Text = "Alamat/Jalan";
            label9.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 131);
            label8.Name = "label8";
            label8.Size = new Size(80, 14);
            label8.TabIndex = 10;
            label8.Text = "Kecamatan";
            label8.UseWaitCursor = true;
            // 
            // comboBoxKabupaten
            // 
            comboBoxKabupaten.Font = new Font("Verdana", 12F, FontStyle.Bold);
            comboBoxKabupaten.FormattingEnabled = true;
            comboBoxKabupaten.Items.AddRange(new object[] { "Banyuwangi" });
            comboBoxKabupaten.Location = new Point(10, 97);
            comboBoxKabupaten.Name = "comboBoxKabupaten";
            comboBoxKabupaten.Size = new Size(262, 26);
            comboBoxKabupaten.TabIndex = 9;
            comboBoxKabupaten.UseWaitCursor = true;
            comboBoxKabupaten.SelectedIndexChanged += comboBoxKabupaten_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 80);
            label7.Name = "label7";
            label7.Size = new Size(115, 14);
            label7.TabIndex = 8;
            label7.Text = "Kabupaten/Kota";
            label7.UseWaitCursor = true;
            // 
            // textBoxJalan
            // 
            textBoxJalan.Font = new Font("Verdana", 12F);
            textBoxJalan.Location = new Point(10, 202);
            textBoxJalan.Multiline = true;
            textBoxJalan.Name = "textBoxJalan";
            textBoxJalan.Size = new Size(262, 30);
            textBoxJalan.TabIndex = 5;
            textBoxJalan.UseWaitCursor = true;
            // 
            // comboBoxProvinsi
            // 
            comboBoxProvinsi.Font = new Font("Verdana", 12F, FontStyle.Bold);
            comboBoxProvinsi.FormattingEnabled = true;
            comboBoxProvinsi.Items.AddRange(new object[] { "Jawa Timur" });
            comboBoxProvinsi.Location = new Point(10, 47);
            comboBoxProvinsi.Name = "comboBoxProvinsi";
            comboBoxProvinsi.Size = new Size(262, 26);
            comboBoxProvinsi.TabIndex = 7;
            comboBoxProvinsi.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 30);
            label6.Name = "label6";
            label6.Size = new Size(61, 14);
            label6.TabIndex = 6;
            label6.Text = "Provinsi";
            label6.UseWaitCursor = true;
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "ProfileControl";
            Size = new Size(914, 480);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBoxAddress.ResumeLayout(false);
            groupBoxAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNext;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private TextBox textBoxFullName;
        private Label label5;
        private TextBox textBoxPhone;
        private GroupBox groupBoxAddress;
        private Label label6;
        private Label label8;
        private ComboBox comboBoxKabupaten;
        private Label label7;
        private ComboBox comboBoxProvinsi;
        private Label label9;
        private ComboBox comboBoxKecamatan;
        private TextBox textBoxJalan;
    }
}
