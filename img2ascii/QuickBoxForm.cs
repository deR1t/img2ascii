using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img2ascii
{
    public partial class QuickBoxForm : Form
    {

        public int XSize = 0;
        public int YSize = 0;
        public string Text = " ";

        public QuickBoxForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Text = TxtBox.Text;
            XSize = (int)XUpdown.Value;
            YSize = (int)YUpdown.Value;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        // https://stackoverflow.com/questions/7301825/how-to-hide-only-the-close-x-button

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

    }
}
