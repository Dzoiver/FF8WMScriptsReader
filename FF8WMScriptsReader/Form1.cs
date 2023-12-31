﻿using System;
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
        Scripts scripts = new Scripts();

        public Form1()
        {
            InitializeComponent();
            bytesTransformer = new BytesTransformer();
        }

        private void ConvertButton(object sender, EventArgs e)
        {
            bytesTransformer.TransformString(region1, false);
            bytesTransformer.TransformString(region2, false);
            scriptsList = bytesTransformer.TransformString(region3, false);
            int scriptCounter = 0;
            string outputText = "";
            foreach (string script in scriptsList)
            {
                scriptsListBox.Items.Add(scriptCounter + " " + NameIfKnown());
                outputText += scriptsList[scriptCounter];
                scriptCounter++;
            }
            OutputTextBox.Text = outputText;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (openWmsetxxDialogue.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openWmsetxxDialogue.FileName;
            byte[] rawBytes = File.ReadAllBytes(filename);
            
            region1 = BitConverter.ToString(rawBytes, 3072, 2550); // 37
            region2 = BitConverter.ToString(rawBytes, 8400, 200); // 3
            region3 = BitConverter.ToString(rawBytes, 110850, 6750); // 90
            
            region1 = region1.Replace("-", "");
            region2 = region2.Replace("-", "");
            region3 = region3.Replace("-", "");
        }
        private string NameIfKnown()
        {
            string name = "";
            if (scripts.Names.Count > 0)
            {
                name = scripts.Names[0];
                scripts.Names.RemoveAt(0);
            }
            return name;
        }

        private void scriptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputTextBox.Text = scriptsList[scriptsListBox.SelectedIndex];
        }

        private void OutputTextBox_Resize(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
