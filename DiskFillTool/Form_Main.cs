﻿using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DiskFillTool
{
    public partial class Form_Main : Form
    {
        #region Member Variables

        private DriveInfo driveInfo = null;
        private long freeSize;
        private Thread _fillWithTheSpecifiedFile = null;
        private Thread _zero = null;
        private Thread _one = null;
        private Thread _monitor = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public Form_Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.GetThePartitionNameAndFillTheComboBox();
        }

        #region Private Function

        private void GetTheDriveInfoAndSetTheControlValue()
        {
            while (true)
            {
                long totalFreeSpace = this.driveInfo.TotalFreeSpace;
                long totalSize = this.driveInfo.TotalSize;

                if (totalFreeSpace <= 734003200)
                {
                    MessageBox.Show("Complete");
                    this.CloseAllThreads();
                    break;
                }

                this.label_FreeSpaceSize.Text = (totalFreeSpace / 1024.0 / 1024.0).ToString();
                this.progressBar_FreeSpace.Value = (int)((double)totalFreeSpace / totalSize * 100.0);
                this.label_FreeSpacePercentage.Text = this.progressBar_FreeSpace.Value.ToString() + "%";

                this.label_UsedSpaceSize.Text = ((totalSize - totalFreeSpace) / 1024.0 / 1024.0).ToString();
                this.progressBar_UsedSpace.Value = (int)((double)(totalSize - totalFreeSpace) / totalSize * 100.0);
                this.label_UsedSpacePercentage.Text = this.progressBar_UsedSpace.Value.ToString() + "%";

                this.label_TotalSize.Text = (totalSize / 1024.0 / 1024.0).ToString();

                this.progressBar_Fill.Value = (int)((double)(this.freeSize - totalFreeSpace) / this.freeSize * 100.0);

                Thread.Sleep(2000);
            }
        }

        private void GetThePartitionNameAndFillTheComboBox()
        {
            string[] driveName = Environment.GetLogicalDrives();
            this.comboBox_PartitionName.DataSource = driveName;
        }

        private void SetTheControlEnabledState(string str)
        {
            switch (str)
            {
                case "Start":
                    this.comboBox_PartitionName.Enabled = false;
                    this.button_Fill.Enabled = false;
                    this.button_Stop.Enabled = true;
                    this.button_Advanced.Enabled = false;
                    this.button_ChooseFiles.Enabled = false;
                    this.listBox_Files.Enabled = false;
                    break;
                case "Stop":
                    this.comboBox_PartitionName.Enabled = true;
                    this.button_Fill.Enabled = true;
                    this.button_Stop.Enabled = false;
                    this.button_Advanced.Enabled = true;
                    this.button_ChooseFiles.Enabled = true;
                    this.listBox_Files.Enabled = true;
                    this.button_Stop.Text = "Stop";
                    break;
                case "Stopping":
                    this.button_Stop.Text = "Stopping";
                    this.button_Stop.Enabled = false;
                    break;
            }
        }

        private void CreateThreadsAndBeginToFill()
        {
            this.driveInfo = new DriveInfo(this.comboBox_PartitionName.Text);
            this.freeSize = this.driveInfo.TotalFreeSpace;

            this._monitor = new Thread(new ThreadStart(GetTheDriveInfoAndSetTheControlValue));
            _monitor.Start();

            if (this.button_Advanced.Text == "Advanced")
            {
                this.FillWithTheRegularValue();
            }
            else
            {
                this._fillWithTheSpecifiedFile = new Thread(new ThreadStart(FillWithTheSpecifiedFile));
                _fillWithTheSpecifiedFile.Start();
            }
        }

        private void CloseAllThreads()
        {
            if (this.button_Advanced.Text == "Advanced")
            {
                if (this._zero == null || this._one == null || this._monitor == null)
                {
                    return;
                }
                this._zero.Abort();
                this._one.Abort();
                this._monitor.Abort();
                while (true)
                {
                    if (this._zero.IsAlive == false && this._one.IsAlive == false && this._monitor.IsAlive == false)
                    {
                        break;
                    }
                    Thread.Sleep(5000);
                }
            }
            else
            {
                if (this._monitor == null || this._fillWithTheSpecifiedFile == null)
                {
                    return;
                }
                this._monitor.Abort();
                this._fillWithTheSpecifiedFile.Abort();
                while (true)
                {
                    if (this._monitor.IsAlive == false && this._fillWithTheSpecifiedFile.IsAlive == false)
                    {
                        break;
                    }
                    Thread.Sleep(5000);
                }
            }
        }

        private void FillWithTheSpecifiedFile()
        {
            int fileCount = this.listBox_Files.Items.Count;
            int index = 0;
            string destFileName;
            while (true)
            {
                if (index == fileCount)
                {
                    index = 0;
                }
                destFileName = this.driveInfo.Name + DateTime.Now.ToString("yyyyMMddhhmmssff") + this.listBox_Files.Items[index].ToString().Remove(0, this.listBox_Files.Items[index].ToString().LastIndexOf('\\') + 1);
                try
                {
                    File.Copy(this.listBox_Files.Items[index].ToString(), destFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.CloseAllThreads();
                }
                index++;
            }
        }

        private void FillWithTheRegularValue()
        {
            this._zero = new Thread(new ThreadStart(FillZero));
            _zero.Start();
            this._one = new Thread(new ThreadStart(FillOne));
            _one.Start();
        }

        private void FillZero()
        {
            UInt64 count = 0;
            while (true)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(this.driveInfo.Name + "0" + count++, FileMode.OpenOrCreate);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.CloseAllThreads();
                }
                StreamWriter sw = new StreamWriter(fs);
                long end = DateTime.Now.Millisecond * 1000000;
                for (long i = 0; i < end; i++)
                {
                    sw.Write("0");
                    if (i % 100000000 == 0)
                    {
                        Thread.Sleep(500);
                    }
                }
                sw.Close();
            }
        }

        private void FillOne()
        {
            UInt64 count = 0;
            while (true)
            {
                try
                {
                    FileStream fs = new FileStream(this.driveInfo.Name + "1" + count++, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs);
                    long end = DateTime.Now.Millisecond * 1000000;
                    for (long i = 0; i < end; i++)
                    {
                        sw.Write("1");
                        if (i % 100000000 == 0)
                        {
                            Thread.Sleep(500);
                        }
                    }
                    sw.Close();
                }
                catch (Exception) { }
            }
        }

        private void ChangeTheWindowStatusFromNormalToAdvanced()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(this.Location.X - 10, this.Location.Y);
                this.Width = this.Width + 20;
                Thread.Sleep(10);
            }
        }

        private void ChangeTheWindowStatusFromAdvancedToNormal()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(this.Location.X + 10, this.Location.Y);
                this.Width = this.Width - 20;
                Thread.Sleep(10);
            }
        }

        #endregion

        #region Event Handlers

        private void button_Fill_Click(object sender, EventArgs e)
        {
            if (this.button_Advanced.Text == "Normal" && this.listBox_Files.Items.Count == 0)
            {
                MessageBox.Show("Please choose files", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.SetTheControlEnabledState("Start");
            this.CreateThreadsAndBeginToFill();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.SetTheControlEnabledState("Stopping");
            this.CloseAllThreads();
            this.SetTheControlEnabledState("Stop");
        }

        private void button_Advanced_Click(object sender, EventArgs e)
        {
            if (this.button_Advanced.Text == "Advanced")
            {
                this.ChangeTheWindowStatusFromNormalToAdvanced();
                this.button_Advanced.Text = "Normal";
            }
            else
            {
                this.ChangeTheWindowStatusFromAdvancedToNormal();
                this.button_Advanced.Text = "Advanced";
            }
        }

        private void button_ChooseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Please Choose Files";
            openFileDialog.Filter = "All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] path = openFileDialog.FileNames;
                listBox_Files.DataSource = path;
            }
        }

        #region Title Bar

        private void panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label_Minimize_MouseEnter(object sender, EventArgs e)
        {
            this.label_Minimize.BackColor = Color.Red;
            this.label_Minimize.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void label_Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.label_Minimize.BackColor = Color.FromArgb(250, 250, 250);
            this.label_Minimize.ForeColor = Color.Black;
        }

        private void label_Close_MouseEnter(object sender, EventArgs e)
        {
            this.label_Close.BackColor = Color.Red;
            this.label_Close.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void label_Close_MouseLeave(object sender, EventArgs e)
        {
            this.label_Close.BackColor = Color.FromArgb(250, 250, 250);
            this.label_Close.ForeColor = Color.Black;
        }

        private void label_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            this.CloseAllThreads();
            this.Close();
        }

        #endregion

        #endregion
    }
}
