namespace MaterialOrderingApp.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMainForm = new Panel();
            SuspendLayout();
            // 
            // panelMainForm
            // 
            panelMainForm.Dock = DockStyle.Fill;
            panelMainForm.Location = new Point(0, 0);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(914, 480);
            panelMainForm.TabIndex = 4;
            panelMainForm.Paint += panelMainForm_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 27, 30);
            ClientSize = new Size(914, 480);
            ControlBox = false;
            Controls.Add(panelMainForm);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainForm;
    }
}