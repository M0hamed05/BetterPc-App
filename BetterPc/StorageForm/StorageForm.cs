using System;
using System.Linq;
using System.Windows.Forms;
using ToolsLogicLayer;

namespace BetterPc
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        private void tempFoldersButton_Click(object sender, EventArgs e)
        {
            var openForm = Application.OpenForms.OfType<DeleteFoldersForm>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.BringToFront();
                openForm.Activate();
            }
            else
            {
                DeleteFoldersForm form = new DeleteFoldersForm();
                form.Show();
            }
        }

        private void diskCleanupButton_Click(object sender, EventArgs e)
        {
            Tools.RunDiskCleanup();
        }

        private void disableHibernateButton_Click(object sender, EventArgs e)
        {
            if (Tools.IsHibernateEnabledFromRegistry())
            {
                var dialogResult = MessageBox.Show(
                    "Disabling Hibernate will free up several gigabytes of space on your C: drive.\n\n" +
                    "Note: This will remove the 'Hibernate' option from your Windows power menu, and your computer won't be able to save its state when shutting down.\n\n" +
                    "Are you sure you want to proceed?",
                    "Confirm Action",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    Tools.SetHibernate(false);
                    disableHibernateButton.Text = "Enable Hibernate";
                }
            }
            else
            {
                Tools.SetHibernate(true);
                disableHibernateButton.Text = "Disable Hibernate";
            }
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            Tools.OpenStorageSettings();
        }

        private void StorageForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                disableHibernateButton.Text = Tools.IsHibernateEnabledFromRegistry() ? "Disable Hibernate" : "Enable Hibernate";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking Hibernate status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ToolTip storageFormToolTips = new ToolTip();
            storageFormToolTips.AutoPopDelay = 5000;
            storageFormToolTips.InitialDelay = 1500;
            storageFormToolTips.ReshowDelay = 500;
            storageFormToolTips.ShowAlways = true;

            storageFormToolTips.SetToolTip(tempFoldersButton, "Opens the tool to scan and delete safe temporary files, log files, and Windows cache to free up space.");
            storageFormToolTips.SetToolTip(diskCleanupButton, "Launches the built-in Windows Disk Cleanup utility to deep clean system updates and dump files.");
            storageFormToolTips.SetToolTip(disableHibernateButton, "Toggles Windows Hibernation off to instantly delete the hiberfil.sys file and save gigabytes of C: drive space.");
            storageFormToolTips.SetToolTip(StorageButton, "Opens Windows Modern Storage Settings to view your storage breakdown and large files.\n You can also use Storage page to automatically clean temporary files without needing other tools.");
        }
    }
}
