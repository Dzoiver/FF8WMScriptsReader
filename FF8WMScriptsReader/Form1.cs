using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF8WMScriptsReader
{
    public partial class Form1 : Form
    {
        BytesTransformer bytesTransformer;
        public Form1()
        {
            InitializeComponent();
            bytesTransformer = new BytesTransformer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton(object sender, EventArgs e)
        {
            string output = bytesTransformer.Transform(rawBytesTextBox.Text, isReversedCheckBox.Checked);
            OutputTextBox.Text = output;
        }
    }
}
