namespace MeadowLandLauncher {
    partial class PackGen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SpriteSheetBox = new System.Windows.Forms.TextBox();
            this.StationeryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FontBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FontNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SpriteSheetDialog = new System.Windows.Forms.OpenFileDialog();
            this.StationeryDialog = new System.Windows.Forms.OpenFileDialog();
            this.FontDialog = new System.Windows.Forms.OpenFileDialog();
            this.SpriteSheetButton = new System.Windows.Forms.Button();
            this.StationaryButton = new System.Windows.Forms.Button();
            this.FontButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.PackNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprite Sheet (required)";
            // 
            // SpriteSheetBox
            // 
            this.SpriteSheetBox.Location = new System.Drawing.Point(7, 25);
            this.SpriteSheetBox.Name = "SpriteSheetBox";
            this.SpriteSheetBox.ReadOnly = true;
            this.SpriteSheetBox.Size = new System.Drawing.Size(748, 20);
            this.SpriteSheetBox.TabIndex = 1;
            // 
            // StationeryBox
            // 
            this.StationeryBox.Location = new System.Drawing.Point(7, 72);
            this.StationeryBox.Name = "StationeryBox";
            this.StationeryBox.ReadOnly = true;
            this.StationeryBox.Size = new System.Drawing.Size(748, 20);
            this.StationeryBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stationery (required)";
            // 
            // FontBox
            // 
            this.FontBox.Location = new System.Drawing.Point(7, 119);
            this.FontBox.Name = "FontBox";
            this.FontBox.ReadOnly = true;
            this.FontBox.Size = new System.Drawing.Size(748, 20);
            this.FontBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font (required)";
            // 
            // FontNameBox
            // 
            this.FontNameBox.Location = new System.Drawing.Point(7, 165);
            this.FontNameBox.Name = "FontNameBox";
            this.FontNameBox.Size = new System.Drawing.Size(748, 20);
            this.FontNameBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font Name (required)";
            // 
            // SpriteSheetDialog
            // 
            this.SpriteSheetDialog.Filter = "PNG|*.png";
            this.SpriteSheetDialog.Title = "Pick Sprite Sheet";
            this.SpriteSheetDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SpriteSheetDialog_FileOk);
            // 
            // StationeryDialog
            // 
            this.StationeryDialog.Filter = "PNG|*.png";
            this.StationeryDialog.Title = "Pick Stationery";
            this.StationeryDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.StationaryDialog_FileOk);
            // 
            // FontDialog
            // 
            this.FontDialog.Filter = "TTF|*.ttf";
            this.FontDialog.Title = "Pick Font";
            this.FontDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FontDialog_FileOk);
            // 
            // SpriteSheetButton
            // 
            this.SpriteSheetButton.Location = new System.Drawing.Point(761, 23);
            this.SpriteSheetButton.Name = "SpriteSheetButton";
            this.SpriteSheetButton.Size = new System.Drawing.Size(27, 23);
            this.SpriteSheetButton.TabIndex = 8;
            this.SpriteSheetButton.Text = "...";
            this.ToolTip.SetToolTip(this.SpriteSheetButton, "This is the Sprite Sheet for your pack. This includes the birds, the mailbox...");
            this.SpriteSheetButton.UseVisualStyleBackColor = true;
            this.SpriteSheetButton.Click += new System.EventHandler(this.SpriteSheetButton_Click);
            // 
            // StationaryButton
            // 
            this.StationaryButton.Location = new System.Drawing.Point(761, 70);
            this.StationaryButton.Name = "StationaryButton";
            this.StationaryButton.Size = new System.Drawing.Size(27, 23);
            this.StationaryButton.TabIndex = 9;
            this.StationaryButton.Text = "...";
            this.ToolTip.SetToolTip(this.StationaryButton, "This is the background for when you get a letter.");
            this.StationaryButton.UseVisualStyleBackColor = true;
            this.StationaryButton.Click += new System.EventHandler(this.StationaryButton_Click);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(761, 117);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(27, 23);
            this.FontButton.TabIndex = 10;
            this.FontButton.Text = "...";
            this.ToolTip.SetToolTip(this.FontButton, "This is the font used in letters.");
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(7, 235);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(781, 23);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate!";
            this.ToolTip.SetToolTip(this.generateButton, "Click this button once you\'re ready to make your pack.");
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // PackNameBox
            // 
            this.PackNameBox.Location = new System.Drawing.Point(7, 209);
            this.PackNameBox.Name = "PackNameBox";
            this.PackNameBox.Size = new System.Drawing.Size(748, 20);
            this.PackNameBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pack Name (optional)";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(4, 266);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(537, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Hover your mouse over buttons, and information about them will appear. You can us" +
    "e \"...\" buttons to attach files.";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 0;
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ReshowDelay = 0;
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "?";
            this.ToolTip.SetToolTip(this.button1, "This is the Font Name. Be careful with getting this right, because your font will" +
        " not load if you make a typo.");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "?";
            this.ToolTip.SetToolTip(this.button2, "This is the name for your pack. It will be used as the name for the ZIP file.");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PackGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.PackNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.StationaryButton);
            this.Controls.Add(this.SpriteSheetButton);
            this.Controls.Add(this.FontNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StationeryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpriteSheetBox);
            this.Controls.Add(this.label1);
            this.Name = "PackGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Pack Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpriteSheetBox;
        private System.Windows.Forms.TextBox StationeryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FontBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FontNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog SpriteSheetDialog;
        private System.Windows.Forms.OpenFileDialog StationeryDialog;
        private System.Windows.Forms.OpenFileDialog FontDialog;
        private System.Windows.Forms.Button SpriteSheetButton;
        private System.Windows.Forms.Button StationaryButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox PackNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}