namespace MeadowLandLauncher {
    partial class MainForm {
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
            this.PackBtn = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PackFldrBtn = new System.Windows.Forms.Button();
            this.DiscordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MeadowLand Maker (1.0.3)";
            // 
            // PackBtn
            // 
            this.PackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PackBtn.Location = new System.Drawing.Point(12, 4);
            this.PackBtn.Name = "PackBtn";
            this.PackBtn.Size = new System.Drawing.Size(75, 23);
            this.PackBtn.TabIndex = 3;
            this.PackBtn.Text = "Make Pack";
            this.ToolTip.SetToolTip(this.PackBtn, "Ready to make a pack? Just click this button!");
            this.PackBtn.UseVisualStyleBackColor = false;
            this.PackBtn.Click += new System.EventHandler(this.PackBtn_Click);
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
            // PackFldrBtn
            // 
            this.PackFldrBtn.Location = new System.Drawing.Point(93, 4);
            this.PackFldrBtn.Name = "PackFldrBtn";
            this.PackFldrBtn.Size = new System.Drawing.Size(105, 23);
            this.PackFldrBtn.TabIndex = 4;
            this.PackFldrBtn.Text = "Open Pack Folder";
            this.ToolTip.SetToolTip(this.PackFldrBtn, "Forgot where the packs are stored? This button will open the folder up for you!");
            this.PackFldrBtn.UseVisualStyleBackColor = true;
            this.PackFldrBtn.Click += new System.EventHandler(this.PackFldrBtn_Click);
            // 
            // DiscordBtn
            // 
            this.DiscordBtn.Location = new System.Drawing.Point(204, 4);
            this.DiscordBtn.Name = "DiscordBtn";
            this.DiscordBtn.Size = new System.Drawing.Size(138, 23);
            this.DiscordBtn.TabIndex = 5;
            this.DiscordBtn.Text = "SamHub Discord";
            this.ToolTip.SetToolTip(this.DiscordBtn, "You can use this button to join our Discord Server!");
            this.DiscordBtn.UseVisualStyleBackColor = true;
            this.DiscordBtn.Click += new System.EventHandler(this.DiscordBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 58);
            this.Controls.Add(this.DiscordBtn);
            this.Controls.Add(this.PackFldrBtn);
            this.Controls.Add(this.PackBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeadowLand Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PackBtn;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button PackFldrBtn;
        private System.Windows.Forms.Button DiscordBtn;
    }
}

