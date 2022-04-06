namespace img2ascii
{
    partial class QuickBoxForm
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
            this.XUpdown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.YUpdown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.XUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // XUpdown
            // 
            this.XUpdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XUpdown.Location = new System.Drawing.Point(71, 12);
            this.XUpdown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XUpdown.Name = "XUpdown";
            this.XUpdown.Size = new System.Drawing.Size(116, 23);
            this.XUpdown.TabIndex = 0;
            this.XUpdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Size";
            // 
            // YUpdown
            // 
            this.YUpdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YUpdown.Location = new System.Drawing.Point(71, 40);
            this.YUpdown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YUpdown.Name = "YUpdown";
            this.YUpdown.Size = new System.Drawing.Size(116, 23);
            this.YUpdown.TabIndex = 0;
            this.YUpdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Text";
            // 
            // TxtBox
            // 
            this.TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox.Location = new System.Drawing.Point(71, 69);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(116, 23);
            this.TxtBox.TabIndex = 2;
            this.TxtBox.Text = "A";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(72, 98);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(115, 23);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Go!";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 98);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(54, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // QuickBoxForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 128);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YUpdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XUpdown);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(10000, 167);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(189, 167);
            this.Name = "QuickBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.XUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown XUpdown;
        private Label label1;
        private NumericUpDown YUpdown;
        private Label label2;
        private Label label3;
        private TextBox TxtBox;
        private Button ConfirmButton;
        private Button CancelButton;
    }
}