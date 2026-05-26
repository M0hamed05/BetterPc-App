using System;
using System.IO;
using System.Windows.Forms;
using ToolsLogicLayer;

namespace BetterPc
{
    public partial class DeleteFoldersForm : Form
    {
        TempFolders tempFolders = new TempFolders();
        public DeleteFoldersForm()
        {
            InitializeComponent();
            RefershData();

            checkBoxTemp.CheckedChanged += checkBox_SelectionChnaged;
            checkBoxTempWithPercent.CheckedChanged += checkBox_SelectionChnaged;
            checkBoxPrefetch.CheckedChanged += checkBox_SelectionChnaged;
            checkBoxBrowersCache.CheckedChanged += checkBox_SelectionChnaged;
            checkBoxMemoryDump.CheckedChanged += checkBox_SelectionChnaged;

            tempFolders.OnFileDeletedEvent += DisplayDeleteActionEvent;
            RefershData();
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control checkbox in panelButtons.Controls)
                if (checkbox is CheckBox chk)//CAST FASTER
                    chk.Checked = checkBoxAll.Checked;


            RefershData();
        }

        private void RefershData()
        {
            long totalSize = 0;
            int totalFiles = 0;

            if (checkBoxTempWithPercent.Checked)
            {
                totalSize += tempFolders.UsertempSize;
                totalFiles += tempFolders.UsertempFilesCount;
            }
            if (checkBoxTemp.Checked)
            {
                totalSize += tempFolders.tempSize;
                totalFiles += tempFolders.tempFilesCount;
            }
            if (checkBoxPrefetch.Checked)
            {
                totalSize += tempFolders.prefetchSize;
                totalFiles += tempFolders.prefetchFilesCount;
            }
            if (checkBoxBrowersCache.Checked)
            {
                totalSize += tempFolders.browsersCachSize;
                totalFiles += tempFolders.browsersCachCount;

            }
            if (checkBoxMemoryDump.Checked)
            {
                totalSize += tempFolders.memoryDumpSize;
                totalFiles += tempFolders.memoryDumpCount;
            }

            labelSizeCanBeDeleted.Text = GetSizeFormatted(totalSize) + " might be deleted";
            labelFilesCount.Text = $"{totalFiles} files detected";
        }

        private void checkBox_SelectionChnaged(object sender,EventArgs e)
        {
            if (sender is CheckBox cb && !cb.Checked)
            {
                checkBoxAll.CheckedChanged -= checkBoxAll_CheckedChanged;//remove connection for the app and button
                checkBoxAll.Checked = false;
                checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;//return back connection for the app and button
            }
            RefershData();
        }

        private string GetSizeFormatted(long sizeInBytes)
        {
            double mb = sizeInBytes / (1024.0 * 1024.0);
            if (mb >= 1024) return $"{(mb / 1024.0):F2} GB";
            if (mb > 0) return $"{mb:F2} MB";
            return "0 MB";
        }

        private void DisplayDeleteActionEvent(int count, long sizeInBytes)
        {
            double mb = sizeInBytes / (1024.0 * 1024.0);
            labelFilesCountDeleted.Text = $"{count} Files Deleted";
            labelFilesSizeDeteted.Text = $"{mb:F2} MB Deleted";

            if (currentTotalSize > 0)
            {
                int percentage = (int)((sizeInBytes * 100.0) / currentTotalSize);

                if (percentage <= 100)
                    progressBar.Value = percentage;
            }

            Application.DoEvents(); // Allow UI to update
        }

        long currentTotalSize = 0;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            labelFilesCountDeleted.Text = "0 Files Deleted";
            labelFilesSizeDeteted.Text = "0 MB Deleted";

            long totalSizeToDeleted = 0;
            if (checkBoxTemp.Checked) totalSizeToDeleted += tempFolders.tempSize;
            if (checkBoxTempWithPercent.Checked) totalSizeToDeleted += tempFolders.UsertempSize;
            if (checkBoxPrefetch.Checked) totalSizeToDeleted += tempFolders.prefetchSize;
            if (checkBoxBrowersCache.Checked) totalSizeToDeleted += tempFolders.browsersCachSize;


            if (totalSizeToDeleted <= 0) return;

            progressBar.Minimum = 0;
            progressBar.Maximum = 100; 
            progressBar.Value = 0;

            this.currentTotalSize = totalSizeToDeleted;

            labelStatus.Text = "Deleting files...";

            btnDelete.Enabled = false;

            if (checkBoxTempWithPercent.Checked) tempFolders.DeleteFiles(Path.GetTempPath());
            if (checkBoxTemp.Checked) tempFolders.DeleteFiles(@"C:\Windows\Temp");
            if (checkBoxPrefetch.Checked) tempFolders.DeleteFiles(@"C:\Windows\Prefetch");
            if (checkBoxBrowersCache.Checked) tempFolders.DeleteBrowsersCash();
            if (checkBoxMemoryDump.Checked) tempFolders.DeleteFiles(FolderPaths.memoryDumpsPath);


            tempFolders.refershData();
            RefershData();
            progressBar.Value = 100;
            labelStatus.Text = "Deletion completed.";
            Logger.Log($"Delete Opetaion - {labelFilesSizeDeteted.Text} & {labelFilesCountDeleted.Text}",Logger.LogType.Information);
            btnDelete.Enabled = true;
        }

        private void tempButton_Click(object sender, EventArgs e)
        {
            Tools.OpenFolderInExplorer(FolderPaths.tempPatch);
        }

        private void userTempCashButton_Click(object sender, EventArgs e)
        {
            Tools.OpenFolderInExplorer(FolderPaths.usertempPatch);
        }

        private void prefetchButton_Click(object sender, EventArgs e)
        {
            Tools.OpenFolderInExplorer(FolderPaths.prefecthPatch);

        }

        private void buttonMemoryDumps_Click(object sender, EventArgs e)
        {
            Tools.OpenFolderInExplorer(FolderPaths.memoryDumpsPath);
        }

        private void DeleteFoldersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
