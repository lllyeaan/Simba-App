namespace MaterialOrderingApp.Forms.UserControls
{
    partial class ProfileControl
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
            btnBack = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            btnClosePictureBox = new PictureBox();
            labelTitle = new Label();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelAlamat = new Label();
            panelAlamat = new Panel();
            labelProvinsi = new Label();
            comboBoxProvinsi = new ComboBox();
            labelKabupaten = new Label();
            comboBoxKabupaten = new ComboBox();
            labelKecamatan = new Label();
            comboBoxKecamatan = new ComboBox();
            labelJalan = new Label();
            textBoxJalan = new TextBox();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelKiri.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClosePictureBox).BeginInit();
            panelAlamat.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(tableLayoutPanelMain);
            splitContainer1.Size = new Size(1129, 569);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tablePanelKiri
            // 
            tablePanelKiri.BackColor = Color.Transparent;
            tablePanelKiri.ColumnCount = 1;
            tablePanelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKiri.Controls.Add(labelWelcome, 0, 0);
            tablePanelKiri.Controls.Add(labelSub, 0, 1);
            tablePanelKiri.Controls.Add(btnBack, 0, 2);
            tablePanelKiri.Dock = DockStyle.Fill;
            tablePanelKiri.Location = new Point(0, 0);
            tablePanelKiri.Name = "tablePanelKiri";
            tablePanelKiri.Padding = new Padding(30, 40, 30, 40);
            tablePanelKiri.RowCount = 4;
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.Size = new Size(380, 569);
            tablePanelKiri.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.Dock = DockStyle.Fill;
            labelWelcome.Font = new Font("Verdana", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(33, 40);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(314, 171);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "PROFILE";
            labelWelcome.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelSub
            // 
            labelSub.Dock = DockStyle.Fill;
            labelSub.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSub.ForeColor = Color.White;
            labelSub.Location = new Point(33, 211);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(314, 73);
            labelSub.TabIndex = 1;
            labelSub.Text = "Lengkapi Profil Anda";
            labelSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(110, 287);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 50);
            btnBack.TabIndex = 2;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.BackColor = Color.FromArgb(33, 33, 33);
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.Controls.Add(btnClosePictureBox, 2, 0);
            tableLayoutPanelMain.Controls.Add(labelTitle, 1, 1);
            tableLayoutPanelMain.Controls.Add(labelFullName, 1, 2);
            tableLayoutPanelMain.Controls.Add(textBoxFullName, 1, 3);
            tableLayoutPanelMain.Controls.Add(labelPhone, 1, 4);
            tableLayoutPanelMain.Controls.Add(textBoxPhone, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelAlamat, 1, 6);
            tableLayoutPanelMain.Controls.Add(panelAlamat, 1, 7);
            tableLayoutPanelMain.Controls.Add(btnNext, 1, 8);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 9;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 71.52318F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.4768219F));
            tableLayoutPanelMain.Size = new Size(743, 569);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // btnClosePictureBox
            // 
            btnClosePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClosePictureBox.Cursor = Cursors.Hand;
            btnClosePictureBox.Image = Properties.Resources.icons8_close_window_100__1_;
            btnClosePictureBox.Location = new Point(680, 5);
            btnClosePictureBox.Margin = new Padding(0, 5, 10, 0);
            btnClosePictureBox.Name = "btnClosePictureBox";
            btnClosePictureBox.Size = new Size(53, 37);
            btnClosePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            btnClosePictureBox.TabIndex = 0;
            btnClosePictureBox.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Verdana", 23F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(77, 42);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(588, 44);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Lengkapi Profil";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFullName
            // 
            labelFullName.Dock = DockStyle.Fill;
            labelFullName.Font = new Font("Verdana", 11F, FontStyle.Bold);
            labelFullName.ForeColor = Color.White;
            labelFullName.Location = new Point(77, 86);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(588, 26);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "Nama Lengkap";
            labelFullName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxFullName.Font = new Font("Verdana", 13F);
            textBoxFullName.Location = new Point(91, 115);
            textBoxFullName.Margin = new Padding(17, 3, 17, 3);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(560, 39);
            textBoxFullName.TabIndex = 3;
            // 
            // labelPhone
            // 
            labelPhone.Dock = DockStyle.Fill;
            labelPhone.Font = new Font("Verdana", 11F, FontStyle.Bold);
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(77, 150);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(588, 33);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Nomor HP (ex: 628123xxxxxx)";
            labelPhone.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.Font = new Font("Verdana", 13F);
            textBoxPhone.Location = new Point(91, 189);
            textBoxPhone.Margin = new Padding(17, 3, 17, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(560, 39);
            textBoxPhone.TabIndex = 5;
            // 
            // labelAlamat
            // 
            labelAlamat.Dock = DockStyle.Fill;
            labelAlamat.Font = new Font("Verdana", 11F, FontStyle.Bold);
            labelAlamat.ForeColor = Color.White;
            labelAlamat.Location = new Point(77, 234);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(588, 33);
            labelAlamat.TabIndex = 6;
            labelAlamat.Text = "Alamat";
            labelAlamat.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelAlamat
            // 
            panelAlamat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelAlamat.AutoScroll = true;
            panelAlamat.BackColor = Color.Transparent;
            panelAlamat.Controls.Add(labelProvinsi);
            panelAlamat.Controls.Add(comboBoxProvinsi);
            panelAlamat.Controls.Add(labelKabupaten);
            panelAlamat.Controls.Add(comboBoxKabupaten);
            panelAlamat.Controls.Add(labelKecamatan);
            panelAlamat.Controls.Add(comboBoxKecamatan);
            panelAlamat.Controls.Add(labelJalan);
            panelAlamat.Controls.Add(textBoxJalan);
            panelAlamat.Location = new Point(77, 270);
            panelAlamat.Name = "panelAlamat";
            panelAlamat.Size = new Size(588, 180);
            panelAlamat.TabIndex = 7;
            // 
            // labelProvinsi
            // 
            labelProvinsi.AutoSize = true;
            labelProvinsi.Font = new Font("Verdana", 9F, FontStyle.Bold);
            labelProvinsi.ForeColor = Color.White;
            labelProvinsi.Location = new Point(10, 7);
            labelProvinsi.Name = "labelProvinsi";
            labelProvinsi.Size = new Size(92, 22);
            labelProvinsi.TabIndex = 0;
            labelProvinsi.Text = "Provinsi";
            // 
            // comboBoxProvinsi
            // 
            comboBoxProvinsi.Font = new Font("Verdana", 11F);
            comboBoxProvinsi.FormattingEnabled = true;
            comboBoxProvinsi.Location = new Point(13, 28);
            comboBoxProvinsi.Name = "comboBoxProvinsi";
            comboBoxProvinsi.Size = new Size(560, 34);
            comboBoxProvinsi.TabIndex = 1;
            // 
            // labelKabupaten
            // 
            labelKabupaten.AutoSize = true;
            labelKabupaten.Font = new Font("Verdana", 9F, FontStyle.Bold);
            labelKabupaten.ForeColor = Color.White;
            labelKabupaten.Location = new Point(10, 65);
            labelKabupaten.Name = "labelKabupaten";
            labelKabupaten.Size = new Size(178, 22);
            labelKabupaten.TabIndex = 2;
            labelKabupaten.Text = "Kabupaten/Kota";
            // 
            // comboBoxKabupaten
            // 
            comboBoxKabupaten.Font = new Font("Verdana", 11F);
            comboBoxKabupaten.FormattingEnabled = true;
            comboBoxKabupaten.Location = new Point(13, 86);
            comboBoxKabupaten.Name = "comboBoxKabupaten";
            comboBoxKabupaten.Size = new Size(560, 34);
            comboBoxKabupaten.TabIndex = 3;
            // 
            // labelKecamatan
            // 
            labelKecamatan.AutoSize = true;
            labelKecamatan.Font = new Font("Verdana", 9F, FontStyle.Bold);
            labelKecamatan.ForeColor = Color.White;
            labelKecamatan.Location = new Point(10, 124);
            labelKecamatan.Name = "labelKecamatan";
            labelKecamatan.Size = new Size(123, 22);
            labelKecamatan.TabIndex = 4;
            labelKecamatan.Text = "Kecamatan";
            // 
            // comboBoxKecamatan
            // 
            comboBoxKecamatan.Font = new Font("Verdana", 11F);
            comboBoxKecamatan.FormattingEnabled = true;
            comboBoxKecamatan.Location = new Point(13, 145);
            comboBoxKecamatan.Name = "comboBoxKecamatan";
            comboBoxKecamatan.Size = new Size(560, 34);
            comboBoxKecamatan.TabIndex = 5;
            // 
            // labelJalan
            // 
            labelJalan.AutoSize = true;
            labelJalan.Font = new Font("Verdana", 9F, FontStyle.Bold);
            labelJalan.ForeColor = Color.White;
            labelJalan.Location = new Point(10, 185);
            labelJalan.Name = "labelJalan";
            labelJalan.Size = new Size(146, 22);
            labelJalan.TabIndex = 6;
            labelJalan.Text = "Alamat/Jalan";
            // 
            // textBoxJalan
            // 
            textBoxJalan.Font = new Font("Verdana", 11F);
            textBoxJalan.Location = new Point(13, 206);
            textBoxJalan.Multiline = true;
            textBoxJalan.Name = "textBoxJalan";
            textBoxJalan.Size = new Size(560, 36);
            textBoxJalan.TabIndex = 7;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.BackColor = Color.White;
            btnNext.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(286, 486);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(170, 48);
            btnNext.TabIndex = 8;
            btnNext.Text = "SIMPAN";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // ProfileControl
            // 
            Controls.Add(splitContainer1);
            Name = "ProfileControl";
            Size = new Size(1129, 569);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelKiri.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClosePictureBox).EndInit();
            panelAlamat.ResumeLayout(false);
            panelAlamat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tablePanelKiri;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox btnClosePictureBox;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Panel panelAlamat;
        private System.Windows.Forms.Label labelProvinsi;
        private System.Windows.Forms.ComboBox comboBoxProvinsi;
        private System.Windows.Forms.Label labelKabupaten;
        private System.Windows.Forms.ComboBox comboBoxKabupaten;
        private System.Windows.Forms.Label labelKecamatan;
        private System.Windows.Forms.ComboBox comboBoxKecamatan;
        private System.Windows.Forms.Label labelJalan;
        private System.Windows.Forms.TextBox textBoxJalan;
        private System.Windows.Forms.Button btnNext;
    }
}
