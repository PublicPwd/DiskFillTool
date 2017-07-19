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
            this.progressBar_Fill = new System.Windows.Forms.ProgressBar();
            this.comboBox_PartitionName = new System.Windows.Forms.ComboBox();
            this.button_Fill = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_UsedSpaceSize = new System.Windows.Forms.Label();
            this.label_UsedSpacePercentage = new System.Windows.Forms.Label();
            this.progressBar_UsedSpace = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_FreeSpaceSize = new System.Windows.Forms.Label();
            this.label_FreeSpacePercentage = new System.Windows.Forms.Label();
            this.progressBar_FreeSpace = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_TotalSize = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Advanced = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ChooseFiles = new System.Windows.Forms.Button();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Minimize = new System.Windows.Forms.Label();
            this.label_Close = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_Fill
            // 
            this.progressBar_Fill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Fill.Location = new System.Drawing.Point(0, 307);
            this.progressBar_Fill.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Fill.Name = "progressBar_Fill";
            this.progressBar_Fill.Size = new System.Drawing.Size(384, 23);
            this.progressBar_Fill.TabIndex = 0;
            // 
            // comboBox_PartitionName
            // 
            this.comboBox_PartitionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PartitionName.FormattingEnabled = true;
            this.comboBox_PartitionName.Location = new System.Drawing.Point(238, 66);
            this.comboBox_PartitionName.Name = "comboBox_PartitionName";
            this.comboBox_PartitionName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_PartitionName.TabIndex = 1;
            // 
            // button_Fill
            // 
            this.button_Fill.Location = new System.Drawing.Point(238, 108);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(121, 23);
            this.button_Fill.TabIndex = 2;
            this.button_Fill.Text = "Fill";
            this.button_Fill.UseVisualStyleBackColor = true;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_UsedSpaceSize);
            this.groupBox1.Controls.Add(this.label_UsedSpacePercentage);
            this.groupBox1.Controls.Add(this.progressBar_UsedSpace);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Used Space(MB)";
            // 
            // label_UsedSpaceSize
            // 
            this.label_UsedSpaceSize.AutoSize = true;
            this.label_UsedSpaceSize.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UsedSpaceSize.Location = new System.Drawing.Point(6, 32);
            this.label_UsedSpaceSize.Name = "label_UsedSpaceSize";
            this.label_UsedSpaceSize.Size = new System.Drawing.Size(16, 16);
            this.label_UsedSpaceSize.TabIndex = 4;
            this.label_UsedSpaceSize.Text = "0";
            // 
            // label_UsedSpacePercentage
            // 
            this.label_UsedSpacePercentage.AutoSize = true;
            this.label_UsedSpacePercentage.Location = new System.Drawing.Point(165, 76);
            this.label_UsedSpacePercentage.Name = "label_UsedSpacePercentage";
            this.label_UsedSpacePercentage.Size = new System.Drawing.Size(17, 12);
            this.label_UsedSpacePercentage.TabIndex = 1;
            this.label_UsedSpacePercentage.Text = "0%";
            // 
            // progressBar_UsedSpace
            // 
            this.progressBar_UsedSpace.Location = new System.Drawing.Point(6, 71);
            this.progressBar_UsedSpace.Name = "progressBar_UsedSpace";
            this.progressBar_UsedSpace.Size = new System.Drawing.Size(153, 23);
            this.progressBar_UsedSpace.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_FreeSpaceSize);
            this.groupBox2.Controls.Add(this.label_FreeSpacePercentage);
            this.groupBox2.Controls.Add(this.progressBar_FreeSpace);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Free Space(MB)";
            // 
            // label_FreeSpaceSize
            // 
            this.label_FreeSpaceSize.AutoSize = true;
            this.label_FreeSpaceSize.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_FreeSpaceSize.Location = new System.Drawing.Point(6, 34);
            this.label_FreeSpaceSize.Name = "label_FreeSpaceSize";
            this.label_FreeSpaceSize.Size = new System.Drawing.Size(16, 16);
            this.label_FreeSpaceSize.TabIndex = 1;
            this.label_FreeSpaceSize.Text = "0";
            // 
            // label_FreeSpacePercentage
            // 
            this.label_FreeSpacePercentage.AutoSize = true;
            this.label_FreeSpacePercentage.Location = new System.Drawing.Point(165, 76);
            this.label_FreeSpacePercentage.Name = "label_FreeSpacePercentage";
            this.label_FreeSpacePercentage.Size = new System.Drawing.Size(17, 12);
            this.label_FreeSpacePercentage.TabIndex = 3;
            this.label_FreeSpacePercentage.Text = "0%";
            // 
            // progressBar_FreeSpace
            // 
            this.progressBar_FreeSpace.BackColor = System.Drawing.Color.White;
            this.progressBar_FreeSpace.Location = new System.Drawing.Point(6, 71);
            this.progressBar_FreeSpace.Name = "progressBar_FreeSpace";
            this.progressBar_FreeSpace.Size = new System.Drawing.Size(153, 23);
            this.progressBar_FreeSpace.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_TotalSize);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Size(MB)";
            // 
            // label_TotalSize
            // 
            this.label_TotalSize.AutoSize = true;
            this.label_TotalSize.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TotalSize.Location = new System.Drawing.Point(6, 26);
            this.label_TotalSize.Name = "label_TotalSize";
            this.label_TotalSize.Size = new System.Drawing.Size(16, 16);
            this.label_TotalSize.TabIndex = 0;
            this.label_TotalSize.Text = "0";
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(238, 244);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(121, 23);
            this.button_Stop.TabIndex = 6;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Advanced
            // 
            this.button_Advanced.Location = new System.Drawing.Point(238, 181);
            this.button_Advanced.Name = "button_Advanced";
            this.button_Advanced.Size = new System.Drawing.Size(121, 23);
            this.button_Advanced.TabIndex = 7;
            this.button_Advanced.Text = "Advanced";
            this.button_Advanced.UseVisualStyleBackColor = true;
            this.button_Advanced.Click += new System.EventHandler(this.button_Advanced_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fill with the specified file";
            // 
            // button_ChooseFiles
            // 
            this.button_ChooseFiles.Location = new System.Drawing.Point(401, 63);
            this.button_ChooseFiles.Name = "button_ChooseFiles";
            this.button_ChooseFiles.Size = new System.Drawing.Size(121, 23);
            this.button_ChooseFiles.TabIndex = 9;
            this.button_ChooseFiles.Text = "Choose files";
            this.button_ChooseFiles.UseVisualStyleBackColor = true;
            this.button_ChooseFiles.Click += new System.EventHandler(this.button_ChooseFiles_Click);
            // 
            // listBox_Files
            // 
            this.listBox_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listBox_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.HorizontalScrollbar = true;
            this.listBox_Files.ItemHeight = 12;
            this.listBox_Files.Location = new System.Drawing.Point(401, 93);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(171, 206);
            this.listBox_Files.TabIndex = 10;
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_TitleBar.Controls.Add(this.panel1);
            this.panel_TitleBar.Controls.Add(this.label_Minimize);
            this.panel_TitleBar.Controls.Add(this.label_Close);
            this.panel_TitleBar.Controls.Add(this.label_Title);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(384, 25);
            this.panel_TitleBar.TabIndex = 11;
            this.panel_TitleBar.SizeChanged += new System.EventHandler(this.panel_TitleBar_SizeChanged);
            this.panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 1);
            this.panel1.TabIndex = 12;
            // 
            // label_Minimize
            // 
            this.label_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Minimize.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Minimize.ForeColor = System.Drawing.Color.Black;
            this.label_Minimize.Location = new System.Drawing.Point(334, 0);
            this.label_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.label_Minimize.Name = "label_Minimize";
            this.label_Minimize.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.label_Minimize.Size = new System.Drawing.Size(25, 25);
            this.label_Minimize.TabIndex = 2;
            this.label_Minimize.Text = "—";
            this.label_Minimize.Click += new System.EventHandler(this.label_Click);
            this.label_Minimize.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Minimize.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_Close
            // 
            this.label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Close.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Close.ForeColor = System.Drawing.Color.Black;
            this.label_Close.Location = new System.Drawing.Point(359, 0);
            this.label_Close.Margin = new System.Windows.Forms.Padding(0);
            this.label_Close.Name = "label_Close";
            this.label_Close.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_Close.Size = new System.Drawing.Size(25, 25);
            this.label_Close.TabIndex = 1;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Click);
            this.label_Close.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Close.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(3, 7);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(89, 12);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Disk Fill Tool";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(528, 63);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(44, 23);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.listBox_Files);
            this.Controls.Add(this.button_ChooseFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Advanced);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Fill);
            this.Controls.Add(this.comboBox_PartitionName);
            this.Controls.Add(this.progressBar_Fill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Fill Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_TitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_Fill;
        private System.Windows.Forms.ComboBox comboBox_PartitionName;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_UsedSpacePercentage;
        private System.Windows.Forms.ProgressBar progressBar_UsedSpace;
        private System.Windows.Forms.Label label_FreeSpacePercentage;
        private System.Windows.Forms.ProgressBar progressBar_FreeSpace;
        private System.Windows.Forms.Label label_TotalSize;
        private System.Windows.Forms.Label label_UsedSpaceSize;
        private System.Windows.Forms.Label label_FreeSpaceSize;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Advanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ChooseFiles;
        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label_Minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Clear;
    }
}

