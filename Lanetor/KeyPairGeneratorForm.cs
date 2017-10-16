using System;
using System.Collections.Generic;
using System.Text;

namespace Lanetor
{
    public class KeyPairGeneratorForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.NumericUpDown numericUpDown1;

        //private System.Windows.Forms.Button generateKeysButton;
        //private System.Windows.Forms.NumericUpDown numericUpDown;
        //private System.Windows.Forms.PictureBox keyPictureBox;
        //private System.ComponentModel.Container components = null;

        public KeyPairGeneratorForm()
        { //InitializeComponent(); 
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
              //  if (components != null)
             //   { components.Dispose(); }
            //}
           // base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // KeyPairGeneratorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "KeyPairGeneratorForm";
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
    }
}
