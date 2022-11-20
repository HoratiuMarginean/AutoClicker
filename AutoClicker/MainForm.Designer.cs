namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelActiveInactive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartStop.Location = new System.Drawing.Point(172, 12);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 50);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "START";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(12, 12);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(37, 13);
            this.labelDelay.TabIndex = 2;
            this.labelDelay.Text = "Delay:";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDelay.Location = new System.Drawing.Point(55, 8);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(56, 21);
            this.numericUpDownDelay.TabIndex = 3;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(117, 12);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(20, 13);
            this.labelSeconds.TabIndex = 4;
            this.labelSeconds.Text = "ms";
            // 
            // labelActiveInactive
            // 
            this.labelActiveInactive.AutoSize = true;
            this.labelActiveInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveInactive.ForeColor = System.Drawing.Color.DarkRed;
            this.labelActiveInactive.Location = new System.Drawing.Point(35, 51);
            this.labelActiveInactive.Name = "labelActiveInactive";
            this.labelActiveInactive.Size = new System.Drawing.Size(76, 16);
            this.labelActiveInactive.TabIndex = 5;
            this.labelActiveInactive.Text = "INACTIVE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 76);
            this.Controls.Add(this.labelActiveInactive);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.buttonStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutoClicker";
            this.TopMost = true;
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelActiveInactive;
    }
}

