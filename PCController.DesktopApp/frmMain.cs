using PCController.Library;
using System;
using System.Windows.Forms;

namespace PCController.DesktopApp
{
    public partial class frmMain : Form
    {
        private ArduinoOne _a1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitArduino1();
            UpdateAppToState();
        }

        private void InitArduino1()
        {
            bool retry = true;
            while (retry)
            {
                try
                {
                    _a1 = new ArduinoOne();
                    retry = false;
                }
                catch
                {
                    var dlg = MessageBox.Show("No Arduino #1 found. Retry?", "No Arduino #1 found", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.No)
                    {
                        retry = false;
                        Application.Exit();
                    }
                }
            }
        }

        private void cmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateAppToState()
        {
            try
            {
                cmiPCLEDs.Checked = !_a1.PCCaseLEDs.GetValue();
                monitorLEDsToolStripMenuItem.Checked = _a1.MonitorLEDs.GetValue();
            }
            catch { }
        }

        private void monitorLEDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _a1.MonitorLEDs.SetValue(monitorLEDsToolStripMenuItem.Checked);
            }
            catch { }
        }

        private void cmiPCLEDs_Click(object sender, EventArgs e)
        {
            try
            {
                _a1.PCCaseLEDs.SetValue(!cmiPCLEDs.Checked);
            }
            catch { }
        }
    }
}
