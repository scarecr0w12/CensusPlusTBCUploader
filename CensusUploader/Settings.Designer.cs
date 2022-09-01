namespace WowPopUploader
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tbWowPath = new System.Windows.Forms.TextBox();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAtStartup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudUploadTreshold = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLastTimesInserted = new System.Windows.Forms.Label();
            this.lblLastCharsUpdated = new System.Windows.Forms.Label();
            this.lblLastCharsIInserted = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastUpload = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTimesInserted = new System.Windows.Forms.Label();
            this.lblCharsUpdated = new System.Windows.Forms.Label();
            this.lblCharsIInserted = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadTreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WowPopUploader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings / Stats";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "CensusPlusWotlk.lua";
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // tbWowPath
            // 
            this.tbWowPath.Location = new System.Drawing.Point(6, 42);
            this.tbWowPath.Name = "tbWowPath";
            this.tbWowPath.ReadOnly = true;
            this.tbWowPath.Size = new System.Drawing.Size(238, 20);
            this.tbWowPath.TabIndex = 1;
            // 
            // btnChangePath
            // 
            this.btnChangePath.Location = new System.Drawing.Point(250, 40);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(75, 23);
            this.btnChangePath.TabIndex = 2;
            this.btnChangePath.Text = "Change";
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select ..\\World of Warcraft\\_classic_ directory";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(269, 301);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAtStartup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudUploadTreshold);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbWowPath);
            this.groupBox1.Controls.Add(this.btnChangePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cbAtStartup
            // 
            this.cbAtStartup.AutoSize = true;
            this.cbAtStartup.Checked = true;
            this.cbAtStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtStartup.Location = new System.Drawing.Point(6, 123);
            this.cbAtStartup.Name = "cbAtStartup";
            this.cbAtStartup.Size = new System.Drawing.Size(153, 17);
            this.cbAtStartup.TabIndex = 6;
            this.cbAtStartup.Text = "Launch at windows startup";
            this.cbAtStartup.UseVisualStyleBackColor = true;
            this.cbAtStartup.CheckedChanged += new System.EventHandler(this.cbAtStartup_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Upload treshold in minutes";
            // 
            // nudUploadTreshold
            // 
            this.nudUploadTreshold.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUploadTreshold.Location = new System.Drawing.Point(6, 92);
            this.nudUploadTreshold.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudUploadTreshold.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudUploadTreshold.Name = "nudUploadTreshold";
            this.nudUploadTreshold.Size = new System.Drawing.Size(85, 20);
            this.nudUploadTreshold.TabIndex = 4;
            this.nudUploadTreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUploadTreshold.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudUploadTreshold.ValueChanged += new System.EventHandler(this.nudUploadTreshold_ValueChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select ..\\World of Warcraft\\_classic_ directory";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLastTimesInserted);
            this.groupBox2.Controls.Add(this.lblLastCharsUpdated);
            this.groupBox2.Controls.Add(this.lblLastCharsIInserted);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblLastUpload);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTimesInserted);
            this.groupBox2.Controls.Add(this.lblCharsUpdated);
            this.groupBox2.Controls.Add(this.lblCharsIInserted);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // lblLastTimesInserted
            // 
            this.lblLastTimesInserted.Location = new System.Drawing.Point(92, 62);
            this.lblLastTimesInserted.Name = "lblLastTimesInserted";
            this.lblLastTimesInserted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastTimesInserted.Size = new System.Drawing.Size(50, 13);
            this.lblLastTimesInserted.TabIndex = 12;
            this.lblLastTimesInserted.Text = "9";
            this.lblLastTimesInserted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastCharsUpdated
            // 
            this.lblLastCharsUpdated.Location = new System.Drawing.Point(92, 45);
            this.lblLastCharsUpdated.Name = "lblLastCharsUpdated";
            this.lblLastCharsUpdated.Size = new System.Drawing.Size(50, 13);
            this.lblLastCharsUpdated.TabIndex = 11;
            this.lblLastCharsUpdated.Text = "999";
            this.lblLastCharsUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastCharsIInserted
            // 
            this.lblLastCharsIInserted.Location = new System.Drawing.Point(92, 28);
            this.lblLastCharsIInserted.Name = "lblLastCharsIInserted";
            this.lblLastCharsIInserted.Size = new System.Drawing.Size(50, 13);
            this.lblLastCharsIInserted.TabIndex = 10;
            this.lblLastCharsIInserted.Text = "999999";
            this.lblLastCharsIInserted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Last";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastUpload
            // 
            this.lblLastUpload.AutoSize = true;
            this.lblLastUpload.Location = new System.Drawing.Point(90, 91);
            this.lblLastUpload.Name = "lblLastUpload";
            this.lblLastUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastUpload.Size = new System.Drawing.Size(13, 13);
            this.lblLastUpload.TabIndex = 7;
            this.lblLastUpload.Text = "9";
            this.lblLastUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last upload:";
            // 
            // lblTimesInserted
            // 
            this.lblTimesInserted.Location = new System.Drawing.Point(166, 62);
            this.lblTimesInserted.Name = "lblTimesInserted";
            this.lblTimesInserted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimesInserted.Size = new System.Drawing.Size(50, 13);
            this.lblTimesInserted.TabIndex = 5;
            this.lblTimesInserted.Text = "9";
            this.lblTimesInserted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharsUpdated
            // 
            this.lblCharsUpdated.Location = new System.Drawing.Point(166, 45);
            this.lblCharsUpdated.Name = "lblCharsUpdated";
            this.lblCharsUpdated.Size = new System.Drawing.Size(50, 13);
            this.lblCharsUpdated.TabIndex = 4;
            this.lblCharsUpdated.Text = "999";
            this.lblCharsUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharsIInserted
            // 
            this.lblCharsIInserted.Location = new System.Drawing.Point(166, 28);
            this.lblCharsIInserted.Name = "lblCharsIInserted";
            this.lblCharsIInserted.Size = new System.Drawing.Size(50, 13);
            this.lblCharsIInserted.TabIndex = 3;
            this.lblCharsIInserted.Text = "999999";
            this.lblCharsIInserted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Times inserted:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chars updated:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chars inserted:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.Resize += new System.EventHandler(this.Settings_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadTreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.TextBox tbWowPath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudUploadTreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox cbAtStartup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCharsUpdated;
        private System.Windows.Forms.Label lblCharsIInserted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimesInserted;
        private System.Windows.Forms.Label lblLastUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastTimesInserted;
        private System.Windows.Forms.Label lblLastCharsUpdated;
        private System.Windows.Forms.Label lblLastCharsIInserted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}