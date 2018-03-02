namespace DiskFillTool
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProgressBar_Fill = new System.Windows.Forms.ProgressBar();
            this.ComboBox_PartitionName = new System.Windows.Forms.ComboBox();
            this.Button_Fill = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_UsedSpaceSize = new System.Windows.Forms.Label();
            this.Label_UsedSpacePercentage = new System.Windows.Forms.Label();
            this.ProgressBar_UsedSpace = new System.Windows.Forms.ProgressBar();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label_FreeSpaceSize = new System.Windows.Forms.Label();
            this.Label_FreeSpacePercentage = new System.Windows.Forms.Label();
            this.ProgressBar_FreeSpace = new System.Windows.Forms.ProgressBar();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label_TotalSize = new System.Windows.Forms.Label();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Button_Advanced = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button_ChooseFiles = new System.Windows.Forms.Button();
            this.ListBox_Files = new System.Windows.Forms.ListBox();
            this.Panel_TitleBar = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label_Minimize = new System.Windows.Forms.Label();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Label_Time = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.Panel_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_Fill
            // 
            this.ProgressBar_Fill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar_Fill.Location = new System.Drawing.Point(0, 307);
            this.ProgressBar_Fill.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBar_Fill.Name = "progressBar_Fill";
            this.ProgressBar_Fill.Size = new System.Drawing.Size(384, 23);
            this.ProgressBar_Fill.TabIndex = 0;
            // 
            // comboBox_PartitionName
            // 
            this.ComboBox_PartitionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PartitionName.FormattingEnabled = true;
            this.ComboBox_PartitionName.Location = new System.Drawing.Point(238, 66);
            this.ComboBox_PartitionName.Name = "comboBox_PartitionName";
            this.ComboBox_PartitionName.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_PartitionName.TabIndex = 1;
            // 
            // button_Fill
            // 
            this.Button_Fill.Location = new System.Drawing.Point(238, 108);
            this.Button_Fill.Name = "button_Fill";
            this.Button_Fill.Size = new System.Drawing.Size(121, 23);
            this.Button_Fill.TabIndex = 2;
            this.Button_Fill.Text = "Fill";
            this.Button_Fill.UseVisualStyleBackColor = true;
            this.Button_Fill.Click += new System.EventHandler(this.Button_Fill_Click);
            // 
            // groupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label_UsedSpaceSize);
            this.GroupBox1.Controls.Add(this.Label_UsedSpacePercentage);
            this.GroupBox1.Controls.Add(this.ProgressBar_UsedSpace);
            this.GroupBox1.Location = new System.Drawing.Point(12, 137);
            this.GroupBox1.Name = "groupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 100);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Used Space(MB)";
            // 
            // label_UsedSpaceSize
            // 
            this.Label_UsedSpaceSize.AutoSize = true;
            this.Label_UsedSpaceSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_UsedSpaceSize.Location = new System.Drawing.Point(6, 32);
            this.Label_UsedSpaceSize.Name = "label_UsedSpaceSize";
            this.Label_UsedSpaceSize.Size = new System.Drawing.Size(16, 16);
            this.Label_UsedSpaceSize.TabIndex = 4;
            this.Label_UsedSpaceSize.Text = "0";
            // 
            // label_UsedSpacePercentage
            // 
            this.Label_UsedSpacePercentage.AutoSize = true;
            this.Label_UsedSpacePercentage.Location = new System.Drawing.Point(165, 76);
            this.Label_UsedSpacePercentage.Name = "label_UsedSpacePercentage";
            this.Label_UsedSpacePercentage.Size = new System.Drawing.Size(17, 12);
            this.Label_UsedSpacePercentage.TabIndex = 1;
            this.Label_UsedSpacePercentage.Text = "0%";
            // 
            // progressBar_UsedSpace
            // 
            this.ProgressBar_UsedSpace.Location = new System.Drawing.Point(6, 71);
            this.ProgressBar_UsedSpace.Name = "progressBar_UsedSpace";
            this.ProgressBar_UsedSpace.Size = new System.Drawing.Size(153, 23);
            this.ProgressBar_UsedSpace.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label_FreeSpaceSize);
            this.GroupBox2.Controls.Add(this.Label_FreeSpacePercentage);
            this.GroupBox2.Controls.Add(this.ProgressBar_FreeSpace);
            this.GroupBox2.Location = new System.Drawing.Point(12, 31);
            this.GroupBox2.Name = "groupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(200, 100);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Free Space(MB)";
            // 
            // Label_FreeSpaceSize
            // 
            this.Label_FreeSpaceSize.AutoSize = true;
            this.Label_FreeSpaceSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FreeSpaceSize.Location = new System.Drawing.Point(6, 34);
            this.Label_FreeSpaceSize.Name = "Label_FreeSpaceSize";
            this.Label_FreeSpaceSize.Size = new System.Drawing.Size(16, 16);
            this.Label_FreeSpaceSize.TabIndex = 1;
            this.Label_FreeSpaceSize.Text = "0";
            // 
            // Label_FreeSpacePercentage
            // 
            this.Label_FreeSpacePercentage.AutoSize = true;
            this.Label_FreeSpacePercentage.Location = new System.Drawing.Point(165, 76);
            this.Label_FreeSpacePercentage.Name = "Label_FreeSpacePercentage";
            this.Label_FreeSpacePercentage.Size = new System.Drawing.Size(17, 12);
            this.Label_FreeSpacePercentage.TabIndex = 3;
            this.Label_FreeSpacePercentage.Text = "0%";
            // 
            // ProgressBar_FreeSpace
            // 
            this.ProgressBar_FreeSpace.BackColor = System.Drawing.Color.White;
            this.ProgressBar_FreeSpace.Location = new System.Drawing.Point(6, 71);
            this.ProgressBar_FreeSpace.Name = "ProgressBar_FreeSpace";
            this.ProgressBar_FreeSpace.Size = new System.Drawing.Size(153, 23);
            this.ProgressBar_FreeSpace.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label_TotalSize);
            this.GroupBox3.Location = new System.Drawing.Point(12, 244);
            this.GroupBox3.Name = "groupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(200, 60);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Total Size(MB)";
            // 
            // label_TotalSize
            // 
            this.Label_TotalSize.AutoSize = true;
            this.Label_TotalSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_TotalSize.Location = new System.Drawing.Point(6, 26);
            this.Label_TotalSize.Name = "label_TotalSize";
            this.Label_TotalSize.Size = new System.Drawing.Size(16, 16);
            this.Label_TotalSize.TabIndex = 0;
            this.Label_TotalSize.Text = "0";
            // 
            // button_Stop
            // 
            this.Button_Stop.Enabled = false;
            this.Button_Stop.Location = new System.Drawing.Point(238, 244);
            this.Button_Stop.Name = "button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(121, 23);
            this.Button_Stop.TabIndex = 6;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // button_Advanced
            // 
            this.Button_Advanced.Location = new System.Drawing.Point(238, 181);
            this.Button_Advanced.Name = "button_Advanced";
            this.Button_Advanced.Size = new System.Drawing.Size(121, 23);
            this.Button_Advanced.TabIndex = 7;
            this.Button_Advanced.Text = "Advanced";
            this.Button_Advanced.UseVisualStyleBackColor = true;
            this.Button_Advanced.Click += new System.EventHandler(this.Button_Advanced_Click);
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(399, 31);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(173, 12);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Fill with the specified file";
            // 
            // button_ChooseFiles
            // 
            this.Button_ChooseFiles.Location = new System.Drawing.Point(401, 63);
            this.Button_ChooseFiles.Name = "button_ChooseFiles";
            this.Button_ChooseFiles.Size = new System.Drawing.Size(121, 23);
            this.Button_ChooseFiles.TabIndex = 9;
            this.Button_ChooseFiles.Text = "Choose files";
            this.Button_ChooseFiles.UseVisualStyleBackColor = true;
            this.Button_ChooseFiles.Click += new System.EventHandler(this.Button_ChooseFiles_Click);
            // 
            // listBox_Files
            // 
            this.ListBox_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ListBox_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Files.FormattingEnabled = true;
            this.ListBox_Files.HorizontalScrollbar = true;
            this.ListBox_Files.ItemHeight = 12;
            this.ListBox_Files.Location = new System.Drawing.Point(401, 93);
            this.ListBox_Files.Name = "listBox_Files";
            this.ListBox_Files.Size = new System.Drawing.Size(171, 206);
            this.ListBox_Files.TabIndex = 10;
            // 
            // panel_TitleBar
            // 
            this.Panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Panel_TitleBar.Controls.Add(this.Panel1);
            this.Panel_TitleBar.Controls.Add(this.Label_Minimize);
            this.Panel_TitleBar.Controls.Add(this.Label_Close);
            this.Panel_TitleBar.Controls.Add(this.Label_Title);
            this.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_TitleBar.Name = "panel_TitleBar";
            this.Panel_TitleBar.Size = new System.Drawing.Size(384, 25);
            this.Panel_TitleBar.TabIndex = 11;
            this.Panel_TitleBar.SizeChanged += new System.EventHandler(this.Panel_TitleBar_SizeChanged);
            this.Panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_TitleBar_MouseDown);
            // 
            // panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Location = new System.Drawing.Point(0, 24);
            this.Panel1.Name = "panel1";
            this.Panel1.Size = new System.Drawing.Size(384, 1);
            this.Panel1.TabIndex = 12;
            // 
            // label_Minimize
            // 
            this.Label_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_Minimize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Minimize.ForeColor = System.Drawing.Color.Black;
            this.Label_Minimize.Location = new System.Drawing.Point(334, 0);
            this.Label_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Minimize.Name = "label_Minimize";
            this.Label_Minimize.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.Label_Minimize.Size = new System.Drawing.Size(25, 25);
            this.Label_Minimize.TabIndex = 2;
            this.Label_Minimize.Text = "—";
            this.Label_Minimize.Click += new System.EventHandler(this.Label_Click);
            this.Label_Minimize.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.Label_Minimize.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // label_Close
            // 
            this.Label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Label_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_Close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Close.ForeColor = System.Drawing.Color.Black;
            this.Label_Close.Location = new System.Drawing.Point(359, 0);
            this.Label_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Close.Name = "label_Close";
            this.Label_Close.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Label_Close.Size = new System.Drawing.Size(25, 25);
            this.Label_Close.TabIndex = 1;
            this.Label_Close.Text = "X";
            this.Label_Close.Click += new System.EventHandler(this.Label_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Location = new System.Drawing.Point(3, 7);
            this.Label_Title.Name = "label_Title";
            this.Label_Title.Size = new System.Drawing.Size(89, 12);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Disk Fill Tool";
            // 
            // button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(528, 63);
            this.Button_Clear.Name = "button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(44, 23);
            this.Button_Clear.TabIndex = 12;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Location = new System.Drawing.Point(218, 292);
            this.Label_Time.Name = "label_Time";
            this.Label_Time.Size = new System.Drawing.Size(0, 12);
            this.Label_Time.TabIndex = 13;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Panel_TitleBar);
            this.Controls.Add(this.ListBox_Files);
            this.Controls.Add(this.Button_ChooseFiles);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button_Advanced);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button_Fill);
            this.Controls.Add(this.ComboBox_PartitionName);
            this.Controls.Add(this.ProgressBar_Fill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Fill Tool";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_TitleBar_MouseDown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.Panel_TitleBar.ResumeLayout(false);
            this.Panel_TitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar_Fill;
        private System.Windows.Forms.ComboBox ComboBox_PartitionName;
        private System.Windows.Forms.Button Button_Fill;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Label Label_UsedSpacePercentage;
        private System.Windows.Forms.ProgressBar ProgressBar_UsedSpace;
        private System.Windows.Forms.Label Label_FreeSpacePercentage;
        private System.Windows.Forms.ProgressBar ProgressBar_FreeSpace;
        private System.Windows.Forms.Label Label_TotalSize;
        private System.Windows.Forms.Label Label_UsedSpaceSize;
        private System.Windows.Forms.Label Label_FreeSpaceSize;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Button Button_Advanced;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Button_ChooseFiles;
        private System.Windows.Forms.ListBox ListBox_Files;
        private System.Windows.Forms.Panel Panel_TitleBar;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label Label_Minimize;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Label_Time;
    }
}

