using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace MeadowLandLauncher {
    public partial class PackGen : Form {
        public PackGen() {
            InitializeComponent();
        }

        private void SpriteSheetButton_Click(object sender, EventArgs e) {
            SpriteSheetDialog.ShowDialog();
        }

        private void StationaryButton_Click(object sender, EventArgs e) {
            StationeryDialog.ShowDialog();
        }

        private void FontButton_Click(object sender, EventArgs e) {
            FontDialog.ShowDialog();
        }

        private void SpriteSheetDialog_FileOk(object sender, CancelEventArgs e) {
            SpriteSheetBox.Text = SpriteSheetDialog.FileName;
        }

        private void StationaryDialog_FileOk(object sender, CancelEventArgs e) {
            StationeryBox.Text = StationeryDialog.FileName;
        }

        private void FontDialog_FileOk(object sender, CancelEventArgs e) {
            FontBox.Text = FontDialog.FileName;
        }

        private void generateButton_Click(object sender, EventArgs e) {
            if(FontBox.Text=="" || StationeryBox.Text == "" || FontBox.Text == "" || FontNameBox.Text == "" || PackNameBox.Text == "") {
                MessageBox.Show("One or more required fields are empty. :(", "MeadowLand Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mllappdata = "%appdata%\\MeadowLandLauncher";
            var packzippath = $"\\{PackNameBox.Text}.zip";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);

            ZipFile.CreateFromDirectory(mllappdata, packzippath);

            JObject packinfo =
                new JObject(
                    new JProperty("versionNumber", 1),
                    new JProperty("pack",
                        new JObject(
                            new JProperty("spritesheetFilename", SpriteSheetDialog.SafeFileName),
                            new JProperty("formsStationeryImageFilename", StationeryDialog.SafeFileName),
                            new JProperty("formsLetterFontFilename", FontDialog.SafeFileName),
                            new JProperty("formsLetterFontFamilyName", FontNameBox.Text))));

            File.WriteAllText($"{mllappdata}/temp.json", packinfo.ToString());

            using(ZipArchive archive = ZipFile.Open(mllappdata + packzippath, ZipArchiveMode.Update)) {
                archive.CreateEntryFromFile(SpriteSheetDialog.FileName, SpriteSheetDialog.SafeFileName);
                archive.CreateEntryFromFile(StationeryDialog.FileName, StationeryDialog.SafeFileName);
                archive.CreateEntryFromFile(FontDialog.FileName, FontDialog.SafeFileName);
                archive.CreateEntryFromFile($"{mllappdata}/temp.json", "packinfo.json");
            }

            File.Delete($"{mllappdata}/temp.json");
            Process.Start($@"{mllappdata}");
        }
    }
}
