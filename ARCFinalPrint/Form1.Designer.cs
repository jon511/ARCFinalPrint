namespace ARCFinalPrint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                plc.Dispose();
                peerMsg.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.saveFolderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.printTestLabelButton = new System.Windows.Forms.Button();
            this.processorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.printerIPLabel = new System.Windows.Forms.Label();
            this.printerIPTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePrintCodeLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePrintCodeFolder2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingUpPLCMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondaryFolderLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label6 = new System.Windows.Forms.Label();
            this.interimIDTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFolderButton
            // 
            this.HelpProviderHG.SetHelpKeyword(this.chooseFolderButton, "Form1.htm#chooseFolderButton");
            this.HelpProviderHG.SetHelpNavigator(this.chooseFolderButton, System.Windows.Forms.HelpNavigator.Topic);
            this.chooseFolderButton.Location = new System.Drawing.Point(8, 87);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.HelpProviderHG.SetShowHelp(this.chooseFolderButton, true);
            this.chooseFolderButton.Size = new System.Drawing.Size(69, 22);
            this.chooseFolderButton.TabIndex = 16;
            this.chooseFolderButton.Text = "Change";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Visible = false;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // saveFolderLabel
            // 
            this.saveFolderLabel.AutoSize = true;
            this.saveFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFolderLabel.Location = new System.Drawing.Point(62, 44);
            this.saveFolderLabel.Name = "saveFolderLabel";
            this.saveFolderLabel.Size = new System.Drawing.Size(25, 13);
            this.saveFolderLabel.TabIndex = 17;
            this.saveFolderLabel.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Print Code Storage Folders:";
            // 
            // printTestLabelButton
            // 
            this.HelpProviderHG.SetHelpKeyword(this.printTestLabelButton, "Form1.htm#printTestLabelButton");
            this.HelpProviderHG.SetHelpNavigator(this.printTestLabelButton, System.Windows.Forms.HelpNavigator.Topic);
            this.printTestLabelButton.Location = new System.Drawing.Point(404, 115);
            this.printTestLabelButton.Margin = new System.Windows.Forms.Padding(2);
            this.printTestLabelButton.Name = "printTestLabelButton";
            this.HelpProviderHG.SetShowHelp(this.printTestLabelButton, true);
            this.printTestLabelButton.Size = new System.Drawing.Size(96, 19);
            this.printTestLabelButton.TabIndex = 19;
            this.printTestLabelButton.Text = "Print Test Label";
            this.printTestLabelButton.UseVisualStyleBackColor = true;
            this.printTestLabelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // processorTypeComboBox
            // 
            this.processorTypeComboBox.FormattingEnabled = true;
            this.HelpProviderHG.SetHelpKeyword(this.processorTypeComboBox, "Form1.htm#label2");
            this.HelpProviderHG.SetHelpNavigator(this.processorTypeComboBox, System.Windows.Forms.HelpNavigator.Topic);
            this.processorTypeComboBox.Items.AddRange(new object[] {
            "Logix",
            "SLC"});
            this.processorTypeComboBox.Location = new System.Drawing.Point(316, 29);
            this.processorTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.processorTypeComboBox.Name = "processorTypeComboBox";
            this.HelpProviderHG.SetShowHelp(this.processorTypeComboBox, true);
            this.processorTypeComboBox.Size = new System.Drawing.Size(62, 21);
            this.processorTypeComboBox.TabIndex = 20;
            this.processorTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.processorTypeComboBox_SelectedIndexChanged);
            this.processorTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.processorTypeComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Process Type";
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.AutoSize = true;
            this.serialNumberLabel.Location = new System.Drawing.Point(142, 92);
            this.serialNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(126, 13);
            this.serialNumberLabel.TabIndex = 22;
            this.serialNumberLabel.Text = "Test Label Serial Number";
            // 
            // serialNumberTextBox
            // 
            this.HelpProviderHG.SetHelpKeyword(this.serialNumberTextBox, "Form1.htm#serialNumberLabel");
            this.HelpProviderHG.SetHelpNavigator(this.serialNumberTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.serialNumberTextBox.Location = new System.Drawing.Point(272, 90);
            this.serialNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.HelpProviderHG.SetShowHelp(this.serialNumberTextBox, true);
            this.serialNumberTextBox.Size = new System.Drawing.Size(107, 20);
            this.serialNumberTextBox.TabIndex = 23;
            // 
            // printerIPLabel
            // 
            this.printerIPLabel.AutoSize = true;
            this.printerIPLabel.Location = new System.Drawing.Point(122, 121);
            this.printerIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printerIPLabel.Name = "printerIPLabel";
            this.printerIPLabel.Size = new System.Drawing.Size(144, 13);
            this.printerIPLabel.TabIndex = 24;
            this.printerIPLabel.Text = "Test Label Printer IP Address";
            // 
            // printerIPTextBox
            // 
            this.HelpProviderHG.SetHelpKeyword(this.printerIPTextBox, "Form1.htm#printerIPLabel");
            this.HelpProviderHG.SetHelpNavigator(this.printerIPTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.printerIPTextBox.Location = new System.Drawing.Point(272, 120);
            this.printerIPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.printerIPTextBox.Name = "printerIPTextBox";
            this.HelpProviderHG.SetShowHelp(this.printerIPTextBox, true);
            this.printerIPTextBox.Size = new System.Drawing.Size(107, 20);
            this.printerIPTextBox.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.HelpProviderHG.SetHelpKeyword(this.checkBox1, "Form1.htm#checkBox1");
            this.HelpProviderHG.SetHelpNavigator(this.checkBox1, System.Windows.Forms.HelpNavigator.Topic);
            this.checkBox1.Location = new System.Drawing.Point(228, 64);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.HelpProviderHG.SetShowHelp(this.checkBox1, true);
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Enable Test Label Printing";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView
            // 
            this.HelpProviderHG.SetHelpKeyword(this.listView, "Form1.htm#listView");
            this.HelpProviderHG.SetHelpNavigator(this.listView, System.Windows.Forms.HelpNavigator.Topic);
            this.listView.Location = new System.Drawing.Point(8, 157);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.HelpProviderHG.SetShowHelp(this.listView, true);
            this.listView.Size = new System.Drawing.Size(518, 136);
            this.listView.TabIndex = 27;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.HelpProviderHG.SetHelpKeyword(this.button1, "Form1.htm#button1");
            this.HelpProviderHG.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(230, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.HelpProviderHG.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(70, 21);
            this.button1.TabIndex = 28;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePrintCodeLocationToolStripMenuItem,
            this.changePrintCodeFolder2ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePrintCodeLocationToolStripMenuItem
            // 
            this.changePrintCodeLocationToolStripMenuItem.Name = "changePrintCodeLocationToolStripMenuItem";
            this.changePrintCodeLocationToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.changePrintCodeLocationToolStripMenuItem.Text = "Select Print Code Primary Folder";
            this.changePrintCodeLocationToolStripMenuItem.Click += new System.EventHandler(this.changePrintCodeLocationToolStripMenuItem_Click);
            // 
            // changePrintCodeFolder2ToolStripMenuItem
            // 
            this.changePrintCodeFolder2ToolStripMenuItem.Name = "changePrintCodeFolder2ToolStripMenuItem";
            this.changePrintCodeFolder2ToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.changePrintCodeFolder2ToolStripMenuItem.Text = "Select Print Code Secondary Folder";
            this.changePrintCodeFolder2ToolStripMenuItem.Click += new System.EventHandler(this.changePrintCodeFolder2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingUpPLCMessageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // settingUpPLCMessageToolStripMenuItem
            // 
            this.settingUpPLCMessageToolStripMenuItem.Name = "settingUpPLCMessageToolStripMenuItem";
            this.settingUpPLCMessageToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.settingUpPLCMessageToolStripMenuItem.Text = "ARC Final Label Print Help";
            this.settingUpPLCMessageToolStripMenuItem.Click += new System.EventHandler(this.settingUpPLCMessageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // secondaryFolderLocation
            // 
            this.secondaryFolderLocation.AutoSize = true;
            this.secondaryFolderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryFolderLocation.Location = new System.Drawing.Point(78, 64);
            this.secondaryFolderLocation.Name = "secondaryFolderLocation";
            this.secondaryFolderLocation.Size = new System.Drawing.Size(25, 13);
            this.secondaryFolderLocation.TabIndex = 30;
            this.secondaryFolderLocation.Text = "C:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Primary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Secondary:";
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "ARCFinalPrint.chm";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Help Generator Files\\ARCFinalPrint.chm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Interim ID";
            // 
            // interimIDTextBox
            // 
            this.interimIDTextBox.Location = new System.Drawing.Point(404, 89);
            this.interimIDTextBox.MaxLength = 1;
            this.interimIDTextBox.Name = "interimIDTextBox";
            this.interimIDTextBox.Size = new System.Drawing.Size(92, 20);
            this.interimIDTextBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 332);
            this.Controls.Add(this.interimIDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondaryFolderLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.printerIPTextBox);
            this.Controls.Add(this.printerIPLabel);
            this.Controls.Add(this.serialNumberTextBox);
            this.Controls.Add(this.serialNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.processorTypeComboBox);
            this.Controls.Add(this.printTestLabelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveFolderLabel);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.menuStrip1);
            this.HelpProviderHG.SetHelpKeyword(this, "Form1.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "ARC Final Label Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Label saveFolderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button printTestLabelButton;
        private System.Windows.Forms.ComboBox processorTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label serialNumberLabel;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Label printerIPLabel;
        private System.Windows.Forms.TextBox printerIPTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePrintCodeLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePrintCodeFolder2ToolStripMenuItem;
        private System.Windows.Forms.Label secondaryFolderLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem settingUpPLCMessageToolStripMenuItem;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox interimIDTextBox;
    }
}

