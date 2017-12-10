namespace BurnMedia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.tabPageFormat = new System.Windows.Forms.TabPage();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.labelFormatStatusText = new System.Windows.Forms.Label();
            this.formatProgressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxEjectFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxQuickFormat = new System.Windows.Forms.CheckBox();
            this.tabPageBurn = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.buttonBurn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDetectMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.progressBarCapacity = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveFiles = new System.Windows.Forms.Button();
            this.buttonAddFolders = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBurn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(6, 19);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(154, 21);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.devicesComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            this.backgroundBurnWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBurnWorker_DoWork);
            this.backgroundBurnWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBurnWorker_ProgressChanged);
            this.backgroundBurnWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBurnWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // backgroundFormatWorker
            // 
            this.backgroundFormatWorker.WorkerReportsProgress = true;
            this.backgroundFormatWorker.WorkerSupportsCancellation = true;
            this.backgroundFormatWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundFormatWorker_DoWork);
            this.backgroundFormatWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundFormatWorker_ProgressChanged);
            this.backgroundFormatWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundFormatWorker_RunWorkerCompleted);
            // 
            // tabPageFormat
            // 
            this.tabPageFormat.Location = new System.Drawing.Point(0, 0);
            this.tabPageFormat.Name = "tabPageFormat";
            this.tabPageFormat.Size = new System.Drawing.Size(200, 100);
            this.tabPageFormat.TabIndex = 0;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(0, 0);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(75, 23);
            this.buttonFormat.TabIndex = 0;
            // 
            // labelFormatStatusText
            // 
            this.labelFormatStatusText.Location = new System.Drawing.Point(125, 160);
            this.labelFormatStatusText.Name = "labelFormatStatusText";
            this.labelFormatStatusText.Size = new System.Drawing.Size(321, 55);
            this.labelFormatStatusText.TabIndex = 11;
            this.labelFormatStatusText.Text = "status";
            this.labelFormatStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // formatProgressBar
            // 
            this.formatProgressBar.Location = new System.Drawing.Point(126, 222);
            this.formatProgressBar.Name = "formatProgressBar";
            this.formatProgressBar.Size = new System.Drawing.Size(318, 16);
            this.formatProgressBar.TabIndex = 13;
            // 
            // checkBoxEjectFormat
            // 
            this.checkBoxEjectFormat.AutoSize = true;
            this.checkBoxEjectFormat.Checked = true;
            this.checkBoxEjectFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEjectFormat.Location = new System.Drawing.Point(226, 28);
            this.checkBoxEjectFormat.Name = "checkBoxEjectFormat";
            this.checkBoxEjectFormat.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEjectFormat.TabIndex = 12;
            this.checkBoxEjectFormat.Text = "Eject when finished";
            this.checkBoxEjectFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(226, 52);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(89, 17);
            this.checkBoxQuickFormat.TabIndex = 14;
            this.checkBoxQuickFormat.Text = "Quick Format";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // tabPageBurn
            // 
            this.tabPageBurn.Controls.Add(this.groupBox3);
            this.tabPageBurn.Controls.Add(this.groupBox2);
            this.tabPageBurn.Controls.Add(this.groupBox1);
            this.tabPageBurn.Location = new System.Drawing.Point(4, 22);
            this.tabPageBurn.Name = "tabPageBurn";
            this.tabPageBurn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBurn.Size = new System.Drawing.Size(610, 240);
            this.tabPageBurn.TabIndex = 0;
            this.tabPageBurn.Text = "Burn Files";
            this.tabPageBurn.UseVisualStyleBackColor = true;
            this.tabPageBurn.Click += new System.EventHandler(this.tabPageBurn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusProgressBar);
            this.groupBox3.Controls.Add(this.labelStatusText);
            this.groupBox3.Controls.Add(this.buttonBurn);
            this.groupBox3.Location = new System.Drawing.Point(11, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 91);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прогресс";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(12, 57);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(472, 16);
            this.statusProgressBar.TabIndex = 8;
            // 
            // labelStatusText
            // 
            this.labelStatusText.Location = new System.Drawing.Point(9, 18);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(475, 22);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "status";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonBurn
            // 
            this.buttonBurn.Location = new System.Drawing.Point(500, 43);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(88, 30);
            this.buttonBurn.TabIndex = 6;
            this.buttonBurn.Text = "&Запись";
            this.buttonBurn.UseVisualStyleBackColor = true;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDetectMedia);
            this.groupBox2.Controls.Add(this.devicesComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelTotalSize);
            this.groupBox2.Controls.Add(this.progressBarCapacity);
            this.groupBox2.Location = new System.Drawing.Point(436, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Устройство:";
            // 
            // buttonDetectMedia
            // 
            this.buttonDetectMedia.Location = new System.Drawing.Point(6, 46);
            this.buttonDetectMedia.Name = "buttonDetectMedia";
            this.buttonDetectMedia.Size = new System.Drawing.Size(98, 28);
            this.buttonDetectMedia.TabIndex = 9;
            this.buttonDetectMedia.Text = "Detect Media";
            this.buttonDetectMedia.UseVisualStyleBackColor = true;
            this.buttonDetectMedia.Click += new System.EventHandler(this.buttonDetectMedia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSize.AutoSize = true;
            this.labelTotalSize.Location = new System.Drawing.Point(116, 88);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(47, 13);
            this.labelTotalSize.TabIndex = 7;
            this.labelTotalSize.Text = "totalSize";
            this.labelTotalSize.Click += new System.EventHandler(this.labelTotalSize_Click);
            // 
            // progressBarCapacity
            // 
            this.progressBarCapacity.Location = new System.Drawing.Point(6, 104);
            this.progressBarCapacity.Name = "progressBarCapacity";
            this.progressBarCapacity.Size = new System.Drawing.Size(154, 12);
            this.progressBarCapacity.Step = 1;
            this.progressBarCapacity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCapacity.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonRemoveFiles);
            this.groupBox1.Controls.Add(this.buttonAddFolders);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(299, 81);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(114, 20);
            this.textBoxLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Label:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonRemoveFiles
            // 
            this.buttonRemoveFiles.Location = new System.Drawing.Point(176, 77);
            this.buttonRemoveFiles.Name = "buttonRemoveFiles";
            this.buttonRemoveFiles.Size = new System.Drawing.Size(75, 27);
            this.buttonRemoveFiles.TabIndex = 3;
            this.buttonRemoveFiles.Text = "&Удалить";
            this.buttonRemoveFiles.UseVisualStyleBackColor = true;
            this.buttonRemoveFiles.Click += new System.EventHandler(this.buttonRemoveFiles_Click);
            // 
            // buttonAddFolders
            // 
            this.buttonAddFolders.Location = new System.Drawing.Point(89, 77);
            this.buttonAddFolders.Name = "buttonAddFolders";
            this.buttonAddFolders.Size = new System.Drawing.Size(81, 27);
            this.buttonAddFolders.TabIndex = 2;
            this.buttonAddFolders.Text = "&+ папка";
            this.buttonAddFolders.UseVisualStyleBackColor = true;
            this.buttonAddFolders.Click += new System.EventHandler(this.buttonAddFolders_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(10, 77);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(73, 27);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "&+ файл";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(10, 19);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(403, 52);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBurn);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 266);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 275);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BurnMedia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPageBurn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.TabPage tabPageFormat;
        private System.Windows.Forms.CheckBox checkBoxQuickFormat;
        private System.Windows.Forms.CheckBox checkBoxEjectFormat;
        private System.Windows.Forms.ProgressBar formatProgressBar;
        private System.Windows.Forms.Label labelFormatStatusText;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.TabPage tabPageBurn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Button buttonBurn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDetectMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.ProgressBar progressBarCapacity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveFiles;
        private System.Windows.Forms.Button buttonAddFolders;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

