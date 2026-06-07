namespace BetterPc
{
    partial class DeleteFoldersForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonMemoryDumps = new System.Windows.Forms.Button();
            this.checkBoxBrowersCache = new System.Windows.Forms.CheckBox();
            this.checkBoxMemoryDump = new System.Windows.Forms.CheckBox();
            this.prefetchButton = new System.Windows.Forms.Button();
            this.userTempCashButton = new System.Windows.Forms.Button();
            this.tempButton = new System.Windows.Forms.Button();
            this.checkBoxPrefetch = new System.Windows.Forms.CheckBox();
            this.checkBoxTempWithPercent = new System.Windows.Forms.CheckBox();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelSizeCanBeDeleted = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelFilesCountDeleted = new System.Windows.Forms.Label();
            this.labelFilesSizeDeteted = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelFilesCount = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonMemoryDumps);
            this.panelButtons.Controls.Add(this.checkBoxBrowersCache);
            this.panelButtons.Controls.Add(this.checkBoxMemoryDump);
            this.panelButtons.Controls.Add(this.prefetchButton);
            this.panelButtons.Controls.Add(this.userTempCashButton);
            this.panelButtons.Controls.Add(this.tempButton);
            this.panelButtons.Controls.Add(this.checkBoxPrefetch);
            this.panelButtons.Controls.Add(this.checkBoxTempWithPercent);
            this.panelButtons.Controls.Add(this.checkBoxTemp);
            this.panelButtons.Controls.Add(this.checkBoxAll);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(505, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(5);
            this.panelButtons.Size = new System.Drawing.Size(278, 322);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonMemoryDumps
            // 
            this.buttonMemoryDumps.Location = new System.Drawing.Point(185, 229);
            this.buttonMemoryDumps.Name = "buttonMemoryDumps";
            this.buttonMemoryDumps.Size = new System.Drawing.Size(81, 29);
            this.buttonMemoryDumps.TabIndex = 11;
            this.buttonMemoryDumps.Text = "Open";
            this.buttonMemoryDumps.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMemoryDumps.UseVisualStyleBackColor = true;
            this.buttonMemoryDumps.Click += new System.EventHandler(this.buttonMemoryDumps_Click);
            // 
            // checkBoxBrowersCache
            // 
            this.checkBoxBrowersCache.AutoSize = true;
            this.checkBoxBrowersCache.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxBrowersCache.Enabled = false;
            this.checkBoxBrowersCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBrowersCache.Location = new System.Drawing.Point(5, 249);
            this.checkBoxBrowersCache.Name = "checkBoxBrowersCache";
            this.checkBoxBrowersCache.Padding = new System.Windows.Forms.Padding(3);
            this.checkBoxBrowersCache.Size = new System.Drawing.Size(268, 35);
            this.checkBoxBrowersCache.TabIndex = 9;
            this.checkBoxBrowersCache.Text = "Browser Cache";
            this.checkBoxBrowersCache.UseVisualStyleBackColor = true;
            // 
            // checkBoxMemoryDump
            // 
            this.checkBoxMemoryDump.AutoSize = true;
            this.checkBoxMemoryDump.Checked = true;
            this.checkBoxMemoryDump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMemoryDump.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxMemoryDump.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMemoryDump.Location = new System.Drawing.Point(5, 214);
            this.checkBoxMemoryDump.Name = "checkBoxMemoryDump";
            this.checkBoxMemoryDump.Padding = new System.Windows.Forms.Padding(3);
            this.checkBoxMemoryDump.Size = new System.Drawing.Size(268, 35);
            this.checkBoxMemoryDump.TabIndex = 10;
            this.checkBoxMemoryDump.Text = "Memory Dumps";
            this.checkBoxMemoryDump.UseVisualStyleBackColor = true;
            // 
            // prefetchButton
            // 
            this.prefetchButton.Location = new System.Drawing.Point(160, 185);
            this.prefetchButton.Name = "prefetchButton";
            this.prefetchButton.Size = new System.Drawing.Size(106, 29);
            this.prefetchButton.TabIndex = 8;
            this.prefetchButton.Text = "Open";
            this.prefetchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prefetchButton.UseVisualStyleBackColor = true;
            this.prefetchButton.Click += new System.EventHandler(this.prefetchButton_Click);
            // 
            // userTempCashButton
            // 
            this.userTempCashButton.Location = new System.Drawing.Point(160, 148);
            this.userTempCashButton.Name = "userTempCashButton";
            this.userTempCashButton.Size = new System.Drawing.Size(106, 29);
            this.userTempCashButton.TabIndex = 7;
            this.userTempCashButton.Text = "Open";
            this.userTempCashButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userTempCashButton.UseVisualStyleBackColor = true;
            this.userTempCashButton.Click += new System.EventHandler(this.userTempCashButton_Click);
            // 
            // tempButton
            // 
            this.tempButton.Location = new System.Drawing.Point(160, 113);
            this.tempButton.Name = "tempButton";
            this.tempButton.Size = new System.Drawing.Size(103, 29);
            this.tempButton.TabIndex = 6;
            this.tempButton.Text = "Open";
            this.tempButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tempButton.UseVisualStyleBackColor = true;
            this.tempButton.Click += new System.EventHandler(this.tempButton_Click);
            // 
            // checkBoxPrefetch
            // 
            this.checkBoxPrefetch.AutoSize = true;
            this.checkBoxPrefetch.Checked = true;
            this.checkBoxPrefetch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrefetch.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxPrefetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrefetch.Location = new System.Drawing.Point(5, 179);
            this.checkBoxPrefetch.Name = "checkBoxPrefetch";
            this.checkBoxPrefetch.Padding = new System.Windows.Forms.Padding(3);
            this.checkBoxPrefetch.Size = new System.Drawing.Size(268, 35);
            this.checkBoxPrefetch.TabIndex = 4;
            this.checkBoxPrefetch.Text = "Prefetch";
            this.checkBoxPrefetch.UseVisualStyleBackColor = true;
            // 
            // checkBoxTempWithPercent
            // 
            this.checkBoxTempWithPercent.AutoSize = true;
            this.checkBoxTempWithPercent.Checked = true;
            this.checkBoxTempWithPercent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTempWithPercent.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxTempWithPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTempWithPercent.Location = new System.Drawing.Point(5, 144);
            this.checkBoxTempWithPercent.Name = "checkBoxTempWithPercent";
            this.checkBoxTempWithPercent.Padding = new System.Windows.Forms.Padding(3);
            this.checkBoxTempWithPercent.Size = new System.Drawing.Size(268, 35);
            this.checkBoxTempWithPercent.TabIndex = 3;
            this.checkBoxTempWithPercent.Text = "%Temp%";
            this.checkBoxTempWithPercent.UseVisualStyleBackColor = true;
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.Checked = true;
            this.checkBoxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTemp.Location = new System.Drawing.Point(5, 109);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Padding = new System.Windows.Forms.Padding(3);
            this.checkBoxTemp.Size = new System.Drawing.Size(268, 35);
            this.checkBoxTemp.TabIndex = 2;
            this.checkBoxTemp.Text = "Temp";
            this.checkBoxTemp.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Checked = true;
            this.checkBoxAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAll.Location = new System.Drawing.Point(5, 71);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkBoxAll.Size = new System.Drawing.Size(268, 38);
            this.checkBoxAll.TabIndex = 1;
            this.checkBoxAll.Text = "All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(5, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(3);
            this.btnDelete.Size = new System.Drawing.Size(268, 66);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelSizeCanBeDeleted
            // 
            this.labelSizeCanBeDeleted.AutoSize = true;
            this.labelSizeCanBeDeleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSizeCanBeDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeCanBeDeleted.Location = new System.Drawing.Point(0, 0);
            this.labelSizeCanBeDeleted.Name = "labelSizeCanBeDeleted";
            this.labelSizeCanBeDeleted.Padding = new System.Windows.Forms.Padding(5);
            this.labelSizeCanBeDeleted.Size = new System.Drawing.Size(263, 39);
            this.labelSizeCanBeDeleted.TabIndex = 1;
            this.labelSizeCanBeDeleted.Text = "0 mb might be deleted";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.progressBar);
            this.panelStatus.Controls.Add(this.labelFilesCountDeleted);
            this.panelStatus.Controls.Add(this.labelFilesSizeDeteted);
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 167);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Padding = new System.Windows.Forms.Padding(5);
            this.panelStatus.Size = new System.Drawing.Size(505, 155);
            this.panelStatus.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(5, 111);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(495, 39);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // labelFilesCountDeleted
            // 
            this.labelFilesCountDeleted.AutoSize = true;
            this.labelFilesCountDeleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFilesCountDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilesCountDeleted.Location = new System.Drawing.Point(5, 75);
            this.labelFilesCountDeleted.Name = "labelFilesCountDeleted";
            this.labelFilesCountDeleted.Padding = new System.Windows.Forms.Padding(3);
            this.labelFilesCountDeleted.Size = new System.Drawing.Size(188, 35);
            this.labelFilesCountDeleted.TabIndex = 3;
            this.labelFilesCountDeleted.Text = "0 Files Deleted ";
            // 
            // labelFilesSizeDeteted
            // 
            this.labelFilesSizeDeteted.AutoSize = true;
            this.labelFilesSizeDeteted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFilesSizeDeteted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilesSizeDeteted.Location = new System.Drawing.Point(5, 40);
            this.labelFilesSizeDeteted.Name = "labelFilesSizeDeteted";
            this.labelFilesSizeDeteted.Padding = new System.Windows.Forms.Padding(3);
            this.labelFilesSizeDeteted.Size = new System.Drawing.Size(165, 35);
            this.labelFilesSizeDeteted.TabIndex = 5;
            this.labelFilesSizeDeteted.Text = "0 MB Deleted";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(5, 5);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(3);
            this.labelStatus.Size = new System.Drawing.Size(97, 35);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status: ";
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.AutoSize = true;
            this.labelFilesCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFilesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilesCount.Location = new System.Drawing.Point(0, 39);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.Padding = new System.Windows.Forms.Padding(5);
            this.labelFilesCount.Size = new System.Drawing.Size(186, 39);
            this.labelFilesCount.TabIndex = 3;
            this.labelFilesCount.Text = "0 files detected";
            // 
            // DeleteFoldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 322);
            this.Controls.Add(this.labelFilesCount);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.labelSizeCanBeDeleted);
            this.Controls.Add(this.panelButtons);
            this.Name = "DeleteFoldersForm";
            this.Text = "Delete Temp Folders";
            this.Load += new System.EventHandler(this.DeleteFoldersForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.CheckBox checkBoxPrefetch;
        private System.Windows.Forms.CheckBox checkBoxTempWithPercent;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelSizeCanBeDeleted;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelFilesCountDeleted;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelFilesSizeDeteted;
        private System.Windows.Forms.Label labelFilesCount;
        private System.Windows.Forms.Button prefetchButton;
        private System.Windows.Forms.Button userTempCashButton;
        private System.Windows.Forms.Button tempButton;
        private System.Windows.Forms.CheckBox checkBoxBrowersCache;
        private System.Windows.Forms.CheckBox checkBoxMemoryDump;
        private System.Windows.Forms.Button buttonMemoryDumps;
    }
}