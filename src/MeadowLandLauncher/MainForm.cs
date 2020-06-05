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
            this.FormClosed +=
                new FormClosedEventHandler(this.MainForm_FormClosed);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void packBtn_Click(object sender, EventArgs e) {
            Hide();
            new PackGen().ShowDialog();
            Show();
        }
    }
}
