namespace img2ascii
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
            this.FontSizeBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.XUpDown = new System.Windows.Forms.NumericUpDown();
            this.YUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckAbsolute = new System.Windows.Forms.CheckBox();
            this.InvertBox = new System.Windows.Forms.CheckBox();
            this.HueSlider = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.SavePalDiag = new System.Windows.Forms.SaveFileDialog();
            this.LoadPalDiag = new System.Windows.Forms.OpenFileDialog();
            this.BrightnessSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessSlider)).BeginInit();
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
            this.ImageTxt.Font = new System.Drawing.Font("Cascadia Code", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageTxt.ForeColor = System.Drawing.Color.White;
            this.ImageTxt.HideSelection = false;
            this.ImageTxt.Location = new System.Drawing.Point(310, 12);
            this.ImageTxt.MaxLength = 1000000000;
            this.ImageTxt.Multiline = true;
            this.ImageTxt.Name = "ImageTxt";
            this.ImageTxt.ReadOnly = true;
            this.ImageTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ImageTxt.Size = new System.Drawing.Size(323, 388);
            this.ImageTxt.TabIndex = 1;
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
            this.LoadImageButton.Location = new System.Drawing.Point(210, 12);
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
            this.ContrastSlider.Location = new System.Drawing.Point(200, 282);
            this.ContrastSlider.Maximum = 400;
            this.ContrastSlider.Name = "ContrastSlider";
            this.ContrastSlider.Size = new System.Drawing.Size(104, 45);
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
            this.label2.Location = new System.Drawing.Point(225, 312);
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
            // FontSizeBar
            // 
            this.FontSizeBar.LargeChange = 1;
            this.FontSizeBar.Location = new System.Drawing.Point(200, 41);
            this.FontSizeBar.Maximum = 20;
            this.FontSizeBar.Minimum = 1;
            this.FontSizeBar.Name = "FontSizeBar";
            this.FontSizeBar.Size = new System.Drawing.Size(104, 45);
            this.FontSizeBar.TabIndex = 5;
            this.FontSizeBar.Value = 7;
            this.FontSizeBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "X Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y Size";
            // 
            // XUpDown
            // 
            this.XUpDown.DecimalPlaces = 2;
            this.XUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.XUpDown.Location = new System.Drawing.Point(55, 7);
            this.XUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.XUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.XUpDown.Name = "XUpDown";
            this.XUpDown.Size = new System.Drawing.Size(72, 23);
            this.XUpDown.TabIndex = 8;
            this.XUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XUpDown.ValueChanged += new System.EventHandler(this.XUpDown_ValueChanged);
            // 
            // YUpDown
            // 
            this.YUpDown.DecimalPlaces = 2;
            this.YUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.YUpDown.Location = new System.Drawing.Point(55, 36);
            this.YUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.YUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.YUpDown.Name = "YUpDown";
            this.YUpDown.Size = new System.Drawing.Size(72, 23);
            this.YUpDown.TabIndex = 8;
            this.YUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.YUpDown.ValueChanged += new System.EventHandler(this.YUpDown_ValueChanged);
            // 
            // CheckAbsolute
            // 
            this.CheckAbsolute.AutoSize = true;
            this.CheckAbsolute.Location = new System.Drawing.Point(12, 65);
            this.CheckAbsolute.Name = "CheckAbsolute";
            this.CheckAbsolute.Size = new System.Drawing.Size(73, 19);
            this.CheckAbsolute.TabIndex = 9;
            this.CheckAbsolute.Text = "Absolute";
            this.CheckAbsolute.UseVisualStyleBackColor = true;
            // 
            // InvertBox
            // 
            this.InvertBox.AutoSize = true;
            this.InvertBox.Location = new System.Drawing.Point(12, 90);
            this.InvertBox.Name = "InvertBox";
            this.InvertBox.Size = new System.Drawing.Size(96, 19);
            this.InvertBox.TabIndex = 9;
            this.InvertBox.Text = "Invert Picture";
            this.InvertBox.UseVisualStyleBackColor = true;
            this.InvertBox.CheckedChanged += new System.EventHandler(this.InvertBox_CheckedChanged);
            // 
            // HueSlider
            // 
            this.HueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HueSlider.LargeChange = 30;
            this.HueSlider.Location = new System.Drawing.Point(200, 183);
            this.HueSlider.Maximum = 360;
            this.HueSlider.Name = "HueSlider";
            this.HueSlider.Size = new System.Drawing.Size(104, 45);
            this.HueSlider.TabIndex = 5;
            this.HueSlider.Scroll += new System.EventHandler(this.HueSlider_Scroll);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hue Shifter";
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
            this.BrightnessSlider.Location = new System.Drawing.Point(200, 234);
            this.BrightnessSlider.Maximum = 400;
            this.BrightnessSlider.Name = "BrightnessSlider";
            this.BrightnessSlider.Size = new System.Drawing.Size(104, 45);
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
            this.label3.Location = new System.Drawing.Point(225, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brightness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 412);
            this.Controls.Add(this.InvertBox);
            this.Controls.Add(this.CheckAbsolute);
            this.Controls.Add(this.YUpDown);
            this.Controls.Add(this.XUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HueSlider);
            this.Controls.Add(this.FontSizeBar);
            this.Controls.Add(this.BrightnessSlider);
            this.Controls.Add(this.ContrastSlider);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.SavePalButton);
            this.Controls.Add(this.LoadPalFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageTxt);
            this.Controls.Add(this.PaletteTxt);
            this.MinimumSize = new System.Drawing.Size(661, 451);
            this.Name = "Form1";
            this.Text = "text2ascii";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContrastSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PaletteTxt;
        private TextBox ImageTxt;
        private Label label1;
        private Button LoadPalFileButton;
        private Button SavePalButton;
        private Button LoadImageButton;
        private TrackBar ContrastSlider;
        private Label label2;
        private OpenFileDialog OpenImageDiag;
        private TrackBar FontSizeBar;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown XUpDown;
        private NumericUpDown YUpDown;
        private CheckBox CheckAbsolute;
        private CheckBox InvertBox;
        private TrackBar HueSlider;
        private Label label7;
        private SaveFileDialog SavePalDiag;
        private OpenFileDialog LoadPalDiag;
        private TrackBar BrightnessSlider;
        private Label label3;
    }
}