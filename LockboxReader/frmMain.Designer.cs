namespace LockboxReader
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmdImportFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstProgress = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstAnalysis = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstRecordsProcessed = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lstRecordsRejected = new System.Windows.Forms.ListBox();
            this.txtSelectedDate = new System.Windows.Forms.TextBox();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgRecordsRejected = new System.Windows.Forms.DataGridView();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExternalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSubmitRejected = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProcessRejectedTransactions = new System.Windows.Forms.Label();
            this.plProcessLog = new System.Windows.Forms.Panel();
            this.lstProcessLog = new System.Windows.Forms.ListBox();
            this.lblProcessLog = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecordsRejected)).BeginInit();
            this.panel1.SuspendLayout();
            this.plProcessLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 86);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(24, 21, 24, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // cmdImportFile
            // 
            this.cmdImportFile.Location = new System.Drawing.Point(184, 689);
            this.cmdImportFile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmdImportFile.Name = "cmdImportFile";
            this.cmdImportFile.Size = new System.Drawing.Size(288, 74);
            this.cmdImportFile.TabIndex = 1;
            this.cmdImportFile.Text = "Import File";
            this.cmdImportFile.UseVisualStyleBackColor = true;
            this.cmdImportFile.Click += new System.EventHandler(this.cmdImportFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(675, 620);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1645, 684);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstProgress);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(1625, 626);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "File progress";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstProgress
            // 
            this.lstProgress.FormattingEnabled = true;
            this.lstProgress.ItemHeight = 31;
            this.lstProgress.Location = new System.Drawing.Point(16, 14);
            this.lstProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstProgress.Name = "lstProgress";
            this.lstProgress.Size = new System.Drawing.Size(1591, 593);
            this.lstProgress.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstAnalysis);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(1625, 626);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Block analysis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstAnalysis
            // 
            this.lstAnalysis.FormattingEnabled = true;
            this.lstAnalysis.ItemHeight = 31;
            this.lstAnalysis.Location = new System.Drawing.Point(16, 14);
            this.lstAnalysis.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstAnalysis.Name = "lstAnalysis";
            this.lstAnalysis.Size = new System.Drawing.Size(1591, 593);
            this.lstAnalysis.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstRecords);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Size = new System.Drawing.Size(1625, 626);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "All Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.ItemHeight = 31;
            this.lstRecords.Location = new System.Drawing.Point(16, 14);
            this.lstRecords.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(1591, 593);
            this.lstRecords.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstRecordsProcessed);
            this.tabPage4.Location = new System.Drawing.Point(10, 48);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage4.Size = new System.Drawing.Size(1625, 626);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Records Processed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstRecordsProcessed
            // 
            this.lstRecordsProcessed.FormattingEnabled = true;
            this.lstRecordsProcessed.ItemHeight = 31;
            this.lstRecordsProcessed.Location = new System.Drawing.Point(16, 14);
            this.lstRecordsProcessed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstRecordsProcessed.Name = "lstRecordsProcessed";
            this.lstRecordsProcessed.Size = new System.Drawing.Size(1591, 593);
            this.lstRecordsProcessed.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lstRecordsRejected);
            this.tabPage5.Location = new System.Drawing.Point(10, 48);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage5.Size = new System.Drawing.Size(1625, 626);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Records Rejected";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lstRecordsRejected
            // 
            this.lstRecordsRejected.FormattingEnabled = true;
            this.lstRecordsRejected.ItemHeight = 31;
            this.lstRecordsRejected.Location = new System.Drawing.Point(16, 14);
            this.lstRecordsRejected.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstRecordsRejected.Name = "lstRecordsRejected";
            this.lstRecordsRejected.Size = new System.Drawing.Size(1591, 593);
            this.lstRecordsRejected.TabIndex = 0;
            // 
            // txtSelectedDate
            // 
            this.txtSelectedDate.Location = new System.Drawing.Point(37, 477);
            this.txtSelectedDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSelectedDate.Name = "txtSelectedDate";
            this.txtSelectedDate.Size = new System.Drawing.Size(599, 38);
            this.txtSelectedDate.TabIndex = 2;
            // 
            // lstDocuments
            // 
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.ItemHeight = 31;
            this.lstDocuments.Location = new System.Drawing.Point(37, 539);
            this.lstDocuments.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(599, 128);
            this.lstDocuments.TabIndex = 3;
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.Menu.Size = new System.Drawing.Size(2352, 55);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(349, 54);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(111, 45);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.CheckOnClick = true;
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            this.automaticToolStripMenuItem.Size = new System.Drawing.Size(320, 54);
            this.automaticToolStripMenuItem.Text = "Automatic";
            this.automaticToolStripMenuItem.CheckedChanged += new System.EventHandler(this.automaticToolStripMenuItem_CheckedChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Lockbox";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // dgRecordsRejected
            // 
            this.dgRecordsRejected.AllowUserToAddRows = false;
            this.dgRecordsRejected.AllowUserToDeleteRows = false;
            this.dgRecordsRejected.AllowUserToOrderColumns = true;
            this.dgRecordsRejected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecordsRejected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.Bank,
            this.Account,
            this.Check,
            this.Invoice,
            this.Amount2,
            this.ExternalId,
            this.Processed});
            this.dgRecordsRejected.Location = new System.Drawing.Point(19, 19);
            this.dgRecordsRejected.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgRecordsRejected.Name = "dgRecordsRejected";
            this.dgRecordsRejected.RowHeadersWidth = 102;
            this.dgRecordsRejected.Size = new System.Drawing.Size(1603, 346);
            this.dgRecordsRejected.TabIndex = 7;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 12;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 60;
            // 
            // Bank
            // 
            this.Bank.DataPropertyName = "Bank";
            this.Bank.HeaderText = "Bank";
            this.Bank.MinimumWidth = 12;
            this.Bank.Name = "Bank";
            this.Bank.ReadOnly = true;
            this.Bank.Width = 70;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "Account";
            this.Account.MinimumWidth = 12;
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 80;
            // 
            // Check
            // 
            this.Check.DataPropertyName = "Check";
            this.Check.HeaderText = "Check";
            this.Check.MinimumWidth = 12;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 50;
            // 
            // Invoice
            // 
            this.Invoice.DataPropertyName = "Invoice";
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.MinimumWidth = 12;
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Width = 80;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount2";
            this.Amount2.HeaderText = "Amount";
            this.Amount2.MinimumWidth = 12;
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            this.Amount2.Width = 60;
            // 
            // ExternalId
            // 
            this.ExternalId.DataPropertyName = "ExternalId";
            this.ExternalId.HeaderText = "External Id";
            this.ExternalId.MinimumWidth = 12;
            this.ExternalId.Name = "ExternalId";
            this.ExternalId.Width = 80;
            // 
            // Processed
            // 
            this.Processed.DataPropertyName = "Processed";
            this.Processed.HeaderText = "Processed";
            this.Processed.MinimumWidth = 12;
            this.Processed.Name = "Processed";
            this.Processed.Width = 60;
            // 
            // btnSubmitRejected
            // 
            this.btnSubmitRejected.Location = new System.Drawing.Point(2032, 486);
            this.btnSubmitRejected.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSubmitRejected.Name = "btnSubmitRejected";
            this.btnSubmitRejected.Size = new System.Drawing.Size(269, 64);
            this.btnSubmitRejected.TabIndex = 8;
            this.btnSubmitRejected.Text = "Submit";
            this.btnSubmitRejected.UseVisualStyleBackColor = true;
            this.btnSubmitRejected.Click += new System.EventHandler(this.btnSubmitRejected_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgRecordsRejected);
            this.panel1.Location = new System.Drawing.Point(675, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1642, 384);
            this.panel1.TabIndex = 9;
            // 
            // lblProcessRejectedTransactions
            // 
            this.lblProcessRejectedTransactions.AutoSize = true;
            this.lblProcessRejectedTransactions.Location = new System.Drawing.Point(693, 69);
            this.lblProcessRejectedTransactions.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProcessRejectedTransactions.Name = "lblProcessRejectedTransactions";
            this.lblProcessRejectedTransactions.Size = new System.Drawing.Size(406, 32);
            this.lblProcessRejectedTransactions.TabIndex = 10;
            this.lblProcessRejectedTransactions.Text = "Process Rejected Transactions";
            // 
            // plProcessLog
            // 
            this.plProcessLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plProcessLog.Controls.Add(this.lstProcessLog);
            this.plProcessLog.Location = new System.Drawing.Point(37, 789);
            this.plProcessLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.plProcessLog.Name = "plProcessLog";
            this.plProcessLog.Size = new System.Drawing.Size(602, 512);
            this.plProcessLog.TabIndex = 11;
            // 
            // lstProcessLog
            // 
            this.lstProcessLog.FormattingEnabled = true;
            this.lstProcessLog.ItemHeight = 31;
            this.lstProcessLog.Location = new System.Drawing.Point(8, 26);
            this.lstProcessLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstProcessLog.Name = "lstProcessLog";
            this.lstProcessLog.Size = new System.Drawing.Size(577, 469);
            this.lstProcessLog.TabIndex = 0;
            // 
            // lblProcessLog
            // 
            this.lblProcessLog.AutoSize = true;
            this.lblProcessLog.Location = new System.Drawing.Point(53, 770);
            this.lblProcessLog.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProcessLog.Name = "lblProcessLog";
            this.lblProcessLog.Size = new System.Drawing.Size(171, 32);
            this.lblProcessLog.TabIndex = 12;
            this.lblProcessLog.Text = "Process Log";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2352, 1333);
            this.Controls.Add(this.lblProcessLog);
            this.Controls.Add(this.btnSubmitRejected);
            this.Controls.Add(this.lblProcessRejectedTransactions);
            this.Controls.Add(this.lstDocuments);
            this.Controls.Add(this.txtSelectedDate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmdImportFile);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plProcessLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lockbox Import";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecordsRejected)).EndInit();
            this.panel1.ResumeLayout(false);
            this.plProcessLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button cmdImportFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox lstProgress;
        private System.Windows.Forms.TextBox txtSelectedDate;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstAnalysis;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstRecords;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstRecordsProcessed;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox lstRecordsRejected;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.DataGridView dgRecordsRejected;
        private System.Windows.Forms.Button btnSubmitRejected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProcessRejectedTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExternalId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Processed;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel plProcessLog;
        private System.Windows.Forms.Label lblProcessLog;
        private System.Windows.Forms.ListBox lstProcessLog;

    }
}

