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
            if(FontBox.Text=="" || StationeryBox.Text == "" || SpriteSheetBox.Text == "" || FontNameBox.Text == "" || PackNameBox.Text == "" || MeadowVersion.Text == "") {
                StopGenerator();
                string ErrorMSG = "It appears you have forgotten to fill in some fields. All fields are required for pack generation. The following fields were forgotten:\n\n";
                if(FontBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Font, "); }
                if(StationeryBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Stationery, "); }
                if(SpriteSheetBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Sprite Sheet, "); }
                if(FontNameBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Font Name, "); }
                if(PackNameBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Pack Name, "); }
                if(MeadowVersion.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Meadow Version"); }
                MessageBox.Show(ErrorMSG, "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mllappdata = "%appdata%\\MeadowLandMaker";
            var packzippath = $"\\{PackNameBox.Text}.zip";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
            var finalpath = mllappdata + packzippath;

            JObject packinfo =
                new JObject(
                    new JProperty("versionNumber", MeadowVersion.Text),
                    new JProperty("pack",
                        new JObject(
                            new JProperty("spritesheetFilename", SpriteSheetDialog.SafeFileName),
                            new JProperty("formsStationeryImageFilename", StationeryDialog.SafeFileName),
                            new JProperty("formsLetterFontFilename", FontDialog.SafeFileName),
                            new JProperty("formsLetterFontFamilyName", FontNameBox.Text))));

            if(File.Exists(finalpath)) {
                DialogResult dialogresult = MessageBox.Show($"A pack under the name {PackNameBox.Text} already exists.\nDo you want to replace it?", "MeadowLand Maker", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Cancel) {
                    StopGenerator();
                    return; 
                }
                if (dialogresult == DialogResult.OK) { File.Delete(finalpath); }
            }

            File.WriteAllText($"{mllappdata}/temp.json", packinfo.ToString());

            try {
                using(ZipArchive archive = ZipFile.Open(finalpath, ZipArchiveMode.Update)) {
                    archive.CreateEntryFromFile(SpriteSheetDialog.FileName, SpriteSheetDialog.SafeFileName);
                    archive.CreateEntryFromFile(StationeryDialog.FileName, StationeryDialog.SafeFileName);
                    archive.CreateEntryFromFile(FontDialog.FileName, FontDialog.SafeFileName);
                    archive.CreateEntryFromFile($"{mllappdata}/temp.json", "packinfo.json");
                }
            } catch (ArgumentException err) {
                StopGenerator(true, finalpath);
                MessageBox.Show($"Something went wrong during ZIP generation. Is {PackNameBox.Text} a valid name for a ZIP file?\n\nError details: {err.Message}", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } catch (FileNotFoundException err) {
                StopGenerator(true, finalpath);
                MessageBox.Show($"A file needed for generation doesn't appear to exist.\n\nError details: {err.Message}", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.Delete($"{mllappdata}/temp.json");
            Process.Start($@"{mllappdata}");
            StopGenerator();
        }
        
        private void StopGenerator(bool DeleteZipData = false, string finalpath = "") {
            generateButton.Enabled = true;
            generateButton.Text = "Generate!";
            if(DeleteZipData == true) {
                var mllappdata = "%appdata%\\MeadowLandMaker";
                mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
                try { File.Delete(finalpath); } catch { }
                try { File.Delete($"{mllappdata}/temp.json"); } catch { }
            }
        }
    }
}
