using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using AutoUpdaterDotNET;

namespace MeadowLandLauncher {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var mllappdata = "%appdata%\\MeadowLandMaker";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);

            Directory.CreateDirectory(mllappdata);
            AutoUpdater.Start("https://raw.githubusercontent.com/UnofficialSamHub/MeadowMakerBackend/master/update.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
