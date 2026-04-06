using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Settings
{
    public partial class XPlaneRemotePanel : UserControl
    {
        public XPlaneRemotePanel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadSettings()
        {
            XPlaneRemote.Checked = Properties.Settings.Default.XPlaneRemote;
            XPlaneIP.Text = Properties.Settings.Default.XPlaneRemoteIP;
            XPlaneIP.Enabled = XPlaneRemote.Checked;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.XPlaneRemote = XPlaneRemote.Checked;
            Properties.Settings.Default.XPlaneRemoteIP = XPlaneIP.Text;
        }

        private void XPlaneRemoteEnable_CheckedChanged(object sender, EventArgs e)
        {
            XPlaneIP.Enabled = XPlaneRemote.Checked;
        }
    }
}
