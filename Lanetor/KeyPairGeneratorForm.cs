using System;
using System.Collections.Generic;
using System.Text;

namespace Lanetor
{
    public class KeyPairGeneratorForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Button generateKeysButton;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.PictureBox keyPictureBox;
        private System.ComponentModel.Container components = null;

        public KeyPairGeneratorForm()
        { InitializeComponent(); 
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                { components.Dispose(); }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(35, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            384,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(80, 71);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "OK";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // KeyPairGeneratorForm
            // 
            this.ClientSize = new System.Drawing.Size(276, 193);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "KeyPairGeneratorForm";
            this.Load += new System.EventHandler(this.KeyPairGeneratorForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        private void generateKeysButton_Click(object sender, System.EventArgs e)
        {
           // Lanetor.frm_home.SetBitStrength(Convert.ToInt32(numericUpDown.Value));
          //  this.DialogResult = DialogResult.OK;
           // this.Dispose(true);
        }

        private void KeyPairGeneratorForm_Load(object sender, EventArgs e)
        { Lanetor.frm_home.SetBitStrength(1024); }

        private void KeyPairGeneratorForm_Load_1(object sender, EventArgs e)
        {
            ///my line(1)
            Lanetor.frm_home.SetBitStrength(1024);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Lanetor.frm_home.SetBitStrength(Convert.ToInt32(numericUpDown1.Value));
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose(true);
        }
    }
}
