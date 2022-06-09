using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LRLogic;
using System.Configuration;
using System.Threading;
using System.IO;

namespace LockboxReader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadDocuments();
            LoadCurrentTransactionLog();
        }

        protected void LoadDocuments()
        {
            this.lstDocuments.Items.Clear();
            string[] filePaths = Directory.GetFiles(@"../../Files/");
            foreach (string file in filePaths)
            {
                string fileName = file.Replace("../../Files/", "");
                if (!fileName.Contains("."))
                {
                    this.lstDocuments.Items.Add(fileName);
                }
            }
        }

        private void cmdImportFile_Click(object sender, EventArgs e)
        {
            if (this.lstDocuments.SelectedIndex >= 0 && this.txtSelectedDate.Text != "")
            {
                ProcessFile(this.txtSelectedDate.Text
                    , this.lstDocuments.SelectedItem.ToString()
                    , ConfigurationManager.AppSettings["Files"].ToString()
                    , ConfigurationManager.AppSettings["Temp"].ToString());
            }
            else
            {
                MessageBox.Show("Please select a date and a file to processed!");
            }

        }

        /// <summary>
        /// Logic available upon request. $12,000 one time fee license. :)
        /// Please contact me to jjrosado@gmail.com for more details.
        /// </summary>
        /// <param name="selectedDate"></param>
        /// <param name="selectedFile"></param>
        /// <param name="file"></param>
        /// <param name="temp"></param>
        private void ProcessFile(string selectedDate, string selectedFile, string file, string temp)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.txtSelectedDate.Text = this.monthCalendar1.SelectionEnd.ToLongDateString();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (automaticToolStripMenuItem.Checked)
            {
                DateTime today = DateTime.Now;
                DateTime yesterday = today.AddDays(-56);
                //DateTime yesterday = today.AddDays(-1);//Production
                LoadDocuments();
                if (lstDocuments.Items.Count > 0)
                {
                    for (int x = 0; x < lstDocuments.Items.Count; x++)
                    {
                        if (this.lstDocuments.GetItemText(lstDocuments.Items[x]).ToString().Substring(3, 6) == yesterday.ToString("yy") + yesterday.ToString("MM") + yesterday.ToString("dd"))
                        {
                            this.lstDocuments.SetSelected(x, true);
                            string processedFolder = ConfigurationManager.AppSettings["FilesProcessed"].ToString() + this.lstDocuments.SelectedItem.ToString();

                            if (!File.Exists(processedFolder))
                            {
                                ProcessFile(yesterday.ToShortDateString()
                                    , this.lstDocuments.SelectedItem.ToString()
                                    , ConfigurationManager.AppSettings["Files"].ToString()
                                    , ConfigurationManager.AppSettings["Temp"].ToString());
                                TransactionLog();
                                LoadCurrentTransactionLog();
                            }
                        }
                    }
                }
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        string directoryString = @"C:\lockbox";
        protected void TransactionLog()
        {
            string folderString = directoryString + @"\Log";
            string currentFile = folderString + @"\LBlog" + DateTime.Now.Date.Year.ToString() + DateTime.Now.Date.Month.ToString() + ".txt";
            string newline = "";
            if (!Directory.Exists(folderString))
            {
                Directory.CreateDirectory(folderString);
            }

            if (File.Exists(currentFile))
            {
                newline = (new FileInfo(currentFile).Length > 0 ? Environment.NewLine : "");
            }

            string test = newline + DateTime.Now.ToString();
            File.AppendAllText(currentFile, test);
        }

        protected void LoadCurrentTransactionLog()
        {
            this.lstProcessLog.Items.Clear();
            string folderString = directoryString + @"\Log";
            string currentFile = folderString + @"\LBlog" + DateTime.Now.Date.Year.ToString() + DateTime.Now.Date.Month.ToString() + ".txt";

            if (File.Exists(currentFile))
            {
                string[] lines = File.ReadAllLines(currentFile);

                foreach (string line in lines)
                {
                    this.lstProcessLog.Items.Add(line.ToString());
                }
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            NotifyIcon.BalloonTipTitle = "Minimize to Tray the LockBox App of Open Mobile";
            NotifyIcon.BalloonTipText = "You have successfully minimized your form.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                NotifyIcon.Visible = false;
            }
        }

        private void automaticToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.cmdImportFile.Enabled = (automaticToolStripMenuItem.Checked ? false : true);
        }

        private void btnSubmitRejected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgRecordsRejected.Rows)
            {
                if (row.Cells["Processed"].Value != null)
                {
                    string test = row.Cells["Amount"].Value.ToString();
                }
            }
        }
    }
}
