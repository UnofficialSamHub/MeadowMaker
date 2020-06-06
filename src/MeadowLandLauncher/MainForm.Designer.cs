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
            this.packList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InstallBtn = new System.Windows.Forms.Button();
            this.packBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // packList
            // 
            this.packList.FormattingEnabled = true;
            this.packList.Location = new System.Drawing.Point(12, 12);
            this.packList.Name = "packList";
            this.packList.Size = new System.Drawing.Size(120, 95);
            this.packList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MeadowLand Launcher Demo (0.0.3)";
            // 
            // InstallBtn
            // 
            this.InstallBtn.Location = new System.Drawing.Point(138, 12);
            this.InstallBtn.Name = "InstallBtn";
            this.InstallBtn.Size = new System.Drawing.Size(75, 23);
            this.InstallBtn.TabIndex = 2;
            this.InstallBtn.Text = "Install";
            this.InstallBtn.UseVisualStyleBackColor = true;
            this.InstallBtn.Click += new System.EventHandler(this.InstallBtn_Click);
            // 
            // packBtn
            // 
            this.packBtn.BackColor = System.Drawing.SystemColors.Control;
            this.packBtn.Location = new System.Drawing.Point(138, 41);
            this.packBtn.Name = "packBtn";
            this.packBtn.Size = new System.Drawing.Size(75, 23);
            this.packBtn.TabIndex = 3;
            this.packBtn.Text = "Make Pack";
            this.packBtn.UseVisualStyleBackColor = false;
            this.packBtn.Click += new System.EventHandler(this.packBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 113);
            this.Controls.Add(this.packBtn);
            this.Controls.Add(this.InstallBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packList);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeadowLand Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox packList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InstallBtn;
        private System.Windows.Forms.Button packBtn;
    }
}

