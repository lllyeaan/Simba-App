namespace MaterialOrderingApp.Forms.Customer
{
    partial class MaterialSelectionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialSelectionControl));
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dbConnectionHelperBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            btnKembali = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            dgvMaterialSelection = new DataGridView();
            btnyakinpesan = new Button();
            txtJumlah = new TextBox();
            lblJumlah = new Label();
            txtSatuan = new TextBox();
            txtHarga = new TextBox();
            txtNamaMaterial = new TextBox();
            lblSatuan = new Label();
            lblHarga = new Label();
            lblNamaMaterial = new Label();
            btnPesan = new Button();
            dbConnectionHelperBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dbConnectionHelperBindingSource
            // 
            dbConnectionHelperBindingSource.DataSource = typeof(Repositories.DbConnectionHelper);
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
            splitContainer1.Panel1.Controls.Add(btnKembali);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(btnPesan);
            splitContainer1.Size = new Size(1306, 800);
            splitContainer1.SplitterDistance = 427;
            splitContainer1.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.AllowDrop = true;
            btnKembali.Anchor = AnchorStyles.None;
            btnKembali.BackColor = Color.White;
            btnKembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnKembali.Cursor = Cursors.Hand;
            btnKembali.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(124, 477);
            btnKembali.Margin = new Padding(4, 5, 4, 5);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(150, 39);
            btnKembali.TabIndex = 36;
            btnKembali.Text = "Kembali";
            btnKembali.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.UseWaitCursor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Javanese Text", 26F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 382);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(234, 118);
            label3.TabIndex = 12;
            label3.Text = "ORDER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Javanese Text", 26F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 315);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(324, 118);
            label2.TabIndex = 11;
            label2.Text = "MATERIAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 26F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 118);
            label1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvMaterialSelection);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnyakinpesan);
            splitContainer2.Panel2.Controls.Add(txtJumlah);
            splitContainer2.Panel2.Controls.Add(lblJumlah);
            splitContainer2.Panel2.Controls.Add(txtSatuan);
            splitContainer2.Panel2.Controls.Add(txtHarga);
            splitContainer2.Panel2.Controls.Add(txtNamaMaterial);
            splitContainer2.Panel2.Controls.Add(lblSatuan);
            splitContainer2.Panel2.Controls.Add(lblHarga);
            splitContainer2.Panel2.Controls.Add(lblNamaMaterial);
            splitContainer2.Size = new Size(869, 794);
            splitContainer2.SplitterDistance = 313;
            splitContainer2.TabIndex = 38;
            // 
            // dgvMaterialSelection
            // 
            dgvMaterialSelection.AutoGenerateColumns = false;
            dgvMaterialSelection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialSelection.DataSource = dbConnectionHelperBindingSource;
            dgvMaterialSelection.Location = new Point(3, -3);
            dgvMaterialSelection.Name = "dgvMaterialSelection";
            dgvMaterialSelection.RowHeadersWidth = 62;
            dgvMaterialSelection.Size = new Size(863, 313);
            dgvMaterialSelection.TabIndex = 0;
            // 
            // btnyakinpesan
            // 
            btnyakinpesan.AllowDrop = true;
            btnyakinpesan.Anchor = AnchorStyles.None;
            btnyakinpesan.BackColor = Color.White;
            btnyakinpesan.BackgroundImageLayout = ImageLayout.Stretch;
            btnyakinpesan.Cursor = Cursors.Hand;
            btnyakinpesan.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btnyakinpesan.ForeColor = Color.Black;
            btnyakinpesan.Location = new Point(651, 328);
            btnyakinpesan.Margin = new Padding(4, 5, 4, 5);
            btnyakinpesan.Name = "btnyakinpesan";
            btnyakinpesan.Size = new Size(173, 39);
            btnyakinpesan.TabIndex = 51;
            btnyakinpesan.Text = "Pesan";
            btnyakinpesan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnyakinpesan.UseVisualStyleBackColor = false;
            btnyakinpesan.UseWaitCursor = true;
            btnyakinpesan.Click += button1_Click;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(286, 252);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(538, 31);
            txtJumlah.TabIndex = 53;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblJumlah.ForeColor = SystemColors.ButtonHighlight;
            lblJumlah.Location = new Point(39, 252);
            lblJumlah.Margin = new Padding(4, 0, 4, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(227, 25);
            lblJumlah.TabIndex = 48;
            lblJumlah.Text = "Jumlah Pemesanan";
            // 
            // txtSatuan
            // 
            txtSatuan.Anchor = AnchorStyles.None;
            txtSatuan.Font = new Font("Verdana", 11F);
            txtSatuan.Location = new Point(286, 173);
            txtSatuan.Margin = new Padding(4, 5, 4, 5);
            txtSatuan.Multiline = true;
            txtSatuan.Name = "txtSatuan";
            txtSatuan.Size = new Size(538, 39);
            txtSatuan.TabIndex = 46;
            // 
            // txtHarga
            // 
            txtHarga.Anchor = AnchorStyles.None;
            txtHarga.Font = new Font("Verdana", 11F);
            txtHarga.Location = new Point(286, 102);
            txtHarga.Margin = new Padding(4, 5, 4, 5);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(538, 43);
            txtHarga.TabIndex = 44;
            // 
            // txtNamaMaterial
            // 
            txtNamaMaterial.Anchor = AnchorStyles.None;
            txtNamaMaterial.Font = new Font("Verdana", 11F);
            txtNamaMaterial.Location = new Point(286, 32);
            txtNamaMaterial.Margin = new Padding(4, 5, 4, 5);
            txtNamaMaterial.Multiline = true;
            txtNamaMaterial.Name = "txtNamaMaterial";
            txtNamaMaterial.Size = new Size(538, 41);
            txtNamaMaterial.TabIndex = 43;
            // 
            // lblSatuan
            // 
            lblSatuan.AutoSize = true;
            lblSatuan.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblSatuan.ForeColor = SystemColors.ButtonHighlight;
            lblSatuan.Location = new Point(39, 177);
            lblSatuan.Margin = new Padding(4, 0, 4, 0);
            lblSatuan.Name = "lblSatuan";
            lblSatuan.Size = new Size(89, 25);
            lblSatuan.TabIndex = 41;
            lblSatuan.Text = "Satuan";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblHarga.ForeColor = SystemColors.ButtonHighlight;
            lblHarga.Location = new Point(39, 102);
            lblHarga.Margin = new Padding(4, 0, 4, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(79, 25);
            lblHarga.TabIndex = 39;
            lblHarga.Text = "Harga";
            // 
            // lblNamaMaterial
            // 
            lblNamaMaterial.AutoSize = true;
            lblNamaMaterial.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblNamaMaterial.ForeColor = SystemColors.ButtonHighlight;
            lblNamaMaterial.Location = new Point(39, 36);
            lblNamaMaterial.Margin = new Padding(4, 0, 4, 0);
            lblNamaMaterial.Name = "lblNamaMaterial";
            lblNamaMaterial.Size = new Size(174, 25);
            lblNamaMaterial.TabIndex = 38;
            lblNamaMaterial.Text = "Nama Material";
            // 
            // btnPesan
            // 
            btnPesan.AllowDrop = true;
            btnPesan.Anchor = AnchorStyles.None;
            btnPesan.BackColor = Color.White;
            btnPesan.BackgroundImageLayout = ImageLayout.Stretch;
            btnPesan.Cursor = Cursors.Hand;
            btnPesan.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnPesan.ForeColor = Color.Black;
            btnPesan.Location = new Point(936, 592);
            btnPesan.Margin = new Padding(4, 5, 4, 5);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(109, 32);
            btnPesan.TabIndex = 34;
            btnPesan.Text = "Pesan";
            btnPesan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesan.UseVisualStyleBackColor = false;
            btnPesan.UseWaitCursor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // dbConnectionHelperBindingSource1
            // 
            dbConnectionHelperBindingSource1.DataSource = typeof(Repositories.DbConnectionHelper);
            // 
            // MaterialSelectionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "MaterialSelectionControl";
            Size = new Size(1306, 800);
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterialSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private BindingSource dbConnectionHelperBindingSource;
        private SplitContainer splitContainer1;
        private BindingSource dbConnectionHelperBindingSource1;
        private Button btnPesan;
        private Button btnKembali;
        private Label label1;
        private Label label2;
        private Label label3;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView1;
        private TextBox txtJumlah;
        private Label lblJumlah;
        private TextBox txtSatuan;
        private TextBox txtStock;
        private TextBox txtHarga;
        private TextBox txtNamaMaterial;
        private Label lblSatuan;
        private Label lblStok;
        private Label lblHarga;
        private Label lblNamaMaterial;
        private Button btnyakinpesan;
        private DataGridView dgvMaterialSelection;
    }
}
