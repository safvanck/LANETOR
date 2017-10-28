namespace Lanetor
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.processingLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Porfgdf = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.labelport = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.listPackets = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBroadcast = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(270, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Linen;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.processingLabel);
            this.panel.ForeColor = System.Drawing.Color.DarkGreen;
            this.panel.Location = new System.Drawing.Point(407, 626);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 28);
            this.panel.TabIndex = 0;
            // 
            // processingLabel
            // 
            this.processingLabel.Location = new System.Drawing.Point(8, 1);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(184, 23);
            this.processingLabel.TabIndex = 0;
            this.processingLabel.Text = "Processing please wait...";
            this.processingLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.decryptButton);
            this.panel2.Controls.Add(this.encryptButton);
            this.panel2.Controls.Add(this.inputTextBox);
            this.panel2.Location = new System.Drawing.Point(93, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 115);
            this.panel2.TabIndex = 2;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(352, 72);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 31);
            this.decryptButton.TabIndex = 2;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(352, 35);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 31);
            this.encryptButton.TabIndex = 1;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(59, 3);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(368, 26);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(93, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 111);
            this.panel3.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(214, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 0;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.Porfgdf);
            this.panel4.Controls.Add(this.textPort);
            this.panel4.Controls.Add(this.textRemotePort);
            this.panel4.Controls.Add(this.labelport);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textRemoteIP);
            this.panel4.Controls.Add(this.textIP);
            this.panel4.Controls.Add(this.buttonSend);
            this.panel4.Controls.Add(this.listPackets);
            this.panel4.Location = new System.Drawing.Point(93, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 247);
            this.panel4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 56);
            this.button4.TabIndex = 12;
            this.button4.Text = "Start to Listen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "Start to Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Porfgdf
            // 
            this.Porfgdf.AutoSize = true;
            this.Porfgdf.Location = new System.Drawing.Point(107, 60);
            this.Porfgdf.Name = "Porfgdf";
            this.Porfgdf.Size = new System.Drawing.Size(39, 18);
            this.Porfgdf.TabIndex = 10;
            this.Porfgdf.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(104, 83);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 26);
            this.textPort.TabIndex = 9;
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(107, 202);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(100, 26);
            this.textRemotePort.TabIndex = 8;
            // 
            // labelport
            // 
            this.labelport.AutoSize = true;
            this.labelport.Location = new System.Drawing.Point(104, 181);
            this.labelport.Name = "labelport";
            this.labelport.Size = new System.Drawing.Size(39, 18);
            this.labelport.TabIndex = 7;
            this.labelport.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remote IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "My";
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Location = new System.Drawing.Point(107, 152);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(100, 26);
            this.textRemoteIP.TabIndex = 4;
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(104, 27);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 26);
            this.textIP.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(408, 9);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 31);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listPackets
            // 
            this.listPackets.FormattingEnabled = true;
            this.listPackets.ItemHeight = 18;
            this.listPackets.Location = new System.Drawing.Point(222, 60);
            this.listPackets.Name = "listPackets";
            this.listPackets.Size = new System.Drawing.Size(261, 166);
            this.listPackets.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonBroadcast);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(93, 503);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 100);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Broadcast self IP";
            // 
            // buttonBroadcast
            // 
            this.buttonBroadcast.Location = new System.Drawing.Point(194, 23);
            this.buttonBroadcast.Name = "buttonBroadcast";
            this.buttonBroadcast.Size = new System.Drawing.Size(95, 58);
            this.buttonBroadcast.TabIndex = 1;
            this.buttonBroadcast.Text = "Broadcast";
            this.buttonBroadcast.UseVisualStyleBackColor = true;
            // 
            // frm_home
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 681);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_home_FormClosing);
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listPackets;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label labelport;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Porfgdf;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonBroadcast;
        private System.Windows.Forms.Label label3;
    }
}

