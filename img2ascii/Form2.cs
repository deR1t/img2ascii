using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WK.Libraries.HotkeyListenerNS;
using System.Windows.Input;
using Keys = System.Windows.Forms.Keys;

namespace img2ascii
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if(File.Exists(AppLocation + "ywotpath.txt"))
            {
                textBox1.Text = File.ReadAllText(AppLocation + "ywotpath.txt");
            }
        }

        public Form1 form1;
        IWebDriver driver;
        IWebElement htmlElem;
        Hotkey hkQuickBox = new Hotkey("f2");
        Hotkey hkPaste = new Hotkey("f4");
        Hotkey hkPasteFromAsciiArt = new Hotkey("f8");
        bool HotkeysAdded = false;
        bool ShowErrors = true;
        bool Cancel = false;
        string LastURL = "";
        string AppLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        QuickBoxForm quickBoxForm = new QuickBoxForm();

        private void button1_Click(object sender, EventArgs e)
        {       // Initialize YWOT button
            try
            {
                driver = new ChromeDriver(textBox1.Text);
                driver.Navigate().GoToUrl("https://www.yourworldoftext.com/dartball");
                LastURL = driver.Url;
                htmlElem = driver.FindElement(By.TagName("html"));
                if (!HotkeysAdded)
                {
                    HotkeyListener hkl = new HotkeyListener();
                    hkl.Add(hkQuickBox);
                    hkl.Add(hkPaste);
                    hkl.Add(hkPasteFromAsciiArt);
                    hkl.HotkeyPressed += Hkl_HotkeyPressed;
                    HotkeysAdded = true;
                }

                // save path to chrome driver

                if (File.Exists(AppLocation + "ywotpath.txt")) { File.Delete(AppLocation + "ywotpath.txt"); }
                var file = new FileStream(AppLocation + "ywotpath.txt", FileMode.CreateNew);
                file.Write(Encoding.UTF8.GetBytes(textBox1.Text)); // chrome driver path, i cant name variables i guess idfk.
                file.Close();
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }
        }

        private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            try
            {
                if(LastURL != driver.Url)
                {
                    htmlElem = driver.FindElement(By.TagName("html"));
                    LastURL = driver.Url;
                }

                if (e.Hotkey == hkPaste)
                {

                    string? txt = Clipboard.GetText();
                    if (txt.Length <= 0) { return; }

                    TypeChars(htmlElem, txt, (int)TextSpeedUpDown.Value);

                }

                if (e.Hotkey == hkQuickBox)
                {

                    var res = quickBoxForm.ShowDialog();
                    if( res == DialogResult.Cancel ) { return; }

                    for (int y = 0; y < quickBoxForm.YSize; y++)
                    {
                        for (int x = 0; x < quickBoxForm.XSize; x++)
                        {
                            TypeChars(htmlElem, quickBoxForm.Text, (int)TextSpeedUpDown.Value);
                            if ( ModifierKeys == (Keys.Control | Keys.Shift | Keys.Alt) ) {return;}
                            if (Cancel) { return; }
                        }
                        TypeChars(htmlElem, "\n", (int)TextSpeedUpDown.Value);
                    }

                }

                if (e.Hotkey == hkPasteFromAsciiArt)
                {
                    TypeChars(htmlElem, form1.ImageTxt.Text, (int)TextSpeedUpDown.Value);
                }
            }
            catch (Exception exception)
            {
                HandleError(exception);
                Cancel = true;
                throw;
            }

        }

        private void TypeChars(IWebElement elem, string text, int delay)
        {
            try
            {
                foreach (char character in text)
                {
                    elem.SendKeys(character.ToString());
                    if (ModifierKeys == (Keys.Control | Keys.Shift | Keys.Alt)) { return; }
                    if (Cancel) { return; }
                    Thread.Sleep(delay);
                }
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }

        }

        private void HandleError(Exception e)
        {
            if (!ShowErrors) { return; }

            StringBuilder str = new StringBuilder();
            str.Append("An error has occured!\r\n");
            str.Append(e.Message);

            str.Append("\r\n\r\nPress CANCEL to disable these messages!");

            var res = MessageBox.Show(str.ToString(), "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if(res == DialogResult.Cancel)
            {
                ShowErrors = false;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
