
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isReversedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConverterButton
            // 
            this.ConverterButton.Location = new System.Drawing.Point(355, 12);
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
            this.rawBytesTextBox.Location = new System.Drawing.Point(12, 106);
            this.rawBytesTextBox.Multiline = true;
            this.rawBytesTextBox.Name = "rawBytesTextBox";
            this.rawBytesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rawBytesTextBox.Size = new System.Drawing.Size(365, 332);
            this.rawBytesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raw Bytes";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextBox.Location = new System.Drawing.Point(423, 106);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(365, 332);
            this.OutputTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Script viewer";
            // 
            // isReversedCheckBox
            // 
            this.isReversedCheckBox.AutoSize = true;
            this.isReversedCheckBox.Location = new System.Drawing.Point(79, 85);
            this.isReversedCheckBox.Name = "isReversedCheckBox";
            this.isReversedCheckBox.Size = new System.Drawing.Size(73, 19);
            this.isReversedCheckBox.TabIndex = 5;
            this.isReversedCheckBox.Text = "Reversed";
            this.isReversedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isReversedCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rawBytesTextBox);
            this.Controls.Add(this.ConverterButton);
            this.Name = "Form1";
            this.Text = "World Map Script Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConverterButton;
        private System.Windows.Forms.TextBox rawBytesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isReversedCheckBox;
    }
}

