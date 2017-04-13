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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar_Fill
            // 
            this.progressBar_Fill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_Fill.Location = new System.Drawing.Point(0, 288);
            this.progressBar_Fill.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Fill.Name = "progressBar_Fill";
            this.progressBar_Fill.Size = new System.Drawing.Size(384, 23);
            this.progressBar_Fill.TabIndex = 0;
            // 
            // comboBox_PartitionName
            // 
            this.comboBox_PartitionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PartitionName.FormattingEnabled = true;
            this.comboBox_PartitionName.Location = new System.Drawing.Point(238, 47);
            this.comboBox_PartitionName.Name = "comboBox_PartitionName";
            this.comboBox_PartitionName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_PartitionName.TabIndex = 1;
            // 
            // button_Fill
            // 
            this.button_Fill.Location = new System.Drawing.Point(238, 89);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
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
            this.progressBar_FreeSpace.Location = new System.Drawing.Point(6, 71);
            this.progressBar_FreeSpace.Name = "progressBar_FreeSpace";
            this.progressBar_FreeSpace.Size = new System.Drawing.Size(153, 23);
            this.progressBar_FreeSpace.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_TotalSize);
            this.groupBox3.Location = new System.Drawing.Point(12, 225);
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
            this.button_Stop.Location = new System.Drawing.Point(238, 225);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(121, 23);
            this.button_Stop.TabIndex = 6;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Advanced
            // 
            this.button_Advanced.Location = new System.Drawing.Point(238, 162);
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
            this.label1.Location = new System.Drawing.Point(399, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fill with the specified file";
            // 
            // button_ChooseFiles
            // 
            this.button_ChooseFiles.Location = new System.Drawing.Point(423, 44);
            this.button_ChooseFiles.Name = "button_ChooseFiles";
            this.button_ChooseFiles.Size = new System.Drawing.Size(121, 23);
            this.button_ChooseFiles.TabIndex = 9;
            this.button_ChooseFiles.Text = "Choose files";
            this.button_ChooseFiles.UseVisualStyleBackColor = true;
            this.button_ChooseFiles.Click += new System.EventHandler(this.button_ChooseFiles_Click);
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.HorizontalScrollbar = true;
            this.listBox_Files.ItemHeight = 12;
            this.listBox_Files.Location = new System.Drawing.Point(401, 74);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(171, 208);
            this.listBox_Files.TabIndex = 10;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk Fill Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
    }
}

