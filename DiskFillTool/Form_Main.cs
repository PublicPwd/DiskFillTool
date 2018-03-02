using System;
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
        private DateTime dateTime;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public Form_Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            GetThePartitionNameAndFillTheComboBox();
        }

        #region Private Function

        private void GetTheDriveInfoAndSetTheControlValue()
        {
            while (true)
            {
                long totalFreeSpace = driveInfo.TotalFreeSpace;
                long totalSize = driveInfo.TotalSize;

                if (totalFreeSpace <= 734003200)
                {
                    MessageBox.Show("Complete");
                    CloseAllThreads();
                    break;
                }

                Label_FreeSpaceSize.Text = (totalFreeSpace / 1024.0 / 1024.0).ToString();
                ProgressBar_FreeSpace.Value = (int)((double)totalFreeSpace / totalSize * 100.0);
                Label_FreeSpacePercentage.Text = ProgressBar_FreeSpace.Value.ToString() + "%";

                Label_UsedSpaceSize.Text = ((totalSize - totalFreeSpace) / 1024.0 / 1024.0).ToString();
                ProgressBar_UsedSpace.Value = (int)((double)(totalSize - totalFreeSpace) / totalSize * 100.0);
                Label_UsedSpacePercentage.Text = ProgressBar_UsedSpace.Value.ToString() + "%";

                Label_TotalSize.Text = (totalSize / 1024.0 / 1024.0).ToString();

                ProgressBar_Fill.Value = (int)((double)(freeSize - totalFreeSpace) / freeSize * 100.0);

                Thread.Sleep(2000);
            }
        }

        private void GetThePartitionNameAndFillTheComboBox()
        {
            ComboBox_PartitionName.DataSource = Environment.GetLogicalDrives();
        }

        private void SetTheControlEnabledState(string str)
        {
            switch (str)
            {
                case "Start":
                    ComboBox_PartitionName.Enabled = false;
                    Button_Fill.Enabled = false;
                    Button_Stop.Enabled = true;
                    Button_Advanced.Enabled = false;
                    Button_ChooseFiles.Enabled = false;
                    ListBox_Files.Enabled = false;
                    Timer.Enabled = true;
                    dateTime = DateTime.Now;
                    break;
                case "Stop":
                    ComboBox_PartitionName.Enabled = true;
                    Button_Fill.Enabled = true;
                    Button_Stop.Enabled = false;
                    Button_Advanced.Enabled = true;
                    Button_ChooseFiles.Enabled = true;
                    ListBox_Files.Enabled = true;
                    Button_Stop.Text = "Stop";
                    Timer.Enabled = false;
                    Label_Time.Text = string.Empty;
                    break;
                case "Stopping":
                    Button_Stop.Text = "Stopping";
                    Button_Stop.Enabled = false;
                    Timer.Enabled = false;
                    Label_Time.Text = string.Empty;
                    break;
            }
        }

        private void CreateThreadsAndBeginToFill()
        {
            driveInfo = new DriveInfo(ComboBox_PartitionName.Text);
            freeSize = driveInfo.TotalFreeSpace;

            _monitor = new Thread(new ThreadStart(GetTheDriveInfoAndSetTheControlValue));
            _monitor.Start();

            if (Button_Advanced.Text == "Advanced")
            {
                FillWithTheRegularValue();
            }
            else
            {
                _fillWithTheSpecifiedFile = new Thread(new ThreadStart(FillWithTheSpecifiedFile));
                _fillWithTheSpecifiedFile.Start();
            }
        }

        private void CloseAllThreads()
        {
            if (Button_Advanced.Text == "Advanced")
            {
                if (_zero == null || _one == null || _monitor == null)
                {
                    return;
                }
                _zero.Abort();
                _one.Abort();
                _monitor.Abort();
                while (true)
                {
                    if (_zero.IsAlive == false && _one.IsAlive == false && _monitor.IsAlive == false)
                    {
                        break;
                    }
                    Thread.Sleep(5000);
                }
            }
            else
            {
                if (_monitor == null || _fillWithTheSpecifiedFile == null)
                {
                    return;
                }
                _monitor.Abort();
                _fillWithTheSpecifiedFile.Abort();
                while (true)
                {
                    if (_monitor.IsAlive == false && _fillWithTheSpecifiedFile.IsAlive == false)
                    {
                        break;
                    }
                    Thread.Sleep(5000);
                }
            }
        }

        private void FillWithTheSpecifiedFile()
        {
            int fileCount = ListBox_Files.Items.Count;
            int index = 0;
            string destFileName;
            while (true)
            {
                if (index == fileCount)
                {
                    index = 0;
                }
                destFileName = driveInfo.Name + DateTime.Now.ToString("yyyyMMddHHmmssff") + ListBox_Files.Items[index].ToString().Remove(0, ListBox_Files.Items[index].ToString().LastIndexOf('\\') + 1);
                try
                {
                    File.Copy(ListBox_Files.Items[index].ToString(), destFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseAllThreads();
                }
                index++;
            }
        }

        private void FillWithTheRegularValue()
        {
            _zero = new Thread(new ThreadStart(FillZero));
            _zero.Start();
            _one = new Thread(new ThreadStart(FillOne));
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
                    fs = new FileStream(driveInfo.Name + "0" + count++, FileMode.OpenOrCreate);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseAllThreads();
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
                    FileStream fs = new FileStream(driveInfo.Name + "1" + count++, FileMode.OpenOrCreate);
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
                Location = new Point(Location.X - 10, Location.Y);
                Width = Width + 20;
                Thread.Sleep(10);
            }
        }

        private void ChangeTheWindowStatusFromAdvancedToNormal()
        {
            for (int i = 0; i < 10; i++)
            {
                Location = new Point(Location.X + 10, Location.Y);
                Width = Width - 20;
                Thread.Sleep(10);
            }
        }

        #endregion

        #region Event Handlers

        private void Button_Fill_Click(object sender, EventArgs e)
        {
            if (Button_Advanced.Text == "Normal" && ListBox_Files.Items.Count == 0)
            {
                MessageBox.Show("Please choose files", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetTheControlEnabledState("Start");
            CreateThreadsAndBeginToFill();
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            SetTheControlEnabledState("Stopping");
            CloseAllThreads();
            SetTheControlEnabledState("Stop");
        }

        private void Button_Advanced_Click(object sender, EventArgs e)
        {
            if (Button_Advanced.Text == "Advanced")
            {
                ChangeTheWindowStatusFromNormalToAdvanced();
                Button_Advanced.Text = "Normal";
            }
            else
            {
                ChangeTheWindowStatusFromAdvancedToNormal();
                Button_Advanced.Text = "Advanced";
            }
        }

        private void Button_ChooseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Please Choose Files",
                Filter = "All Files(*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] path = openFileDialog.FileNames;
                ListBox_Files.DataSource = path;
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ListBox_Files.DataSource = null;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - this.dateTime;
            Label_Time.Text = timeSpan.ToString("g");
        }

        #region Title Bar

        private void Panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Panel_TitleBar_SizeChanged(object sender, EventArgs e)
        {
            Label_Title.Location = new Point((Panel_TitleBar.Width - Label_Title.Width) / 2, 7);
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.Red;
            label.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.FromArgb(250, 250, 250);
            label.ForeColor = Color.Black;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Name.Equals("label_Minimize"))
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (label.Name.Equals("label_Close"))
            {
                CloseAllThreads();
                Close();
            }
        }

        #endregion

        #endregion
    }
}
