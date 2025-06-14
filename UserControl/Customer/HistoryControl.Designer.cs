namespace MaterialOrderingApp.Forms.Customer
{
    partial class HistoryControl
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
            splitContainer1 = new SplitContainer();
            btnkembali = new Button();
            lblhistory2 = new Label();
            lblhistory = new Label();
            dgvhistory = new DataGridView();
            dbConnectionHelperBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnkembali);
            splitContainer1.Panel1.Controls.Add(lblhistory2);
            splitContainer1.Panel1.Controls.Add(lblhistory);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvhistory);
            splitContainer1.Size = new Size(1306, 800);
            splitContainer1.SplitterDistance = 435;
            splitContainer1.TabIndex = 0;
            // 
            // btnkembali
            // 
            btnkembali.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkembali.Location = new Point(161, 464);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(133, 47);
            btnkembali.TabIndex = 2;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // lblhistory2
            // 
            lblhistory2.AutoSize = true;
            lblhistory2.BackColor = Color.Transparent;
            lblhistory2.Font = new Font("Javanese Text", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhistory2.ForeColor = Color.White;
            lblhistory2.Location = new Point(60, 345);
            lblhistory2.Name = "lblhistory2";
            lblhistory2.Size = new Size(311, 136);
            lblhistory2.TabIndex = 1;
            lblhistory2.Text = "Transaksi";
            lblhistory2.TextAlign = ContentAlignment.MiddleCenter;
            lblhistory2.Click += lblhistory2_Click;
            // 
            // lblhistory
            // 
            lblhistory.AutoSize = true;
            lblhistory.BackColor = Color.Transparent;
            lblhistory.Font = new Font("Javanese Text", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhistory.ForeColor = Color.White;
            lblhistory.Location = new Point(84, 261);
            lblhistory.Name = "lblhistory";
            lblhistory.Size = new Size(287, 136);
            lblhistory.TabIndex = 0;
            lblhistory.Text = "Riwayat ";
            lblhistory.TextAlign = ContentAlignment.MiddleCenter;
            lblhistory.Click += lblhistory_Click;
            // 
            // dgvhistory
            // 
            dgvhistory.AutoGenerateColumns = false;
            dgvhistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhistory.ColumnHeadersVisible = false;
            dgvhistory.DataSource = dbConnectionHelperBindingSource;
            dgvhistory.Dock = DockStyle.Fill;
            dgvhistory.Location = new Point(0, 0);
            dgvhistory.Name = "dgvhistory";
            dgvhistory.RowHeadersWidth = 62;
            dgvhistory.Size = new Size(867, 800);
            dgvhistory.TabIndex = 0;
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
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionHelperBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblhistory2;
        private Label lblhistory;
        private Button btnkembali;
        private DataGridView dgvhistory;
        private BindingSource dbConnectionHelperBindingSource;
    }
}
