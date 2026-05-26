using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLogicLayer;

namespace BetterPc
{
    public partial class SpeedForm : Form
    {
        public SpeedForm()
        {
            InitializeComponent();
        }

        private void disableStartupApplicationsButton_Click(object sender, EventArgs e)
        {
            Tools.OpenStartupSettings();
        }

        private void disableBackgorundAppsButton_Click(object sender, EventArgs e)
        {
            Tools.OpenBackgroundAppsSettings();
        }

        private void disableUncessaryVisualsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "When the 'Performance Options' window opens:\n\n" +
                "1. Select 'Adjust for best performance'.\n" +
                "2. (Recommended) Check 'Show thumbnails instead of icons' and 'Smooth edges of screen fonts' to keep it clean.\n" +
                "3. Click Apply then OK.",
                "Optimize Visual Effects",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (!Tools.OpenVisualPerformanceSettings())
            {
                MessageBox.Show("Could not open system settings automatically.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void disableunnecessaryServicesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "When the 'System Configuration' (msconfig) window opens:\n\n" +
                "1. Go to the 'Services' tab.\n" +
                "2. Check 'Hide all Microsoft services' at the bottom first!\n" +
                "3. Uncheck the services you don't need (like updater services for apps you don't use) and click Apply.",
                "Disable Services Safely",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Tools.RunMsConfig();
        }

        private void SpeedForm_Load(object sender, EventArgs e)
        {
            ToolTip speedFormToolTips = new ToolTip();
            speedFormToolTips.AutoPopDelay = 5000;  
            speedFormToolTips.InitialDelay = 1500;   
            speedFormToolTips.ReshowDelay = 500;    
            speedFormToolTips.ShowAlways = true;

            speedFormToolTips.SetToolTip(disableStartupApplicationsButton, "Opens Windows Startup settings to stop apps from launching automatically on PC boot.");
            speedFormToolTips.SetToolTip(disableBackgorundAppsButton, "Opens Windows Background Apps manager to stop apps from consuming RAM and CPU in the background.");
            speedFormToolTips.SetToolTip(disableUncessaryVisualsButton, "Opens Performance Options to disable heavy animations and windows shadows for maximum system responsiveness.");
            speedFormToolTips.SetToolTip(disableunnecessaryServicesButton, "Launches System Configuration (msconfig) to turn off non-essential background services safely.");
        }
    }
}
