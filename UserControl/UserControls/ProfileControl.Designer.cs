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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            splitContainer1 = new SplitContainer();
            tablePanelKiri = new TableLayoutPanel();
            labelWelcome = new Label();
            labelSub = new Label();
            btnBack = new Button();
            tableLayoutPanelProfile = new TableLayoutPanel();
            labelTitle = new Label();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            groupBoxAlamat = new GroupBox();
            panelAlamatScrollable = new Panel();
            labelProvinsi = new Label();
            comboBoxProvinsi = new ComboBox();
            labelKabupaten = new Label();
            comboBoxKabupaten = new ComboBox();
            labelKecamatan = new Label();
            comboBoxKecamatan = new ComboBox();
            labelJalan = new Label();
            textBoxJalan = new TextBox();
            btnSimpan = new Button();

            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tablePanelKiri.SuspendLayout();
            tableLayoutPanelProfile.SuspendLayout();
            groupBoxAlamat.SuspendLayout();
            panelAlamatScrollable.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(tablePanelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanelProfile);
            splitContainer1.Size = new System.Drawing.Size(1151, 561);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // tablePanelKiri
            // 
            tablePanelKiri.BackColor = System.Drawing.Color.Transparent;
            tablePanelKiri.ColumnCount = 1;
            tablePanelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelKiri.Controls.Add(labelWelcome, 0, 0);
            tablePanelKiri.Controls.Add(labelSub, 0, 2);
            tablePanelKiri.Controls.Add(btnBack, 0, 3);
            tablePanelKiri.Dock = DockStyle.Fill;
            tablePanelKiri.Location = new System.Drawing.Point(0, 0);
            tablePanelKiri.Name = "tablePanelKiri";
            tablePanelKiri.RowCount = 4;
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePanelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tablePanelKiri.Size = new System.Drawing.Size(380, 561);
            tablePanelKiri.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.Dock = DockStyle.Fill;
            labelWelcome.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labelWelcome.ForeColor = System.Drawing.Color.White;
            labelWelcome.Location = new System.Drawing.Point(3, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new System.Drawing.Size(374, 196);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "WELCOME !";
            labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSub
            // 
            labelSub.Dock = DockStyle.Fill;
            labelSub.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            labelSub.ForeColor = System.Drawing.Color.White;
            labelSub.Location = new System.Drawing.Point(3, 252);
            labelSub.Name = "labelSub";
            labelSub.Size = new System.Drawing.Size(374, 84);
            labelSub.TabIndex = 1;
            labelSub.Text = "Lengkapi profil Anda";
            labelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBack.ForeColor = System.Drawing.Color.Black;
            btnBack.Location = new System.Drawing.Point(110, 486);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(160, 50);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelProfile
            // 
            tableLayoutPanelProfile.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            tableLayoutPanelProfile.ColumnCount = 3;
            tableLayoutPanelProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelProfile.Controls.Add(labelTitle, 1, 0);
            tableLayoutPanelProfile.Controls.Add(labelFullName, 1, 1);
            tableLayoutPanelProfile.Controls.Add(textBoxFullName, 1, 2);
            tableLayoutPanelProfile.Controls.Add(labelPhone, 1, 3);
            tableLayoutPanelProfile.Controls.Add(textBoxPhone, 1, 4);
            tableLayoutPanelProfile.Controls.Add(groupBoxAlamat, 1, 5);
            tableLayoutPanelProfile.Controls.Add(btnSimpan, 1, 6);
            tableLayoutPanelProfile.Dock = DockStyle.Fill;
            tableLayoutPanelProfile.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelProfile.Name = "tableLayoutPanelProfile";
            tableLayoutPanelProfile.RowCount = 7;
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));     // Title
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));     // Label Full Name
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));     // Input Full Name
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));     // Label Phone
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));     // Input Phone
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));      // Group Alamat (auto grow)
            tableLayoutPanelProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));     // Button Simpan
            tableLayoutPanelProfile.Size = new System.Drawing.Size(765, 561);
            tableLayoutPanelProfile.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(118, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(529, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Lengkapi Profil Anda";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFullName
            // 
            labelFullName.Dock = DockStyle.Bottom;
            labelFullName.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFullName.ForeColor = System.Drawing.Color.White;
            labelFullName.Location = new System.Drawing.Point(118, 65);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new System.Drawing.Size(529, 35);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name";
            labelFullName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = ((AnchorStyles.Left | AnchorStyles.Right));
            textBoxFullName.Font = new System.Drawing.Font("Verdana", 12F);
            textBoxFullName.Location = new System.Drawing.Point(128, 105);
            textBoxFullName.Margin = new Padding(10, 0, 10, 0);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new System.Drawing.Size(509, 32);
            textBoxFullName.TabIndex = 2;
            // 
            // labelPhone
            // 
            labelPhone.Dock = DockStyle.Bottom;
            labelPhone.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPhone.ForeColor = System.Drawing.Color.White;
            labelPhone.Location = new System.Drawing.Point(118, 145);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new System.Drawing.Size(529, 35);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone (format: 62...)";
            labelPhone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = ((AnchorStyles.Left | AnchorStyles.Right));
            textBoxPhone.Font = new System.Drawing.Font("Verdana", 12F);
            textBoxPhone.Location = new System.Drawing.Point(128, 185);
            textBoxPhone.Margin = new Padding(10, 0, 10, 0);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new System.Drawing.Size(509, 32);
            textBoxPhone.TabIndex = 4;
            // 
            // groupBoxAlamat
            // 
            groupBoxAlamat.Anchor = ((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom));
            groupBoxAlamat.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBoxAlamat.ForeColor = System.Drawing.Color.White;
            groupBoxAlamat.Text = "Alamat";
            groupBoxAlamat.Controls.Add(panelAlamatScrollable);
            groupBoxAlamat.Location = new System.Drawing.Point(118, 225);
            groupBoxAlamat.Name = "groupBoxAlamat";
            groupBoxAlamat.Size = new System.Drawing.Size(529, 220);
            groupBoxAlamat.TabIndex = 5;
            groupBoxAlamat.TabStop = false;
            //
            // panelAlamatScrollable
            //
            panelAlamatScrollable.AutoScroll = true;
            panelAlamatScrollable.Dock = DockStyle.Fill;
            panelAlamatScrollable.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            panelAlamatScrollable.Controls.Add(labelProvinsi);
            panelAlamatScrollable.Controls.Add(comboBoxProvinsi);
            panelAlamatScrollable.Controls.Add(labelKabupaten);
            panelAlamatScrollable.Controls.Add(comboBoxKabupaten);
            panelAlamatScrollable.Controls.Add(labelKecamatan);
            panelAlamatScrollable.Controls.Add(comboBoxKecamatan);
            panelAlamatScrollable.Controls.Add(labelJalan);
            panelAlamatScrollable.Controls.Add(textBoxJalan);
            panelAlamatScrollable.Location = new System.Drawing.Point(3, 24);
            panelAlamatScrollable.Name = "panelAlamatScrollable";
            panelAlamatScrollable.Size = new System.Drawing.Size(523, 193); // fix height, can be adjusted
            panelAlamatScrollable.TabIndex = 0;
            //
            // labelProvinsi
            //
            labelProvinsi.AutoSize = true;
            labelProvinsi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            labelProvinsi.ForeColor = System.Drawing.Color.White;
            labelProvinsi.Location = new System.Drawing.Point(10, 10);
            labelProvinsi.Name = "labelProvinsi";
            labelProvinsi.Size = new System.Drawing.Size(75, 20);
            labelProvinsi.TabIndex = 0;
            labelProvinsi.Text = "Provinsi";
            //
            // comboBoxProvinsi
            //
            comboBoxProvinsi.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            comboBoxProvinsi.Location = new System.Drawing.Point(10, 35);
            comboBoxProvinsi.Name = "comboBoxProvinsi";
            comboBoxProvinsi.Size = new System.Drawing.Size(400, 30);
            comboBoxProvinsi.TabIndex = 1;
            //
            // labelKabupaten
            //
            labelKabupaten.AutoSize = true;
            labelKabupaten.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            labelKabupaten.ForeColor = System.Drawing.Color.White;
            labelKabupaten.Location = new System.Drawing.Point(10, 70);
            labelKabupaten.Name = "labelKabupaten";
            labelKabupaten.Size = new System.Drawing.Size(131, 20);
            labelKabupaten.TabIndex = 2;
            labelKabupaten.Text = "Kabupaten/Kota";
            //
            // comboBoxKabupaten
            //
            comboBoxKabupaten.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            comboBoxKabupaten.Location = new System.Drawing.Point(10, 95);
            comboBoxKabupaten.Name = "comboBoxKabupaten";
            comboBoxKabupaten.Size = new System.Drawing.Size(400, 30);
            comboBoxKabupaten.TabIndex = 3;
            //
            // labelKecamatan
            //
            labelKecamatan.AutoSize = true;
            labelKecamatan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            labelKecamatan.ForeColor = System.Drawing.Color.White;
            labelKecamatan.Location = new System.Drawing.Point(10, 130);
            labelKecamatan.Name = "labelKecamatan";
            labelKecamatan.Size = new System.Drawing.Size(104, 20);
            labelKecamatan.TabIndex = 4;
            labelKecamatan.Text = "Kecamatan";
            //
            // comboBoxKecamatan
            //
            comboBoxKecamatan.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            comboBoxKecamatan.Location = new System.Drawing.Point(10, 155);
            comboBoxKecamatan.Name = "comboBoxKecamatan";
            comboBoxKecamatan.Size = new System.Drawing.Size(400, 30);
            comboBoxKecamatan.TabIndex = 5;
            //
            // labelJalan
            //
            labelJalan.AutoSize = true;
            labelJalan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            labelJalan.ForeColor = System.Drawing.Color.White;
            labelJalan.Location = new System.Drawing.Point(10, 190);
            labelJalan.Name = "labelJalan";
            labelJalan.Size = new System.Drawing.Size(56, 20);
            labelJalan.TabIndex = 6;
            labelJalan.Text = "Jalan";
            //
            // textBoxJalan
            //
            textBoxJalan.Font = new System.Drawing.Font("Verdana", 11F);
            textBoxJalan.Location = new System.Drawing.Point(10, 215);
            textBoxJalan.Multiline = true;
            textBoxJalan.Name = "textBoxJalan";
            textBoxJalan.Size = new System.Drawing.Size(400, 45);
            textBoxJalan.TabIndex = 7;
            //
            // btnSimpan
            //
            btnSimpan.Anchor = AnchorStyles.None;
            btnSimpan.BackColor = System.Drawing.Color.White;
            btnSimpan.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            btnSimpan.ForeColor = System.Drawing.Color.Black;
            btnSimpan.Location = new System.Drawing.Point(297, 511);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new System.Drawing.Size(170, 48);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;

            // 
            // ProfileControl
            // 
            this.Controls.Add(splitContainer1);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(1151, 561);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            tablePanelKiri.ResumeLayout(false);
            tableLayoutPanelProfile.ResumeLayout(false);
            tableLayoutPanelProfile.PerformLayout();
            groupBoxAlamat.ResumeLayout(false);
            panelAlamatScrollable.ResumeLayout(false);
            panelAlamatScrollable.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tablePanelKiri;
        private Label labelWelcome;
        private Label labelSub;
        private Button btnBack;

        private TableLayoutPanel tableLayoutPanelProfile;
        private Label labelTitle;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private GroupBox groupBoxAlamat;
        private Panel panelAlamatScrollable;
        private Label labelProvinsi;
        private ComboBox comboBoxProvinsi;
        private Label labelKabupaten;
        private ComboBox comboBoxKabupaten;
        private Label labelKecamatan;
        private ComboBox comboBoxKecamatan;
        private Label labelJalan;
        private TextBox textBoxJalan;
        private Button btnSimpan;
    }
}
