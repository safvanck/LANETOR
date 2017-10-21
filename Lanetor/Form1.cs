using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading;

//using System.Xml.Serialization;
namespace Lanetor
{
    public partial class frm_home : Form
    {

        private IContainer components;
        private Label processingLabel;
        private OpenFileDialog openFileDialog;
        private Panel panel;
        private SaveFileDialog saveFileDialog;

        public static int currentBitStrength = 0;
        private bool cleanForm = true;
        private string currentFileName = "Untitled";

        public delegate void FinishedProcessDelegate();
        public delegate void UpdateBitStrengthDelegate(int bitStrength);
        public delegate void UpdateTextDelegate(string inputText);

        EncryptionThread encrypThread = new EncryptionThread();

        public frm_home( string fileName )
		{
			InitializeComponent();
			if( File.Exists( fileName ) )
			{
				currentFileName = fileName;
				StreamReader streamReader = new StreamReader( fileName, true );
				SetText( streamReader.ReadToEnd() );
				streamReader.Close();				
				this.Text = GetFileName( fileName ) + " - Lanetor";
				cleanForm = true;
			}
		}
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            if (args.Length > 0)
            { Application.Run(new frm_home(args[0])); }
            else
            { Application.Run(new frm_home()); }
        }

        private void FinishedProcess()
        {
            panel.Visible = false;
            
            Application.DoEvents();
        }

        public static void SetBitStrength(int bitStrength)
        { currentBitStrength = bitStrength; }

        private void UpdateText(string inputText)
        { inputTextBox.Text = inputText; }

        private string GetFileName(string fileName)
        {
            string[] fileParts = fileName.Split("\\".ToCharArray());
            return fileParts[fileParts.Length - 1];
        }

        private void SetText(string text)
        {
            this.inputTextBox.TextChanged -= new System.EventHandler(this.inputTextBox_TextChanged);
            inputTextBox.Text = text;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
        }

        private Settings GetSettings()
        {
            Settings settings = null;
            if (File.Exists("Settings.bin"))
            {
                StreamReader streamReader = new StreamReader("Settings.bin");
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                settings = (Settings)binaryFormatter.Deserialize(streamReader.BaseStream);
                streamReader.Close();
            }
            return settings;
        }

        private void SaveSettings(string settingChanged)
        {
            Settings settings = new Settings();
            if (File.Exists("Settings.bin"))
            {
                StreamReader streamReader = new StreamReader("Settings.bin");
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                settings = (Settings)binaryFormatter.Deserialize(streamReader.BaseStream);
                streamReader.Close();
                switch (settingChanged)
                {
                    case "LOCATION":
                        {
                            settings.Location = this.Location;
                            break;
                        }
                    case "SIZE":
                        {
                            settings.Width = this.Width;
                            settings.Height = this.Height;
                            break;
                        }
                    case "FONT":
                        {
                            settings.Font = inputTextBox.Font;
                            break;
                        }
                    case "WRAPPING":
                        {
                            settings.Wrapping = inputTextBox.WordWrap;
                            break;
                        }
                }
                StreamWriter streamWriter = new StreamWriter("Settings.bin", false);
                binaryFormatter.Serialize(streamWriter.BaseStream, settings);
                streamWriter.Close();
            }
            else
            {
                settings.Location = this.Location;
                settings.Width = this.Width;
                settings.Height = this.Height;
                settings.Font = inputTextBox.Font;
                settings.Wrapping = inputTextBox.WordWrap;
                StreamWriter streamWriter = new StreamWriter("Settings.bin", false);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(streamWriter.BaseStream, settings);
                streamWriter.Close();
            }
        }

        private string openFile(string title, string filterString)
        {
            openFileDialog.FileName = "";
            openFileDialog.Title = title;
            openFileDialog.Filter = filterString;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    StreamReader streamReader = new StreamReader(openFileDialog.FileName, true);
                    string fileString = streamReader.ReadToEnd();
                    streamReader.Close();
                    if (fileString.Length >= inputTextBox.MaxLength)
                    {
                        MessageBox.Show("ERROR: \nThe file you are trying to open is too big for the text editor to display properly.\nPlease open a smaller document!\nOperation Aborted!");
                        return null;
                    }
                    if (fileString != null)
                    {
                        this.Text = GetFileName(openFileDialog.FileName) + " - Lanetor";
                        currentFileName = openFileDialog.FileName;
                    }
                    return fileString;
                }
            }
            return null;
        }

        private bool saveFile()
        {
            saveFileDialog.Title = "Save As";
            saveFileDialog.FileName = "*.txt";
            saveFileDialog.Filter = "Text Document( *.txt )|*.txt|All Files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false);
                    streamWriter.Write(inputTextBox.Text);
                    streamWriter.Close();
                    this.Text = GetFileName(saveFileDialog.FileName) + " - Lanetor";
                    currentFileName = saveFileDialog.FileName;
                    return true;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return false;
                }
            }
            return false;
        }

        private bool saveFile(string title, string filterString, string outputString)
        {
            saveFileDialog.Title = title;
            saveFileDialog.Filter = filterString;
            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false);
                    if (outputString != null)
                    { streamWriter.Write(outputString); }
                    streamWriter.Close();
                    return true;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return false;
                }
            }
            return false;
        }

            
        public frm_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: after creating host network and its port


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: after creating host network and its port


        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            if (File.Exists("Settings.bin"))
            {
                Settings settings = GetSettings();
                this.Location = settings.Location;
                this.Width = settings.Width;
                this.Height = settings.Height;
                inputTextBox.Font = settings.Font;
                inputTextBox.WordWrap = settings.Wrapping;
                
            }
            this.Text = GetFileName(currentFileName) + " - Lanetor";
            inputTextBox.Focus();
          
        }

        private void frm_home_Resize(object sender, EventArgs e)
        {
        
        }

        private void frm_home_Move(object sender, EventArgs e)
        {
            SaveSettings("LOCATION");
        }

        private void frm_home_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!cleanForm)
            {
                string dialogText = "The text in the " + currentFileName + " file has changed." + Environment.NewLine + Environment.NewLine + "Do you want to save the changes?";
                switch (MessageBox.Show(dialogText, "Lanetor", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        {
                            if (!saveFile()) { e.Cancel = true; }
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                }
            }
        }


        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (!cleanForm)
            {
                string dialogText = "The text in the " + currentFileName + " file has changed." + Environment.NewLine + Environment.NewLine + "Do you want to save the changes?";
                switch (MessageBox.Show(dialogText, "Lanetor", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        {
                            if (saveFile()) { Dispose(true); }
                            break;
                        }
                    case DialogResult.No:
                        {
                            Dispose(true);
                            break;
                        }
                    case DialogResult.Cancel:
                        { break; }
                    default:
                        { break; }
                }
            }
            else
            { Dispose(true); }
        }



        private void decryptMenuItem_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length != 0)
            {
                openFileDialog.FileName = "";
                openFileDialog.Title = "Open Private Key File";
                openFileDialog.Filter = "Private Key Document( *.kez )|*.kez";
                string fileString = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        StreamReader streamReader = new StreamReader(openFileDialog.FileName, true);
                        fileString = streamReader.ReadToEnd();
                        streamReader.Close();
                        if (fileString.Length >= inputTextBox.MaxLength)
                        { MessageBox.Show("ERROR: \nThe file you are trying to open is too big for the text editor to display properly.\nPlease open a smaller document!\nOperation Aborted!"); }
                    }
                }
                if (File.Exists(openFileDialog.FileName))
                {
                    string bitStrengthString = fileString.Substring(0, fileString.IndexOf("</BitStrength>") + 14);
                    fileString = fileString.Replace(bitStrengthString, "");
                    int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));
                    Point point = new Point((inputTextBox.Size.Width / 2) - (panel.Size.Width / 2), (inputTextBox.Size.Height / 2) - (panel.Size.Height / 2));
                    panel.Location = point;
                    panel.Visible = true;
                    this.Refresh();
//filemenudisable code omited
                    string tempStorage = inputTextBox.Text;
                    if (fileString != null)
                    {
                        FinishedProcessDelegate finishedProcessDelegate = new FinishedProcessDelegate(FinishedProcess);
                        UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateText);
                        try
                        {
                            EncryptionThread decryptionThread = new EncryptionThread();
                            Thread decryptThread = new Thread(decryptionThread.Decrypt);
                            decryptThread.IsBackground = true;
                            decryptThread.Start(new Object[] { this, finishedProcessDelegate, updateTextDelegate, inputTextBox.Text, bitStrength, fileString });
                        }
                        catch (CryptographicException CEx)
                        { MessageBox.Show("ERROR: \nOne of the following has occured.\nThe cryptographic service provider cannot be acquired.\nThe length of the text being encrypted is greater than the maximum allowed length.\nThe OAEP padding is not supported on this computer.\n" + "Exact error: " + CEx.Message); }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("ERROR:\n" + Ex.Message);
                            SetText(tempStorage);
                        }
                    }
                }
            }
            else
            { MessageBox.Show("ERROR: You Can Not Decrypt A NULL Value!!!"); }
        }

        private void encryptMenuItem_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length != 0)
            {
                openFileDialog.FileName = "";
                openFileDialog.Title = "Open Public Key File";
                openFileDialog.Filter = "Public Key Document( *.pke )|*.pke";
                string fileString = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        StreamReader streamReader = new StreamReader(openFileDialog.FileName, true);
                        fileString = streamReader.ReadToEnd();
                        streamReader.Close();
                        if (fileString.Length >= inputTextBox.MaxLength)
                        { MessageBox.Show("ERROR: \nThe file you are trying to open is too big for the text editor to display properly.\nPlease open a smaller document!\nOperation Aborted!"); }
                    }
                }
                if (fileString != null)
                {
                    FinishedProcessDelegate finishedProcessDelegate = new FinishedProcessDelegate(FinishedProcess);
                    UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateText);
                    string bitStrengthString = fileString.Substring(0, fileString.IndexOf("</BitStrength>") + 14);
                    fileString = fileString.Replace(bitStrengthString, "");
                    int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));
                    Point point = new Point((inputTextBox.Size.Width / 2) - (panel.Size.Width / 2), (inputTextBox.Size.Height / 2) - (panel.Size.Height / 2));
                    panel.Location = point;
                    panel.Visible = true;
                    this.Refresh();
                    //filemenudisable code omited
                    if (fileString != null)
                    {
                        try
                        {
                            EncryptionThread encryptionThread = new EncryptionThread();
                            Thread encryptThread = new Thread(encryptionThread.Encrypt);
                            encryptThread.IsBackground = true;
                            encryptThread.Start(new Object[] { this, finishedProcessDelegate, updateTextDelegate, inputTextBox.Text, bitStrength, fileString });
                        }
                        catch (CryptographicException CEx)
                        { MessageBox.Show("ERROR: \nOne of the following has occured.\nThe cryptographic service provider cannot be acquired.\nThe length of the text being encrypted is greater than the maximum allowed length.\nThe OAEP padding is not supported on this computer.\n" + "Exact error: " + CEx.Message); }
                        catch (Exception Ex)
                        { MessageBox.Show("ERROR: \n" + Ex.Message); }
                    }
                }
            }
            else
            { MessageBox.Show("ERROR: You Can Not Encrypt A NULL Value!!!"); }
        }

        private void generateKeyPairMenuItem_Click(object sender, EventArgs e)
        {
            KeyPairGeneratorForm generator = new KeyPairGeneratorForm();
            if (generator.ShowDialog() == DialogResult.OK)
            {
                RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider(currentBitStrength);
                string publicAndPrivateKeys = "<BitStrength>" + currentBitStrength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(true);
                string justPublicKey = "<BitStrength>" + currentBitStrength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(false);
                if (saveFile("Save Private Keys As", "Lanetor Private Key( *.kez )|*.kez", publicAndPrivateKeys))
                { while (!saveFile("Save Public Key As", "Lanetor Public Key( *.pke )|*.pke", justPublicKey)) { ; } }
            }
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (currentFileName.Equals("Lanetor***"))
            { cleanForm = (!inputTextBox.Text.Equals("")) ? false : true; }
            else
            { cleanForm = false; }
        }


        private void inputTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void inputTextBox_DragDrop(object sender, DragEventArgs e)
        {
            bool clean = false;
            if (!cleanForm)
            {
                string dialogText = "The text in the " + currentFileName + " file has changed." + Environment.NewLine + Environment.NewLine + "Do you want to save the changes?";
                switch (MessageBox.Show(dialogText, "Lanetor", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        {
                            if (saveFile()) { clean = true; }
                            break;
                        }
                    case DialogResult.No:
                        {
                            clean = true;
                            break;
                        }
                }
            }
            else
            { clean = true; }
            if (clean)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop, true) == true)
                {
                    string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                    StreamReader streamReader = new StreamReader(fileNames[0], true);
                    string fileContents = streamReader.ReadToEnd();
                    streamReader.Close();
                    currentFileName = fileNames[0];
                    this.Text = GetFileName(fileNames[0]) + " - Lanetor";
                    SetText(fileContents);
                    cleanForm = true;
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //input the number from list
            //key generate
            //save keys (public key: just show saving.. private: save as file)
            //share public key (just show/inform sharing and make available to every1)
            KeyPairGeneratorForm generator = new KeyPairGeneratorForm();
            if (generator.ShowDialog() == DialogResult.OK)
            {
                RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider(currentBitStrength);
                string publicAndPrivateKeys = "<BitStrength>" + currentBitStrength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(true);
                string justPublicKey = "<BitStrength>" + currentBitStrength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(false);
                if (saveFile("Save Public/Private Keys As", "Public/Private Keys Document( *.kez )|*.kez", publicAndPrivateKeys))
                { while (!saveFile("Save Public Key As", "Public Key Document( *.pke )|*.pke", justPublicKey)) {; } }
            }
        }



        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length != 0)
            {
                openFileDialog.FileName = "";
                openFileDialog.Title = "Open Public Key File";
                openFileDialog.Filter = "Public Key Document( *.pke )|*.pke";
                string fileString = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        StreamReader streamReader = new StreamReader(openFileDialog.FileName, true);
                        fileString = streamReader.ReadToEnd();
                        streamReader.Close();
                        if (fileString.Length >= inputTextBox.MaxLength)
                        { MessageBox.Show("ERROR: \nThe file you are trying to open is too big for the text editor to display properly.\nPlease open a smaller document!\nOperation Aborted!"); }
                    }
                }
                if (fileString != null)
                {
                    FinishedProcessDelegate finishedProcessDelegate = new FinishedProcessDelegate(FinishedProcess);
                    UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateText);
                    string bitStrengthString = fileString.Substring(0, fileString.IndexOf("</BitStrength>") + 14);
                    fileString = fileString.Replace(bitStrengthString, "");
                    int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));
                    Point point = new Point((inputTextBox.Size.Width / 2) - (panel.Size.Width / 2), (inputTextBox.Size.Height / 2) - (panel.Size.Height / 2));
                    panel.Location = point;
                    panel.Visible = true;
                    this.Refresh();
                    //filemenus disabled code omitted
                    if (fileString != null)
                    {
                        try
                        {
                            EncryptionThread encryptionThread = new EncryptionThread();
                            Thread encryptThread = new Thread(encryptionThread.Encrypt);
                            encryptThread.IsBackground = true;
                            encryptThread.Start(new Object[] { this, finishedProcessDelegate, updateTextDelegate, inputTextBox.Text, bitStrength, fileString });
                        }
                        catch (CryptographicException CEx)
                        { MessageBox.Show("ERROR: \nOne of the following has occured.\nThe cryptographic service provider cannot be acquired.\nThe length of the text being encrypted is greater than the maximum allowed length.\nThe OAEP padding is not supported on this computer.\n" + "Exact error: " + CEx.Message); }
                        catch (Exception Ex)
                        { MessageBox.Show("ERROR: \n" + Ex.Message); }
                    }
                }
            }
            else
            { MessageBox.Show("ERROR: You Can Not Encrypt A NULL Value!!!"); }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length != 0)
            {
                openFileDialog.FileName = "";
                openFileDialog.Title = "Open Private Key File";
                openFileDialog.Filter = "Private Key Document( *.kez )|*.kez";
                string fileString = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        StreamReader streamReader = new StreamReader(openFileDialog.FileName, true);
                        fileString = streamReader.ReadToEnd();
                        streamReader.Close();
                        if (fileString.Length >= inputTextBox.MaxLength)
                        { MessageBox.Show("ERROR: \nThe file you are trying to open is too big for the text editor to display properly.\nPlease open a smaller document!\nOperation Aborted!"); }
                    }
                }
                if (File.Exists(openFileDialog.FileName))
                {
                    string bitStrengthString = fileString.Substring(0, fileString.IndexOf("</BitStrength>") + 14);
                    fileString = fileString.Replace(bitStrengthString, "");
                    int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));
                    Point point = new Point((inputTextBox.Size.Width / 2) - (panel.Size.Width / 2), (inputTextBox.Size.Height / 2) - (panel.Size.Height / 2));
                    panel.Location = point;
                    panel.Visible = true;
                    this.Refresh();
                    //menu item disabled code omited
                    string tempStorage = inputTextBox.Text;
                    if (fileString != null)
                    {
                        FinishedProcessDelegate finishedProcessDelegate = new FinishedProcessDelegate(FinishedProcess);
                        UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateText);
                        try
                        {
                            EncryptionThread decryptionThread = new EncryptionThread();
                            Thread decryptThread = new Thread(decryptionThread.Decrypt);
                            decryptThread.IsBackground = true;
                            decryptThread.Start(new Object[] { this, finishedProcessDelegate, updateTextDelegate, inputTextBox.Text, bitStrength, fileString });
                        }
                        catch (CryptographicException CEx)
                        { MessageBox.Show("ERROR: \nOne of the following has occured.\nThe cryptographic service provider cannot be acquired.\nThe length of the text being encrypted is greater than the maximum allowed length.\nThe OAEP padding is not supported on this computer.\n" + "Exact error: " + CEx.Message); }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("ERROR:\n" + Ex.Message);
                            SetText(tempStorage);
                        }
                    }
                }
            }
            else
            { MessageBox.Show("ERROR: You Can Not Decrypt A NULL Value!!!"); }
        }
    }
}
