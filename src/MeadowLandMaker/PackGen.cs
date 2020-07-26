using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime;
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
            if(ImageDimensionCheck(SpriteSheetDialog.FileName, 674, 94) == false) {
                if(MessageBox.Show($"Hey! This Sprite Sheet is not the right size. Continue anyways?", "MeadowLand Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                    return;
                }
            }
            SpriteSheetBox.Text = SpriteSheetDialog.FileName;
        }

        private void StationaryDialog_FileOk(object sender, CancelEventArgs e) {
            if(ImageDimensionCheck(StationeryDialog.FileName, 64, 90) == false) {
                if(MessageBox.Show($"Hey! This Stationery is not the right size. Continue anyways?", "MeadowLand Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                    return;
                }
            }
            StationeryBox.Text = StationeryDialog.FileName;
        }

        private void FontDialog_FileOk(object sender, CancelEventArgs e) {
            FontBox.Text = FontDialog.FileName;
            try {
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(FontBox.Text);
                FontNameBox.Text = fontCol.Families[0].Name;
            } catch {
                MessageBox.Show("Hmm, we're not sure what the Font Name for this font is.\nYou can still use this font, but you'll have to enter in the Font Name manually.", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e) {
            GenerateBtn.Text = "Generating...";
            GenerateBtn.Enabled = false;
            if(FontBox.Text=="" || StationeryBox.Text == "" || SpriteSheetBox.Text == "" || FontNameBox.Text == "") {
                StopGenerator();
                string ErrorMSG = "It appears you have forgotten to fill in some fields. The following fields were forgotten:\n\n";
                if(FontBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Font, "); }
                if(StationeryBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Stationery, "); }
                if(SpriteSheetBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Sprite Sheet, "); }
                if(FontNameBox.Text == "") { ErrorMSG = string.Concat(ErrorMSG, "Font Name "); }
                MessageBox.Show(ErrorMSG, "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(PackNameBox.Text == "") { PackNameBox.Text = $@"{DateTime.Now.Ticks}"; }

            var mllappdata = "%appdata%\\MeadowLandMaker";
            var packzippath = $"\\{PackNameBox.Text}.zip";
            mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
            var finalpath = mllappdata + "\\packs\\" + packzippath;

            Directory.CreateDirectory($"{mllappdata}/packs");

            JObject packinfo =
                new JObject(
                    new JProperty("versionNumber", 1),
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

            var tempfile = Path.GetTempFileName();
            MessageBox.Show(tempfile);
            File.WriteAllText(tempfile, packinfo.ToString());

            try {
                using(ZipArchive archive = ZipFile.Open(finalpath, ZipArchiveMode.Update)) {
                    archive.CreateEntryFromFile(SpriteSheetDialog.FileName, SpriteSheetDialog.SafeFileName);
                    archive.CreateEntryFromFile(StationeryDialog.FileName, StationeryDialog.SafeFileName);
                    archive.CreateEntryFromFile(FontDialog.FileName, FontDialog.SafeFileName);
                    archive.CreateEntryFromFile(tempfile, "packinfo.json");
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

            statusLabel.Text = $"{PackNameBox.Text} was created!";
            File.Delete(tempfile);
            Process.Start($@"{mllappdata}/packs");
            StopGenerator();
        }
        
        private void StopGenerator(bool DeleteZipData = false, string finalpath = "") {
            GenerateBtn.Enabled = true;
            GenerateBtn.Text = "Generate!";
            if(DeleteZipData == true) {
                var mllappdata = "%appdata%\\MeadowLandMaker";
                mllappdata = Environment.ExpandEnvironmentVariables(mllappdata);
                try { File.Delete(finalpath); } catch { }
                try { File.Delete($"{mllappdata}/packs/temp.json"); } catch { }
                statusLabel.Text = $"ZIP data for {PackNameBox.Text} was deleted, probably due to an error.";
            }
        }

        private dynamic ImageDimensionCheck(string file, int width, int height, bool DisplayErrors = true) {
            try {
                using(Stream stream = File.OpenRead(file)) {
                    using(Image sourceImage = Image.FromStream(stream, false, false)) {
                            if(sourceImage.Width == width && sourceImage.Height == height) {
                                return true;
                            } else {
                                return false;
                            }
                    }
                }
            } catch {
                if(DisplayErrors == true) { MessageBox.Show("Hmm, we're not sure what the size of this image is, so we can't tell you if it's the right size.\nHowever, you can still use this image.", "MeadowLand Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                return null;
            }
        }
    }
}
