namespace State
{
    partial class SafeForm
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
            this.clockLabel = new System.Windows.Forms.Label();
            this.useButton = new System.Windows.Forms.Button();
            this.alarmButton = new System.Windows.Forms.Button();
            this.phoneButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clockLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clockLabel.Location = new System.Drawing.Point(3, 9);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(449, 25);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "現在時刻は21:00";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useButton
            // 
            this.useButton.Location = new System.Drawing.Point(3, 213);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(75, 23);
            this.useButton.TabIndex = 2;
            this.useButton.Text = "金庫使用";
            this.useButton.UseVisualStyleBackColor = true;
            this.useButton.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // alarmButton
            // 
            this.alarmButton.Location = new System.Drawing.Point(122, 213);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(75, 23);
            this.alarmButton.TabIndex = 3;
            this.alarmButton.Text = "非常ベル";
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // phoneButton
            // 
            this.phoneButton.Location = new System.Drawing.Point(245, 213);
            this.phoneButton.Name = "phoneButton";
            this.phoneButton.Size = new System.Drawing.Size(75, 23);
            this.phoneButton.TabIndex = 4;
            this.phoneButton.Text = "通常通話";
            this.phoneButton.UseVisualStyleBackColor = true;
            this.phoneButton.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(377, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.Location = new System.Drawing.Point(3, 38);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(449, 159);
            this.logTextBox.TabIndex = 6;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // SafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 240);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.phoneButton);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.useButton);
            this.Controls.Add(this.clockLabel);
            this.Name = "SafeForm";
            this.Text = "SafeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clockLabel;
        private Button useButton;
        private Button alarmButton;
        private Button phoneButton;
        private Button exitButton;
        private TextBox logTextBox;
        private System.Windows.Forms.Timer clockTimer;
    }
}