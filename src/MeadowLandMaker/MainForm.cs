﻿using System;
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
        }

        private void packBtn_Click(object sender, EventArgs e) {
            Hide();
            new PackGen().ShowDialog();
            Show();
        }

        private void packFldrBtn_Click(object sender, EventArgs e) {
            var mllappdata = "%appdata%\\MeadowLandMaker";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
            try {
                Process.Start($@"{mllappdata}\\packs");
            } catch (Win32Exception err) {
                MessageBox.Show($"Something went wrong while opening up the pack folder. Have you made a pack yet?\n\nError details: {err.Message}", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
