﻿namespace img2ascii
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaletteTxt = new System.Windows.Forms.TextBox();
            this.ImageTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadPalFileButton = new System.Windows.Forms.Button();
            this.SavePalButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.ContrastSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenImageDiag = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.XUpDown = new System.Windows.Forms.NumericUpDown();
            this.YUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckAbsolute = new System.Windows.Forms.CheckBox();
            this.InvertBox = new System.Windows.Forms.CheckBox();
            this.SavePalDiag = new System.Windows.Forms.SaveFileDialog();
            this.LoadPalDiag = new System.Windows.Forms.OpenFileDialog();
            this.BrightnessSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yWOTOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSizeUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessSlider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PaletteTxt
            // 
            this.PaletteTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaletteTxt.Location = new System.Drawing.Point(102, 333);
            this.PaletteTxt.Multiline = true;
            this.PaletteTxt.Name = "PaletteTxt";
            this.PaletteTxt.Size = new System.Drawing.Size(202, 67);
            this.PaletteTxt.TabIndex = 0;
            this.PaletteTxt.Text = " ░▒▓█";
            this.PaletteTxt.TextChanged += new System.EventHandler(this.PaletteTxt_TextChanged);
            // 
            // ImageTxt
            // 
            this.ImageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageTxt.BackColor = System.Drawing.Color.Black;
            this.ImageTxt.Font = new System.Drawing.Font("Cascadia Code", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageTxt.ForeColor = System.Drawing.Color.White;
            this.ImageTxt.HideSelection = false;
            this.ImageTxt.Location = new System.Drawing.Point(310, 28);
            this.ImageTxt.MaxLength = 1000000000;
            this.ImageTxt.Multiline = true;
            this.ImageTxt.Name = "ImageTxt";
            this.ImageTxt.ReadOnly = true;
            this.ImageTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ImageTxt.Size = new System.Drawing.Size(323, 372);
            this.ImageTxt.TabIndex = 1;
            this.ImageTxt.Text = "Load an image to see some magic!";
            this.ImageTxt.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palette";
            // 
            // LoadPalFileButton
            // 
            this.LoadPalFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadPalFileButton.Location = new System.Drawing.Point(12, 348);
            this.LoadPalFileButton.Name = "LoadPalFileButton";
            this.LoadPalFileButton.Size = new System.Drawing.Size(75, 23);
            this.LoadPalFileButton.TabIndex = 3;
            this.LoadPalFileButton.Text = "Load File";
            this.LoadPalFileButton.UseVisualStyleBackColor = true;
            this.LoadPalFileButton.Click += new System.EventHandler(this.LoadPalFileButton_Click);
            // 
            // SavePalButton
            // 
            this.SavePalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePalButton.Location = new System.Drawing.Point(12, 377);
            this.SavePalButton.Name = "SavePalButton";
            this.SavePalButton.Size = new System.Drawing.Size(75, 23);
            this.SavePalButton.TabIndex = 3;
            this.SavePalButton.Text = "Save File";
            this.SavePalButton.UseVisualStyleBackColor = true;
            this.SavePalButton.Click += new System.EventHandler(this.SavePalButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.BackColor = System.Drawing.SystemColors.Info;
            this.LoadImageButton.Location = new System.Drawing.Point(210, 28);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(94, 23);
            this.LoadImageButton.TabIndex = 4;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // ContrastSlider
            // 
            this.ContrastSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContrastSlider.LargeChange = 10;
            this.ContrastSlider.Location = new System.Drawing.Point(12, 282);
            this.ContrastSlider.Maximum = 400;
            this.ContrastSlider.Name = "ContrastSlider";
            this.ContrastSlider.Size = new System.Drawing.Size(292, 45);
            this.ContrastSlider.SmallChange = 2;
            this.ContrastSlider.TabIndex = 5;
            this.ContrastSlider.Value = 100;
            this.ContrastSlider.ValueChanged += new System.EventHandler(this.ContrastSlider_ValueChanged);
            this.ContrastSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContrastSlider_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contrast";
            // 
            // OpenImageDiag
            // 
            this.OpenImageDiag.FileName = "OpenImage";
            this.OpenImageDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenImageDiag_FileOk);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "X Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y Size";
            // 
            // XUpDown
            // 
            this.XUpDown.DecimalPlaces = 2;
            this.XUpDown.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.XUpDown.Location = new System.Drawing.Point(51, 30);
            this.XUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.XUpDown.Name = "XUpDown";
            this.XUpDown.Size = new System.Drawing.Size(72, 23);
            this.XUpDown.TabIndex = 8;
            this.XUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.XUpDown.ValueChanged += new System.EventHandler(this.XUpDown_ValueChanged);
            // 
            // YUpDown
            // 
            this.YUpDown.DecimalPlaces = 2;
            this.YUpDown.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.YUpDown.Location = new System.Drawing.Point(51, 59);
            this.YUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.YUpDown.Name = "YUpDown";
            this.YUpDown.Size = new System.Drawing.Size(72, 23);
            this.YUpDown.TabIndex = 8;
            this.YUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.YUpDown.ValueChanged += new System.EventHandler(this.YUpDown_ValueChanged);
            // 
            // CheckAbsolute
            // 
            this.CheckAbsolute.AutoSize = true;
            this.CheckAbsolute.Location = new System.Drawing.Point(8, 88);
            this.CheckAbsolute.Name = "CheckAbsolute";
            this.CheckAbsolute.Size = new System.Drawing.Size(73, 19);
            this.CheckAbsolute.TabIndex = 9;
            this.CheckAbsolute.Text = "Absolute";
            this.CheckAbsolute.UseVisualStyleBackColor = true;
            // 
            // InvertBox
            // 
            this.InvertBox.AutoSize = true;
            this.InvertBox.Location = new System.Drawing.Point(8, 113);
            this.InvertBox.Name = "InvertBox";
            this.InvertBox.Size = new System.Drawing.Size(96, 19);
            this.InvertBox.TabIndex = 9;
            this.InvertBox.Text = "Invert Picture";
            this.InvertBox.UseVisualStyleBackColor = true;
            this.InvertBox.CheckedChanged += new System.EventHandler(this.InvertBox_CheckedChanged);
            // 
            // SavePalDiag
            // 
            this.SavePalDiag.FileName = "new_palette.pal";
            this.SavePalDiag.InitialDirectory = "/palettes";
            this.SavePalDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.SavePalDiag_FileOk);
            // 
            // LoadPalDiag
            // 
            this.LoadPalDiag.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadPalDiag_FileOk);
            // 
            // BrightnessSlider
            // 
            this.BrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrightnessSlider.LargeChange = 10;
            this.BrightnessSlider.Location = new System.Drawing.Point(12, 234);
            this.BrightnessSlider.Maximum = 400;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(292, 45);
            this.BrightnessSlider.SmallChange = 2;
            this.BrightnessSlider.TabIndex = 5;
            this.BrightnessSlider.Value = 100;
            this.BrightnessSlider.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.BrightnessSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrightnessSlider_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brightness";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yWOTOptionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // yWOTOptionsToolStripMenuItem
            // 
            this.yWOTOptionsToolStripMenuItem.Name = "yWOTOptionsToolStripMenuItem";
            this.yWOTOptionsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.yWOTOptionsToolStripMenuItem.Text = "YWOT Options...";
            this.yWOTOptionsToolStripMenuItem.Click += new System.EventHandler(this.yWOTOptionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FontSizeUpDown
            // 
            this.FontSizeUpDown.DecimalPlaces = 1;
            this.FontSizeUpDown.Location = new System.Drawing.Point(210, 59);
            this.FontSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FontSizeUpDown.Name = "FontSizeUpDown";
            this.FontSizeUpDown.Size = new System.Drawing.Size(94, 23);
            this.FontSizeUpDown.TabIndex = 11;
            this.FontSizeUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.FontSizeUpDown.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 412);
            this.Controls.Add(this.FontSizeUpDown);
            this.Controls.Add(this.InvertBox);
            this.Controls.Add(this.CheckAbsolute);
            this.Controls.Add(this.YUpDown);
            this.Controls.Add(this.XUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.ContrastSlider);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.SavePalButton);
            this.Controls.Add(this.LoadPalFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageTxt);
            this.Controls.Add(this.PaletteTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(661, 451);
            this.Name = "Form1";
            this.Text = "text2ascii";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContrastSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessSlider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PaletteTxt;
        private Label label1;
        private Button LoadPalFileButton;
        private Button SavePalButton;
        private Button LoadImageButton;
        private TrackBar ContrastSlider;
        private Label label2;
        private OpenFileDialog OpenImageDiag;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown XUpDown;
        private NumericUpDown YUpDown;
        private CheckBox CheckAbsolute;
        private CheckBox InvertBox;
        private SaveFileDialog SavePalDiag;
        private OpenFileDialog LoadPalDiag;
        private TrackBar BrightnessSlider;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem yWOTOptionsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        public TextBox ImageTxt;
        private NumericUpDown FontSizeUpDown;
    }
}