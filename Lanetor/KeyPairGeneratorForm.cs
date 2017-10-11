using System;
using System.Collections.Generic;
using System.Text;

namespace Lanetor
{
    public class KeyPairGeneratorForm : System.Windows.Forms.Form
    {
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
          //  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyPairGeneratorForm));
          //  this.generateKeysButton = new System.Windows.Forms.Button();
          //  this.keyPictureBox = new System.Windows.Forms.PictureBox();
          //  this.numericUpDown = new System.Windows.Forms.NumericUpDown();
          //  ((System.ComponentModel.ISupportInitialize)(this.keyPictureBox)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
          //  this.SuspendLayout();
          //  this.generateKeysButton.BackColor = System.Drawing.SystemColors.Control;
          //  this.generateKeysButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          //  this.generateKeysButton.ForeColor = System.Drawing.SystemColors.ControlText;
          //  this.generateKeysButton.Location = new System.Drawing.Point(84, 44);
          //  this.generateKeysButton.Name = "generateKeysButton";
          //  this.generateKeysButton.Size = new System.Drawing.Size(68, 43);
          //  this.generateKeysButton.TabIndex = 0;
          //  this.generateKeysButton.Text = "Generate Keys";
          //  this.generateKeysButton.UseVisualStyleBackColor = false;
          //  this.generateKeysButton.Click += new System.EventHandler(this.generateKeysButton_Click);
          //  this.keyPictureBox.BackColor = System.Drawing.Color.Black;
          //  this.keyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.keyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("keyPictureBox.Image")));
            //this.keyPictureBox.Location = new System.Drawing.Point(12, 12);
            //this.keyPictureBox.Name = "keyPictureBox";
            //this.keyPictureBox.Size = new System.Drawing.Size(66, 75);
            //this.keyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            //this.keyPictureBox.TabIndex = 1;
            //this.keyPictureBox.TabStop = false;
            //this.numericUpDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            //this.numericUpDown.ForeColor = System.Drawing.Color.Lime;
            //this.numericUpDown.Increment = new decimal(new int[] { 8, 0, 0, 0 });
            //this.numericUpDown.Location = new System.Drawing.Point(84, 12);
            //this.numericUpDown.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            //this.numericUpDown.Minimum = new decimal(new int[] { 384, 0, 0, 0 });
            //this.numericUpDown.Name = "numericUpDown";
            //this.numericUpDown.ReadOnly = true;
            //this.numericUpDown.Size = new System.Drawing.Size(68, 26);
            //this.numericUpDown.TabIndex = 0;
            //this.numericUpDown.ThousandsSeparator = true;
            //this.numericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            //this.numericUpDown.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            //this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            //this.BackColor = System.Drawing.Color.Black;
            //this.ClientSize = new System.Drawing.Size(162, 103);
            //this.Controls.Add(this.numericUpDown);
            //this.Controls.Add(this.keyPictureBox);
            //this.Controls.Add(this.generateKeysButton);
            //this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.ForeColor = System.Drawing.Color.LightGreen;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.Name = "KeyPairGeneratorForm";
            //this.ShowInTaskbar = false;
            //this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //this.Text = "Generate Keys";
            //this.Load += new System.EventHandler(this.KeyPairGeneratorForm_Load);
            //((System.ComponentModel.ISupportInitialize)(this.keyPictureBox)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        private void generateKeysButton_Click(object sender, System.EventArgs e)
        {
          //  Lanetor.frm_home.SetBitStrength(Convert.ToInt32(numericUpDown.Value));
          //  this.DialogResult = DialogResult.OK;
            this.Dispose(true);
        }

        private void KeyPairGeneratorForm_Load(object sender, EventArgs e)
        { Lanetor.frm_home.SetBitStrength(1024); }
    }
}
