namespace MaterialOrderingApp.Forms.Customer
{
    partial class HistoryControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            panelKiri = new TableLayoutPanel();
            lblhistory = new Label();
            lblhistory2 = new Label();
            btnkembali = new Button();
            dgvhistory = new DataGridView();
            dbConnectionHelperBindingSource = new BindingSource(components);

            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelKiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(panelKiri);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            splitContainer1.Panel2.Controls.Add(dgvhistory);
            splitContainer1.Size = new Size(1306, 800);
            splitContainer1.SplitterDistance = 430;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.Transparent;
            panelKiri.ColumnCount = 1;
            panelKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelKiri.Controls.Add(lblhistory, 0, 0);
            panelKiri.Controls.Add(lblhistory2, 0, 1);
            panelKiri.Controls.Add(btnkembali, 0, 2);
            panelKiri.Dock = DockStyle.Fill;
            panelKiri.RowCount = 4;
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            panelKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            panelKiri.Padding = new Padding(30, 100, 30, 100);
            panelKiri.Name = "panelKiri";
            panelKiri.Size = new Size(430, 800);
            panelKiri.TabIndex = 0;
            // 
            // lblhistory
            // 
            lblhistory.Dock = DockStyle.Fill;
            lblhistory.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblhistory.ForeColor = Color.White;
            lblhistory.Text = "RIWAYAT";
            lblhistory.TextAlign = ContentAlignment.BottomCenter;
            lblhistory.Margin = new Padding(0, 0, 0, 10);
            // 
            // lblhistory2
            // 
            lblhistory2.Dock = DockStyle.Fill;
            lblhistory2.Font = new Font("Verdana", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblhistory2.ForeColor = Color.White;
            lblhistory2.Text = "TRANSAKSI";
            lblhistory2.TextAlign = ContentAlignment.TopCenter;
            lblhistory2.Margin = new Padding(0, 10, 0, 10);
            // 
            // btnkembali
            // 
            btnkembali.Anchor = AnchorStyles.Top;
            btnkembali.BackColor = Color.White;
            btnkembali.Font = new Font("Verdana", 13F, FontStyle.Bold);
            btnkembali.ForeColor = Color.Black;
            btnkembali.Location = new Point(65, 420);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(300, 45);
            btnkembali.TabIndex = 2;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += btnkembali_Click;
            // 
            // dgvhistory
            // 
            dgvhistory.AllowUserToAddRows = false;
            dgvhistory.AllowUserToDeleteRows = false;
            dgvhistory.ReadOnly = true;
            dgvhistory.BackgroundColor = Color.White;
            dgvhistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhistory.Dock = DockStyle.Fill;
            dgvhistory.Font = new Font("Verdana", 11F, FontStyle.Regular);
            dgvhistory.GridColor = Color.Gray;
            dgvhistory.Location = new Point(0, 0);
            dgvhistory.Name = "dgvhistory";
            dgvhistory.RowHeadersWidth = 62;
            dgvhistory.Size = new Size(870, 800);
            dgvhistory.TabIndex = 0;
            dgvhistory.DataSource = dbConnectionHelperBindingSource;
            // 
            // dbConnectionHelperBindingSource
            // 
            dbConnectionHelperBindingSource.DataSource = typeof(Repositories.DbConnectionHelper);
            // 
            // HistoryControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(splitContainer1);
            Name = "HistoryControl";
            Size = new Size(1306, 800);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelKiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel panelKiri;
        private Label lblhistory;
        private Label lblhistory2;
        private Button btnkembali;
        private DataGridView dgvhistory;
        private BindingSource dbConnectionHelperBindingSource;
    }
}
