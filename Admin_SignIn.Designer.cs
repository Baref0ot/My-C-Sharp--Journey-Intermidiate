namespace StudentRegistrationSystem {
    partial class Admin_SignIn {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.SignIn_Title_Lable = new System.Windows.Forms.Label();
            this.userName_Label = new System.Windows.Forms.Label();
            this.admin_userID_TextBox = new System.Windows.Forms.TextBox();
            this.Admin_SignIn_Button = new System.Windows.Forms.Button();
            this.SignInFailedMessage = new System.Windows.Forms.Label();
            this.GoBack_AdminSignIn_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIn_Title_Lable
            // 
            this.SignIn_Title_Lable.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.SignIn_Title_Lable.AllowDrop = true;
            this.SignIn_Title_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignIn_Title_Lable.AutoEllipsis = true;
            this.SignIn_Title_Lable.CausesValidation = false;
            this.SignIn_Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Title_Lable.Location = new System.Drawing.Point(236, 46);
            this.SignIn_Title_Lable.Name = "SignIn_Title_Lable";
            this.SignIn_Title_Lable.Size = new System.Drawing.Size(366, 56);
            this.SignIn_Title_Lable.TabIndex = 7;
            this.SignIn_Title_Lable.Text = "Admin Signin ";
            this.SignIn_Title_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignIn_Title_Lable.UseWaitCursor = true;
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.Location = new System.Drawing.Point(169, 149);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(91, 20);
            this.userName_Label.TabIndex = 8;
            this.userName_Label.Text = "Username: ";
            // 
            // admin_userID_TextBox
            // 
            this.admin_userID_TextBox.Location = new System.Drawing.Point(266, 146);
            this.admin_userID_TextBox.Name = "admin_userID_TextBox";
            this.admin_userID_TextBox.Size = new System.Drawing.Size(277, 26);
            this.admin_userID_TextBox.TabIndex = 9;
            // 
            // Admin_SignIn_Button
            // 
            this.Admin_SignIn_Button.Location = new System.Drawing.Point(347, 194);
            this.Admin_SignIn_Button.Name = "Admin_SignIn_Button";
            this.Admin_SignIn_Button.Size = new System.Drawing.Size(107, 34);
            this.Admin_SignIn_Button.TabIndex = 10;
            this.Admin_SignIn_Button.Text = "SignIn";
            this.Admin_SignIn_Button.UseVisualStyleBackColor = true;
            this.Admin_SignIn_Button.Click += new System.EventHandler(this.Admin_SignIn_Button_Click);
            // 
            // SignInFailedMessage
            // 
            this.SignInFailedMessage.AutoSize = true;
            this.SignInFailedMessage.ForeColor = System.Drawing.Color.Red;
            this.SignInFailedMessage.Location = new System.Drawing.Point(295, 252);
            this.SignInFailedMessage.Name = "SignInFailedMessage";
            this.SignInFailedMessage.Size = new System.Drawing.Size(206, 20);
            this.SignInFailedMessage.TabIndex = 11;
            this.SignInFailedMessage.Text = "Error: Admin Does not exist.";
            this.SignInFailedMessage.Visible = false;
            // 
            // GoBack_AdminSignIn_Button
            // 
            this.GoBack_AdminSignIn_Button.Location = new System.Drawing.Point(681, 12);
            this.GoBack_AdminSignIn_Button.Name = "GoBack_AdminSignIn_Button";
            this.GoBack_AdminSignIn_Button.Size = new System.Drawing.Size(107, 34);
            this.GoBack_AdminSignIn_Button.TabIndex = 12;
            this.GoBack_AdminSignIn_Button.Text = "Go Back";
            this.GoBack_AdminSignIn_Button.UseVisualStyleBackColor = true;
            this.GoBack_AdminSignIn_Button.Click += new System.EventHandler(this.GoBack_AdminSignIn_Button_Click);
            // 
            // Admin_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.GoBack_AdminSignIn_Button);
            this.Controls.Add(this.SignInFailedMessage);
            this.Controls.Add(this.Admin_SignIn_Button);
            this.Controls.Add(this.admin_userID_TextBox);
            this.Controls.Add(this.userName_Label);
            this.Controls.Add(this.SignIn_Title_Lable);
            this.Name = "Admin_SignIn";
            this.Text = "Teacher_SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignIn_Title_Lable;
        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.TextBox admin_userID_TextBox;
        private System.Windows.Forms.Button Admin_SignIn_Button;
        private System.Windows.Forms.Label SignInFailedMessage;
        private System.Windows.Forms.Button GoBack_AdminSignIn_Button;
    }
}