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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.labelSeconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 82);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(170, 82);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(57, 26);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(37, 13);
            this.labelDelay.TabIndex = 2;
            this.labelDelay.Text = "Delay:";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDelay.Location = new System.Drawing.Point(100, 22);
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
            this.labelSeconds.Location = new System.Drawing.Point(162, 26);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(20, 13);
            this.labelSeconds.TabIndex = 4;
            this.labelSeconds.Text = "ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 117);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
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

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelSeconds;
    }
}

