using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Logix;
using System.Net.NetworkInformation;

namespace ARCFinalPrint
{
    public partial class Form1 : Form
    {
        private bool shutdown = false;
        Controller plc = new Controller();
        PeerMessage peerMsg = new PeerMessage();

        string primaryPath = Properties.Settings.Default.path_1;
        string secondaryPath = Properties.Settings.Default.path_2;
        

        public Form1()
        {
           

            InitializeComponent();
            saveFolderLabel.Text = primaryPath;
            secondaryFolderLocation.Text = secondaryPath;

            listView.View = View.Details;
            listView.Columns.Add("TimeStamp", 125, HorizontalAlignment.Left);
            listView.Columns.Add("Sender IP", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Error", 400, HorizontalAlignment.Left);

            processorTypeComboBox.SelectedIndex = Properties.Settings.Default.processorType;

            Logix.Tag
            

            peerMsg.Received += new EventHandler(peerMsg_Received);
            startListening();

            serialNumberLabel.Visible = false;
            serialNumberTextBox.Visible = false;
            serialNumberTextBox.Text = "";
            printerIPLabel.Visible = false;
            printerIPTextBox.Visible = false;
            printerIPTextBox.Text = "";
            printTestLabelButton.Visible = false;
            label6.Visible = false;
            interimIDTextBox.Visible = false;

            checkBox1.Checked = false;
            /*
            int aDate = DateTime.Now.Year;
            if (aDate >= 2016)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                if (!string.Equals(form2.enteredAccessCode,"12345"))
                {
                    shutdown = true;
                }
            }*/
        }

        void peerMsg_Received(object sender, EventArgs e)
        {
            try
            {
                //////////////////////////////////////////////////
                // since tag_changed is being called from the plcUpdate
                // thread, we need to ceated a delegate to handle the UI
                if (InvokeRequired)
                    Invoke(new MsgReceivedDelegate(MsgReceived), new object[] { (MessageEventArgs)e });
                else
                    MsgReceived((MessageEventArgs)e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        /// <summary>
        /// Delegate for the UI update for the 
        /// </summary>
        /// <param name="e">
        /// </param>
        delegate void MsgReceivedDelegate(MessageEventArgs e);

        /// <summary>
        /// Update listView with unsolicited messages
        /// </summary>
        private void MsgReceived(MessageEventArgs e)
        {
            Array dataArray = (Array)e.Value;
            string senderIP = e.IPSender;

            //int success = labelPrintFunction(dataArray);

            string success = labelPrintFunction(dataArray);

            //if (success != 0)
            //    updateListView(senderIP, success);

            if (!string.Equals(success,"done"))
            {
                updateListView(senderIP, success);
            }


        }

        /// <summary>
        /// Starts listening for messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startListening()
        {

            try
            {
                ////////////////////////////////////////////////
                // if we want to listen on any NIC on our machine, 
                // set PeerMessage.IPAddressNIC = ""
                //
                //
                // if we want to listen for messages on a 
                // specific NIC then set PeerMessage.IPAddressNIC to the 
                // IP Address assigned to the NIC
                //
                /*if ("Any" == textBoxIPAddress.Text)
                    peerMsg.IPAddressNIC = "";
                else
                    peerMsg.IPAddressNIC = textBoxIPAddress.Text;*/

                peerMsg.IPAddressNIC = "";
                if (processorTypeComboBox.SelectedIndex == 1)
                {
                    peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CSP;
                    Console.WriteLine("SLC");
                }
                else
                {
                    peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CIP;
                    Console.WriteLine("Logix");
                }
                

                peerMsg.Connections = 40;

                peerMsg.Listen();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            //DialogResult thisFolderBrowser = folderBrowserDialog1.ShowDialog();
            //if (thisFolderBrowser == DialogResult.OK)
            //{
            //    path_1 = folderBrowserDialog1.SelectedPath + @"\";
            //    saveFolderLabel.Text = path_1;
            //    Properties.Settings.Default.path_1 = path_1;
            //    Properties.Settings.Default.Save();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intArray;

            char seperator = '.';
            string success = "done";

            if (!string.IsNullOrEmpty(serialNumberTextBox.Text))
            {
                if (!string.IsNullOrEmpty(interimIDTextBox.Text))
                {
                    intArray = new Int32[19];
                    char[] ch = interimIDTextBox.Text.ToCharArray();
                    intArray[18] = ch[0];
                }
                else
                {
                    intArray = new Int32[18];
                }

                //int[] intArray = new Int32[19];

                //intArray[18] = comboBox1.SelectedIndex + 1;

                string serialNumber = serialNumberTextBox.Text;
                char[] serialNumberCharacters = serialNumber.ToCharArray();

                for (int i = 0; i < serialNumber.Length; i++)
                {
                    intArray[i] = serialNumberCharacters[i];
                }

                intArray[12] = 0;
                intArray[13] = 0;

                string ipString = printerIPTextBox.Text;
                string[] ipStringArray = ipString.Split(seperator);

                try
                {
                    intArray[14] = Convert.ToInt32(ipStringArray[0]);
                    intArray[15] = Convert.ToInt32(ipStringArray[1]);
                    intArray[16] = Convert.ToInt32(ipStringArray[2]);
                    intArray[17] = Convert.ToInt32(ipStringArray[3]);
                    success = labelPrintFunction(intArray);
                }
                catch (Exception)
                {
                    success = "Printer IP Address Is Not Valid";
                }

            }
            else
            {
                success = "Invalid Serial Number Entered";
            }
            string senderIP = "N/A";
            //if (success != "done")
            //    updateListView(senderIP,success);

            if (!string.Equals(success,"done"))
            {
                updateListView(senderIP,success);
            }
        }

        private void updateListView(string senderIPAddress, string resultMessage)
        {
            //string[] errorMessage = { "", "Invalid Data Array Size", "Alpha Code Is Not Valid", "Print Code Does Not Exit For Current Model", 
            //                            "Invalid Serial Number Entered","Printer IP Address Did Not Respond To Ping Attempt","Failed To Send Print Code To Printer",
            //                            "Printer IP Address Is Not Valid" };


            //errorListBox.Items.Insert(0, "test" + listCount.ToString());
            ListViewItem msgItem = listView.Items.Insert(0,DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));

            msgItem.SubItems.Add(senderIPAddress);

            msgItem.SubItems.Add(resultMessage);
        }

        private string labelPrintFunction(Array aArray)
        {
            string alphaCode = "";
            string serialNumber = "";
            string weight = "";
            string printerIPAddress = "";
            Array dataArray = aArray;

            if (dataArray.Length != 18 && dataArray.Length != 19)
                return "Invalid Data Array Size";

            int firstChar = Convert.ToInt32(dataArray.GetValue(0));
            int secondChar = Convert.ToInt32(dataArray.GetValue(1));


            string path = "";

            if (dataArray.Length == 18)
            {
                path = primaryPath;
            }
            else
            {
                path = secondaryPath;

                //ramdom comment

            }


            if (firstChar < 48 || secondChar < 48)
                return "Alpha Code Is Not Valid";

            for (int i = 0; i < 11; i++)
            {
                int intValue = Convert.ToInt32(dataArray.GetValue(i));
                char aChar = Convert.ToChar(intValue);
                serialNumber += aChar;
                if (i < 2)
                {
                    alphaCode += aChar;
                }
            }

            if (dataArray.Length == 19)
            {
                int intValue = Convert.ToInt32(dataArray.GetValue(18));
                char aChar = Convert.ToChar(intValue);
                alphaCode = aChar.ToString();
            }

            int weightWholeNumber = Convert.ToInt32(dataArray.GetValue(12));
            int weightDecimalNumber = Convert.ToInt32(dataArray.GetValue(13));

            string weightString = formatWeight(alphaCode, weightWholeNumber, weightDecimalNumber, path);

            for (int i = 14; i < 17; i++)
                printerIPAddress += dataArray.GetValue(i).ToString() + ".";

            printerIPAddress += dataArray.GetValue(17).ToString();

            weight = weightString;

            string printCodeString = createPrintString(alphaCode, serialNumber, weight, path);

            if (printCodeString == "none")
                return "Print Code Does Not Exist For Alpha Code: " + alphaCode + " in Path - " + path;

            string printSuccess = printLabel(printCodeString, printerIPAddress);

            return printSuccess;
        }

        private string formatWeight(string alphaCode, int weightWholeNumber, int weightDecimalNumber, string path)
        {
            string file = path + "WeightFormat.csv";
            char separator = ',';
            int numberOfDecimalPlaces = 2;

            if (File.Exists(file))
            {
                string[] allLines = File.ReadAllLines(file);

                foreach (string s in allLines)
                {
                    string[] columns = s.Split(separator);

                    if (columns[0] == alphaCode)
                    {
                        numberOfDecimalPlaces =  Convert.ToInt32(columns[1]);
                    }
                }

                
            }

            string weightWholeNumberString = weightWholeNumber.ToString();
            string weightDecimalNumberString = "";

            if (weightDecimalNumber < 10)
            {
                weightDecimalNumberString = "0" + weightDecimalNumber.ToString();
            }
            else
            {
                weightDecimalNumberString = weightDecimalNumber.ToString();
            }

            if (numberOfDecimalPlaces == 1)
            {
                weightDecimalNumberString = weightDecimalNumberString.Substring(0, 1);
            }

            string weightString = weightWholeNumberString + "." + weightDecimalNumberString;

            return weightString;

        }

        private string createPrintString(string alphaCode, string serialNumber, string weight, string path)
        {

            StringBuilder mySB = new StringBuilder();
            string file = path + alphaCode + ".txt";
            if (File.Exists(file))
            {
                string[] allLines = File.ReadAllLines(file);
                string yearString = DateTime.Now.Year.ToString();
                string monthString = DateTime.Now.Month.ToString();
                string monthString2 = (monthString.Length == 1) ? "0" + monthString : monthString;

                foreach (string s in allLines)
                {
                    string currentLine = s.Replace("_SerialNumber_", serialNumber);
                    
                    currentLine = currentLine.Replace("_Weight_", weight);
                    currentLine = currentLine.Replace("_Year_", yearString);
                    currentLine = currentLine.Replace("_Month_", monthString);
                    currentLine = currentLine.Replace("_Month02", monthString2);
                    mySB.Append(currentLine);
                }

                return mySB.ToString();
            }
            else
            {
                return "none";
            }

            
        }

        private string printLabel(string stringToPrint, string printerIP)
        {
            if (Ping(printerIP))
            {
                string ipAddress = printerIP;
                int port = 9100;

                // ZPL Command(s)
                string ZPLString = stringToPrint;

                try
                {
                    // Open connection
                    System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
                    client.Connect(ipAddress, port);

                    // Write ZPL String to connection
                    System.IO.StreamWriter writer =
                new System.IO.StreamWriter(client.GetStream());
                    writer.Write(ZPLString);
                    writer.Flush();

                    // Close Connection
                    writer.Close();
                    client.Close();
                    return "done";
                }
                catch (Exception ex)
                {
                    return "Failed To Send Print Code To Printer At Address: " + printerIP;
                }
            }
            else
            {
                return "Printer At IP Address: " + printerIP + " Did Not Respond To Ping Attempt";
            }

            

        }

        public static bool Ping(string p_IPAddress)
        {
            bool isConnected = false;
            
            //IPAddress ip = IPAddress.Parse(p_IPAddress);

            Ping pingSender = new Ping();
            //IPAddress address = IPAddress.Loopback;
            PingReply reply = pingSender.Send(p_IPAddress);

            if (reply.Status == IPStatus.Success)
            {
                isConnected = true;
            }

            return isConnected;
        }

        private void processorTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.processorType = processorTypeComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void processorTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Restart program for changes to take effect.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                serialNumberLabel.Visible = true;
                serialNumberTextBox.Visible = true;
                printerIPLabel.Visible = true;
                printerIPTextBox.Visible = true;
                printTestLabelButton.Visible = true;
                label6.Visible = true;
                interimIDTextBox.Visible = true;
            }
            else
            {
                serialNumberLabel.Visible = false;
                serialNumberTextBox.Visible = false;
                serialNumberTextBox.Text = "";
                printerIPLabel.Visible = false;
                printerIPTextBox.Visible = false;
                printerIPTextBox.Text = "";
                printTestLabelButton.Visible = false;
                label6.Visible = false;
                interimIDTextBox.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void changePrintCodeLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thisFolderBrowser = folderBrowserDialog1.ShowDialog();
            if (thisFolderBrowser == DialogResult.OK)
            {
                primaryPath = folderBrowserDialog1.SelectedPath + @"\";
                saveFolderLabel.Text = primaryPath;
                Properties.Settings.Default.path_1 = primaryPath;
                Properties.Settings.Default.Save();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePrintCodeFolder2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thisFolderBrowser = folderBrowserDialog1.ShowDialog();
            if (thisFolderBrowser == DialogResult.OK)
            {
                secondaryPath = folderBrowserDialog1.SelectedPath + @"\";
                secondaryFolderLocation.Text = secondaryPath;
                Properties.Settings.Default.path_2 = secondaryPath;
                Properties.Settings.Default.Save();
            }
        }

        private void settingUpPLCMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory().ToString());
            string mypath = System.IO.Directory.GetCurrentDirectory().ToString() + "\\ARCFinalPrint.chm";
            System.Windows.Forms.Help.ShowHelp(this, mypath);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*peerMsg.Dispose();
            plc.Disconnect();
            plc.Dispose();*/
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (shutdown)
            {
                this.Close();
            }
        }


    }
}
