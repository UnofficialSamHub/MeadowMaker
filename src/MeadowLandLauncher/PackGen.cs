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
            generateButton.Text = "Generating...";
            generateButton.Enabled = false;
            if(FontBox.Text=="" || StationeryBox.Text == "" || FontBox.Text == "" || FontNameBox.Text == "" || PackNameBox.Text == "") {
                StopGenerator();
                MessageBox.Show("One or more required fields are empty. :(", "MeadowLand Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mllappdata = "%appdata%\\MeadowLandLauncher";
            var packzippath = $"\\{PackNameBox.Text}.zip";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
            var finalpath = mllappdata + packzippath;

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

            if(File.Exists(finalpath)) {
                File.Delete(finalpath);
            }

            try {
                using(ZipArchive archive = ZipFile.Open(finalpath, ZipArchiveMode.Update)) {
                    archive.CreateEntryFromFile(SpriteSheetDialog.FileName, SpriteSheetDialog.SafeFileName);
                    archive.CreateEntryFromFile(StationeryDialog.FileName, StationeryDialog.SafeFileName);
                    archive.CreateEntryFromFile(FontDialog.FileName, FontDialog.SafeFileName);
                    archive.CreateEntryFromFile($"{mllappdata}/temp.json", "packinfo.json");
                }
            } catch (ArgumentException err) {
                StopGenerator();
                MessageBox.Show($"Something went wrong during ZIP generation. Is {PackNameBox.Text} a valid name for a ZIP file?\n\nError details: {err.Message}", "MeadowLand Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } catch (FileNotFoundException err) {
                StopGenerator();
                MessageBox.Show($"A file needed for generation doesn't appear to exist.\n\nError details: {err.Message}", "MeadowLand Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.Delete($"{mllappdata}/temp.json");
            Process.Start($@"{mllappdata}");
            StopGenerator();
        }
        
        private void StopGenerator() {
            generateButton.Enabled = true;
            generateButton.Text = "Generate!";
        }
    }
}
