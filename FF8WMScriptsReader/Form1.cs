using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FF8WMScriptsReader
{
    public partial class Form1 : Form
    {
        BytesTransformer bytesTransformer;
        string region1 = "";
        string region2 = "";
        string region3 = "";
        List<string> scriptsList;

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
            bytesTransformer.TransformString(region1, isReversedCheckBox.Checked);
            bytesTransformer.TransformString(region2, isReversedCheckBox.Checked);
            scriptsList = bytesTransformer.TransformString(region3, isReversedCheckBox.Checked);
            int scriptCounter = 0;
            foreach (string script in scriptsList)
            {
                scriptsListBox.Items.Add(scriptCounter + " " + NameIfKnown());
                scriptCounter++;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (openWmsetxxDialogue.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openWmsetxxDialogue.FileName;

            Stopwatch timer = new Stopwatch();

            
            byte[] rawBytes = File.ReadAllBytes(filename);
            

            
            region1 = BitConverter.ToString(rawBytes, 3072, 2700); // 37
            region2 = BitConverter.ToString(rawBytes, 8072, 550); // 3
            region3 = BitConverter.ToString(rawBytes, 110500, 7500); // 90

            region1 = region1.Replace("-", "");
            //bytesTransformer.TransformString(region1);

            region2 = region2.Replace("-", "");
            //bytesTransformer.TransformString(region2);

            region3 = region3.Replace("-", "");
            //bytesTransformer.TransformString(region3);
            rawBytesTextBox.Text += region1 + region2;
        }

        private void OutputTextBox_Resize(object sender, EventArgs e)
        {
            //OutputTextBox.Size = new Size(ClientSize.Width - 50, ClientSize.Height - 50);
        }

        private string NameIfKnown()
        {
            string name = "";
            if (locationsNames.Count > 0)
            {
                name = locationsNames[0];
                locationsNames.RemoveAt(0);
            }
            return name;
        }

        private void scriptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputTextBox.Text = scriptsList[scriptsListBox.SelectedIndex];
        }

        List<string> locationsNames = new List<string>()
        {
            "Shumi village",
            "Chocobo (Shumi)",
            "Chocobo Forest (Trabia continent)",
            "Trabia Garden",
            "Chocobo Forest (Trabia continent 2)",
            "Chocobo Forest (Esthar)",
            "Tomb of the Unknown King",
            "Dollet",
            "Deling",
            "Galbadia Garden (Balamb Garden broke)",
            "LD2 Forest (Timber)",
            "Balamb",
            "Balamb Garden (Left side)",
            "Balamb Garden (Right side)",
            "Trabia Canyon",
            "Missile base",
            "Prison",
            "Timber",
            "Fisherman Horizon Ragnarok",
            "FH Ragnarok (triggers only by leaving Garden)",
            "FH via Garden",
            "Esthar train station",
            "Salt lake",
            "Lunatic Pandora Laboratory",
            "Winhill Front",
            "Esthar (With cutscene)",
            "Esthar (Car)",
            "Esthar (Car)",
            "Esthar (Car)",
            "Esthar Sorceress Memorial",
            "Lunar Gate",
            "Chocobo forest (Centra North-East)",
            "Tear's point",
            "Centra Ruins",
            "Edea's house",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
            "Unnamed",
        };
    }
}
