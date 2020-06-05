using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeadowLandLauncher {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void packBtn_Click(object sender, EventArgs e) {
            Hide();
            new PackGen().ShowDialog();
            Show();
        }

        private void InstallBtn_Click(object sender, EventArgs e) {
            MessageBox.Show("This feature isn't available yet.", "MeadowLand Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
