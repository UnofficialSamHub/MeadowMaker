using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeadowLandLauncher {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            #if DEBUG
            MessageBox.Show("Test build alert! This is a testing version of MLM.", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #endif
        }

        private void PackBtn_Click(object sender, EventArgs e) {
            Hide();
            new PackGen().ShowDialog();
            Show();
        }

        private void PackFldrBtn_Click(object sender, EventArgs e) {
            var mllappdata = "%appdata%\\MeadowLandMaker";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
            try {
                Process.Start($@"{mllappdata}\\packs");
            } catch (Win32Exception err) {
                MessageBox.Show($"Have you made a pack yet? The pack folder isn't opening...\n\nError details: {err.Message}", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscordBtn_Click(object sender, EventArgs e) {
            if(MessageBox.Show($"Hey! The SamHub Discord is not affiliated with SamPerson. If you click OK, an external link will be opened. Continue anyway?", "MeadowLand Maker", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Process.Start("https://discord.gg/W4kTbaV");
            }
        }
    }
}
