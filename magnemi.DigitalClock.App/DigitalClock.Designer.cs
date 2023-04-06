namespace magnemi.DigitalClock.App
{
    partial class frmDigitalClock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.tmrClockTicker = new System.Windows.Forms.Timer(this.components);
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.Font = new System.Drawing.Font("Arial", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(759, 139);
            this.lblTimeDisplay.TabIndex = 0;
            this.lblTimeDisplay.Text = "12:59:50 PM";
            this.lblTimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrClockTicker
            // 
            this.tmrClockTicker.Enabled = true;
            this.tmrClockTicker.Interval = 1000;
            this.tmrClockTicker.Tick += new System.EventHandler(this.tmrAdvanceClock_Tick);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.AutoSize = true;
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitApplication.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitApplication.Location = new System.Drawing.Point(242, 156);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(268, 55);
            this.btnExitApplication.TabIndex = 1;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            this.btnExitApplication.MouseLeave += new System.EventHandler(this.btnExitApplication_MouseLeave);
            this.btnExitApplication.MouseHover += new System.EventHandler(this.btnExitApplication_MouseHover);
            // 
            // frmDigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitApplication;
            this.ClientSize = new System.Drawing.Size(783, 223);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.lblTimeDisplay);
            this.Name = "frmDigitalClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.frmDigitalClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Timer tmrClockTicker;
        private System.Windows.Forms.Button btnExitApplication;
    }
}
