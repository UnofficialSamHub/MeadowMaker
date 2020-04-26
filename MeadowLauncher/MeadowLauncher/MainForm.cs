using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeadowLauncher {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void InstallBtn_Click(object sender, EventArgs e) {
            MessageBox.Show("This button does not currently have any function.", "Functionality unavailable",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
