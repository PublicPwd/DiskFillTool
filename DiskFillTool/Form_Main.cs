using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DiskFillTool
{
    public partial class Form_Main : Form
    {
        private DriveInfo driveInfo = null;
        private long freeSize;
        private Thread _zero = null;
        private Thread _one = null;
        private Thread _monitor = null;

        public Form_Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.GetThePartitionNameAndFillTheComboBox();
        }

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
                    break;
                case "Stop":
                    this.comboBox_PartitionName.Enabled = true;
                    this.button_Fill.Enabled = true;
                    this.button_Stop.Enabled = false;
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
            this._zero = new Thread(new ThreadStart(FillZero));
            _zero.Start();
            this._one = new Thread(new ThreadStart(FillOne));
            _one.Start();
        }

        private void CloseAllThreads()
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

        private void FillZero()
        {
            UInt64 count = 0;
            while(true)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(this.driveInfo.Name + "0" + count++, FileMode.OpenOrCreate);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
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

        private void button_Fill_Click(object sender, EventArgs e)
        {
            this.SetTheControlEnabledState("Start");
            this.CreateThreadsAndBeginToFill();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.SetTheControlEnabledState("Stopping");
            this.CloseAllThreads();
            this.SetTheControlEnabledState("Stop");
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseAllThreads();
        }
    }
}
