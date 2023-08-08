
namespace FF8WMScriptsReader
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
            this.ConverterButton = new System.Windows.Forms.Button();
            this.rawBytesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isReversedCheckBox = new System.Windows.Forms.CheckBox();
            this.importButton = new System.Windows.Forms.Button();
            this.openWmsetxxDialogue = new System.Windows.Forms.OpenFileDialog();
            this.scriptsListBox = new System.Windows.Forms.ListBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConverterButton
            // 
            this.ConverterButton.Location = new System.Drawing.Point(158, 12);
            this.ConverterButton.Name = "ConverterButton";
            this.ConverterButton.Size = new System.Drawing.Size(75, 23);
            this.ConverterButton.TabIndex = 0;
            this.ConverterButton.Text = "Convert";
            this.ConverterButton.UseVisualStyleBackColor = true;
            this.ConverterButton.Click += new System.EventHandler(this.ConvertButton);
            // 
            // rawBytesTextBox
            // 
            this.rawBytesTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rawBytesTextBox.Location = new System.Drawing.Point(11, 62);
            this.rawBytesTextBox.Multiline = true;
            this.rawBytesTextBox.Name = "rawBytesTextBox";
            this.rawBytesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawBytesTextBox.Size = new System.Drawing.Size(140, 141);
            this.rawBytesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raw Bytes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Script viewer:";
            // 
            // isReversedCheckBox
            // 
            this.isReversedCheckBox.AutoSize = true;
            this.isReversedCheckBox.Location = new System.Drawing.Point(78, 41);
            this.isReversedCheckBox.Name = "isReversedCheckBox";
            this.isReversedCheckBox.Size = new System.Drawing.Size(73, 19);
            this.isReversedCheckBox.TabIndex = 5;
            this.isReversedCheckBox.Text = "Reversed";
            this.isReversedCheckBox.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(13, 12);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // openWmsetxxDialogue
            // 
            this.openWmsetxxDialogue.FileName = "openFileDialog1";
            // 
            // scriptsListBox
            // 
            this.scriptsListBox.FormattingEnabled = true;
            this.scriptsListBox.HorizontalScrollbar = true;
            this.scriptsListBox.ItemHeight = 15;
            this.scriptsListBox.Location = new System.Drawing.Point(157, 62);
            this.scriptsListBox.Name = "scriptsListBox";
            this.scriptsListBox.Size = new System.Drawing.Size(231, 484);
            this.scriptsListBox.TabIndex = 7;
            this.scriptsListBox.SelectedIndexChanged += new System.EventHandler(this.scriptsListBox_SelectedIndexChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextBox.Location = new System.Drawing.Point(394, 62);
            this.OutputTextBox.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.OutputTextBox.MinimumSize = new System.Drawing.Size(50, 50);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(423, 484);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.WordWrap = false;
            this.OutputTextBox.Resize += new System.EventHandler(this.OutputTextBox_Resize);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(738, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scripts List:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(829, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.scriptsListBox);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.isReversedCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rawBytesTextBox);
            this.Controls.Add(this.ConverterButton);
            this.Name = "Form1";
            this.Text = "World Map Script Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConverterButton;
        private System.Windows.Forms.TextBox rawBytesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isReversedCheckBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog openWmsetxxDialogue;
        private System.Windows.Forms.ListBox scriptsListBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

