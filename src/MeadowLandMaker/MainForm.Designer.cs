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
            this.packBtn = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MeadowLand Maker (0.1.3)";
            // 
            // packBtn
            // 
            this.packBtn.BackColor = System.Drawing.SystemColors.Control;
            this.packBtn.Location = new System.Drawing.Point(12, 4);
            this.packBtn.Name = "packBtn";
            this.packBtn.Size = new System.Drawing.Size(75, 23);
            this.packBtn.TabIndex = 3;
            this.packBtn.Text = "Make Pack";
            this.ToolTip.SetToolTip(this.packBtn, "Ready to make a pack? Just click this button!");
            this.packBtn.UseVisualStyleBackColor = false;
            this.packBtn.Click += new System.EventHandler(this.packBtn_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 31);
            this.Controls.Add(this.packBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeadowLand Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button packBtn;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

