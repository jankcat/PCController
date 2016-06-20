using PCController.Library;
using System;
using System.Windows.Forms;

namespace PCController.TestApp
{
    public partial class Form1 : Form
    {

        private ArduinoOne _a1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                    if (dlg == DialogResult.No) retry = false;
                    Application.Exit();
                }
            }
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lblOutput.Text = _a1.PCCaseLEDs.GetRawValue().ToString();
        }

        private void btn6On_Click(object sender, EventArgs e)
        {
            _a1.PCCaseLEDs.SetValue(true);
        }

        private void btn6Off_Click(object sender, EventArgs e)
        {
            _a1.PCCaseLEDs.SetValue(false);
        }
    }
}
