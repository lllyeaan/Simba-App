namespace MaterialOrderingApp.Forms.Admin
{
    partial class MaterialManagementControl
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
            splitContainer1 = new SplitContainer();
            btnKembali = new Button();
            label2 = new Label();
            label1 = new Label();
            chkTersedia = new CheckBox();
            txtSatuan = new TextBox();
            txtStock = new TextBox();
            txtHarga = new TextBox();
            txtNamaMaterial = new TextBox();
            btnClear = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvMaterial = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
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
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_30_at_13_29_27_f76fd8d4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnKembali);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(chkTersedia);
            splitContainer1.Panel2.Controls.Add(txtSatuan);
            splitContainer1.Panel2.Controls.Add(txtStock);
            splitContainer1.Panel2.Controls.Add(txtHarga);
            splitContainer1.Panel2.Controls.Add(txtNamaMaterial);
            splitContainer1.Panel2.Controls.Add(btnClear);
            splitContainer1.Panel2.Controls.Add(btnHapus);
            splitContainer1.Panel2.Controls.Add(btnEdit);
            splitContainer1.Panel2.Controls.Add(btnTambah);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(dgvMaterial);
            splitContainer1.Size = new Size(914, 480);
            splitContainer1.SplitterDistance = 304;
            splitContainer1.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.AllowDrop = true;
            btnKembali.Anchor = AnchorStyles.None;
            btnKembali.BackColor = Color.White;
            btnKembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnKembali.Cursor = Cursors.Hand;
            btnKembali.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(45, 279);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(188, 51);
            btnKembali.TabIndex = 12;
            btnKembali.Text = "Kembali";
            btnKembali.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.UseWaitCursor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Javanese Text", 39F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 168);
            label2.Name = "label2";
            label2.Size = new Size(244, 118);
            label2.TabIndex = 10;
            label2.Text = "Material";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 39F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 88);
            label1.Name = "label1";
            label1.Size = new Size(316, 118);
            label1.TabIndex = 9;
            label1.Text = "Manajemen";
            // 
            // chkTersedia
            // 
            chkTersedia.AutoSize = true;
            chkTersedia.CheckAlign = ContentAlignment.MiddleCenter;
            chkTersedia.Font = new Font("Segoe UI", 20F);
            chkTersedia.Location = new Point(178, 396);
            chkTersedia.Name = "chkTersedia";
            chkTersedia.Size = new Size(15, 14);
            chkTersedia.TabIndex = 21;
            chkTersedia.UseVisualStyleBackColor = true;
            chkTersedia.CheckedChanged += chkTersedia_CheckedChanged;
            // 
            // txtSatuan
            // 
            txtSatuan.Anchor = AnchorStyles.None;
            txtSatuan.Font = new Font("Verdana", 11F);
            txtSatuan.Location = new Point(178, 350);
            txtSatuan.Multiline = true;
            txtSatuan.Name = "txtSatuan";
            txtSatuan.Size = new Size(378, 32);
            txtSatuan.TabIndex = 20;
            txtSatuan.TextChanged += txtSatuan_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.None;
            txtStock.Font = new Font("Verdana", 11F);
            txtStock.Location = new Point(178, 312);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(378, 32);
            txtStock.TabIndex = 19;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // txtHarga
            // 
            txtHarga.Anchor = AnchorStyles.None;
            txtHarga.Font = new Font("Verdana", 11F);
            txtHarga.Location = new Point(178, 273);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(378, 32);
            txtHarga.TabIndex = 18;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // txtNamaMaterial
            // 
            txtNamaMaterial.Anchor = AnchorStyles.None;
            txtNamaMaterial.Font = new Font("Verdana", 11F);
            txtNamaMaterial.Location = new Point(178, 235);
            txtNamaMaterial.Multiline = true;
            txtNamaMaterial.Name = "txtNamaMaterial";
            txtNamaMaterial.Size = new Size(378, 32);
            txtNamaMaterial.TabIndex = 17;
            txtNamaMaterial.TextChanged += txtNamaMaterial_TextChanged;
            // 
            // btnClear
            // 
            btnClear.AllowDrop = true;
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.White;
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(441, 423);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 38);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.UseWaitCursor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnHapus
            // 
            btnHapus.AllowDrop = true;
            btnHapus.Anchor = AnchorStyles.None;
            btnHapus.BackColor = Color.White;
            btnHapus.BackgroundImageLayout = ImageLayout.Stretch;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.Black;
            btnHapus.Location = new Point(303, 423);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(132, 38);
            btnHapus.TabIndex = 15;
            btnHapus.Text = "Hapus";
            btnHapus.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.UseWaitCursor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.AllowDrop = true;
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.BackColor = Color.White;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(165, 423);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 38);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.UseWaitCursor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.AllowDrop = true;
            btnTambah.Anchor = AnchorStyles.None;
            btnTambah.BackColor = Color.White;
            btnTambah.BackgroundImageLayout = ImageLayout.Stretch;
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.Black;
            btnTambah.Location = new Point(27, 423);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(132, 38);
            btnTambah.TabIndex = 13;
            btnTambah.Text = "Tambah";
            btnTambah.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.UseWaitCursor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(32, 395);
            label7.Name = "label7";
            label7.Size = new Size(117, 18);
            label7.TabIndex = 5;
            label7.Text = "Katersediaan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(32, 353);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 4;
            label6.Text = "Satuan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 315);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 3;
            label5.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 279);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 2;
            label4.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 244);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 1;
            label3.Text = "Nama Material";
            // 
            // dgvMaterial
            // 
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Location = new Point(3, 0);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.Size = new Size(603, 223);
            dgvMaterial.TabIndex = 0;
            // 
            // MaterialManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "MaterialManagementControl";
            Size = new Size(914, 480);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvMaterial;
        private Label label2;
        private Label label1;
        private Button btnKembali;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnClear;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private TextBox txtNamaMaterial;
        private CheckBox chkTersedia;
        private TextBox txtSatuan;
        private TextBox txtStock;
        private TextBox txtHarga;
    }
}
