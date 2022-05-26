namespace Mediator
{
    partial class LoginForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new ColleagueTextBox();
            this.usernameTextBox = new ColleagueTextBox();
            this.okButton = new ColleagueButton();
            this.cancelButton = new ColleagueButton();
            this.LoginRadioButton = new ColleagueRadioButton();
            this.GuestRadioButton = new ColleagueRadioButton();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(8, 37);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(56, 12);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 59);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(54, 12);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(70, 59);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(86, 19);
            this.passwordTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(70, 34);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(86, 19);
            this.usernameTextBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(59, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(97, 89);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(59, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // LoginRadioButton
            // 
            this.LoginRadioButton.AutoSize = true;
            this.LoginRadioButton.Location = new System.Drawing.Point(97, 12);
            this.LoginRadioButton.Name = "LoginRadioButton";
            this.LoginRadioButton.Size = new System.Drawing.Size(50, 16);
            this.LoginRadioButton.TabIndex = 1;
            this.LoginRadioButton.TabStop = true;
            this.LoginRadioButton.Text = "Login";
            this.LoginRadioButton.UseVisualStyleBackColor = true;
            // 
            // GuestRadioButton
            // 
            this.GuestRadioButton.AutoSize = true;
            this.GuestRadioButton.Location = new System.Drawing.Point(12, 12);
            this.GuestRadioButton.Name = "GuestRadioButton";
            this.GuestRadioButton.Size = new System.Drawing.Size(53, 16);
            this.GuestRadioButton.TabIndex = 0;
            this.GuestRadioButton.TabStop = true;
            this.GuestRadioButton.Text = "Guest";
            this.GuestRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 136);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.LoginRadioButton);
            this.Controls.Add(this.GuestRadioButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueRadioButton GuestRadioButton;
        private ColleagueRadioButton LoginRadioButton;
        private ColleagueButton cancelButton;
        private ColleagueButton okButton;
        private ColleagueTextBox usernameTextBox;
        private ColleagueTextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

