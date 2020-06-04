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
    public partial class ActivationPanel : Form {
        public ActivationPanel() {
            InitializeComponent();
        }

        private void actBtn_Click(object sender, EventArgs e) {
            if(ActivationBox.Text == "SHFP10402") {
                this.Hide();
                new MainForm().Show();
            } else {
                label1.Text = "Sneaky of ya! Maybe try joining the SHFP first or stop trying to be level 100 h$ack3r ;).";
            }
        }
    }
}
