using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace MeadowLandLauncher {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var mllappdata = "%appdata%\\MeadowLandLauncher";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);

            if(!Directory.Exists(mllappdata))
                Directory.CreateDirectory(mllappdata);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
