using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Color = System.Drawing.Color;
using Image = SixLabors.ImageSharp.Image;
using Size = SixLabors.ImageSharp.Size;

namespace img2ascii
{
    public partial class Form1 : Form
    {

        Image<Rgba32>? LoadedImage;
        Image<Rgba32>? ImageToProcess;
        Form2 YWOTPanel = new Form2();

        public Form1()
        {
            InitializeComponent();
            YWOTPanel.form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageTxt.WordWrap = false;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenImageDiag.FileName = "";
            OpenImageDiag.ShowDialog();
            ProcessImage();
        }

        private void OpenImageDiag_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel) { return; }

            try
            {
                LoadedImage = Image.Load<Rgba32>(OpenImageDiag.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ProcessImage();
        }

        private void ProcessImage()
        {

            var Palette = PaletteTxt.Text;
            if (Palette.Length == 0) { return; }
            if (LoadedImage == null) { return; }

            StringBuilder art = new StringBuilder();
            ImageToProcess = LoadedImage.Clone();
            
            if(CheckAbsolute.Checked)
            {
                if (YUpDown.Value <= 0 || XUpDown.Value <= 0)
                {
                    return;
                }
                ImageToProcess.Mutate(ctx => 
                    ctx.Resize(new Size((int)XUpDown.Value, (int)YUpDown.Value)));
            }
            else
            {
                ImageToProcess.Mutate(ctx => 
                    ctx.Resize(new Size((int)(LoadedImage.Width * XUpDown.Value / 100), (int)(LoadedImage.Height * YUpDown.Value / 100))));
            }

            if (InvertBox.Checked)
            {
                ImageTxt.ForeColor = Color.Black;
                ImageTxt.BackColor = Color.White;
                ImageToProcess.Mutate(ctx => ctx.Invert());
            }
            else
            {
                ImageTxt.ForeColor = Color.White;
                ImageTxt.BackColor = Color.Black;
            }

            //ImageToProcess.Mutate(ctx => ctx.Hue(HueSlider.Value));
            ImageToProcess.Mutate(ctx => ctx.Grayscale());
            ImageToProcess.Mutate(ctx => ctx.Brightness((float)BrightnessSlider.Value / 100f));
            ImageToProcess.Mutate(ctx => ctx.Contrast((float)ContrastSlider.Value / 100f));

            //ImageToProcess.Mutate(ctx => ctx.BlackWhite());
            //ImageToProcess.Mutate(ctx => ctx.AdaptiveThreshold());

            ImageToProcess.ProcessPixelRows(access =>
            {
                for (int y = 0; y < access.Height; y++)
                {

                    Span<Rgba32> Row = access.GetRowSpan(y);

                    for (int x = 0; x < Row.Length; x++)
                    {

                        var curPix = Row[x];

                        var paletteNum = (int) ( Math.Round(((float)curPix.R / 255f) * Palette.Length) * ((float)curPix.A / 255f));
                        paletteNum = Math.Clamp(paletteNum, 0, Palette.Length - 1);

                        art.Append(Palette[paletteNum]);

                    }
                    art.Append("\r\n");
                }
                ImageTxt.Text = art.ToString();
            });

        }

        private void PaletteTxt_TextChanged(object sender, EventArgs e) { ProcessImage(); }
        private void XUpDown_ValueChanged(object sender, EventArgs e) { ProcessImage(); }
        private void YUpDown_ValueChanged(object sender, EventArgs e) { ProcessImage(); }
        private void InvertBox_CheckedChanged(object sender, EventArgs e) { ProcessImage(); }
        private void HueSlider_Scroll(object sender, EventArgs e) { ProcessImage(); }
        private void ContrastSlider_ValueChanged(object sender, EventArgs e) { ProcessImage(); }
        private void trackBar1_ValueChanged(object sender, EventArgs e) { ProcessImage(); }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ImageTxt.Font = new Font("Cascadia Code", (float)FontSizeUpDown.Value);
        }


        private void ContrastSlider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                ContrastSlider.Value = 100;
            }
        }
        private void BrightnessSlider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                BrightnessSlider.Value = 100;
            }
        }

        private void LoadPalFileButton_Click(object sender, EventArgs e)
        {
            var loc = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\palettes";
            if (!Directory.Exists(loc))
            {
                Directory.CreateDirectory(loc);
            }
            LoadPalDiag.InitialDirectory = loc;
            LoadPalDiag.FileName = "";
            LoadPalDiag.ShowDialog();
            
        }

        private void SavePalButton_Click(object sender, EventArgs e)
        {

            var loc = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\palettes";
            if (!Directory.Exists(loc) )
            {
                Directory.CreateDirectory(loc);
            }

            SavePalDiag.InitialDirectory = loc;
            SavePalDiag.FileName = "new_palette.pal";
            SavePalDiag.ShowDialog();

        }

        private void LoadPalDiag_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PaletteTxt.Text = File.ReadAllText(LoadPalDiag.FileName);
        }

        private void SavePalDiag_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var file = SavePalDiag.OpenFile();
            file.Write(Encoding.UTF8.GetBytes(PaletteTxt.Text));
            file.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the program.
            Environment.Exit(0);
        }

        private void yWOTOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YWOTPanel.Show();
        }
    }
}