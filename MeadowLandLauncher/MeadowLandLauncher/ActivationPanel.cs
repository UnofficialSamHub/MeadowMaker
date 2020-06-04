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
                label1.Text = "Sorry, but that's an incorrect code! Nice try... :)";
            }
        }
    }
}
