using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterPc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void storageButton_Click(object sender, EventArgs e)
        {
            var openForm = Application.OpenForms.OfType<StorageForm>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.BringToFront();
                openForm.Activate();
            }
            else
            {
                StorageForm form = new StorageForm();
                form.Show();
            }
        }

        private void speedButton_Click(object sender, EventArgs e)
        {
            var openForm = Application.OpenForms.OfType<SpeedForm>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.BringToFront();
                openForm.Activate();
            }
            else
            {
                SpeedForm form = new SpeedForm();
                form.Show();
            }
        }
    }
}
