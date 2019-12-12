namespace StudentRegistrationSystem {
    partial class Student_SignIn {
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
            this.userID_TextBox = new System.Windows.Forms.TextBox();
            this.userName_Label = new System.Windows.Forms.Label();
            this.SignIn_Button = new System.Windows.Forms.Button();
            this.Signin_Register_Link = new System.Windows.Forms.Label();
            this.SignIn_Title_Lable = new System.Windows.Forms.Label();
            this.SignInFailedMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userID_TextBox
            // 
            this.userID_TextBox.Location = new System.Drawing.Point(287, 165);
            this.userID_TextBox.Name = "userID_TextBox";
            this.userID_TextBox.Size = new System.Drawing.Size(256, 26);
            this.userID_TextBox.TabIndex = 0;
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.Location = new System.Drawing.Point(190, 168);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(91, 20);
            this.userName_Label.TabIndex = 2;
            this.userName_Label.Text = "Username: ";
            // 
            // SignIn_Button
            // 
            this.SignIn_Button.Location = new System.Drawing.Point(355, 207);
            this.SignIn_Button.Name = "SignIn_Button";
            this.SignIn_Button.Size = new System.Drawing.Size(107, 34);
            this.SignIn_Button.TabIndex = 4;
            this.SignIn_Button.Text = "SignIn";
            this.SignIn_Button.UseVisualStyleBackColor = true;
            this.SignIn_Button.Click += new System.EventHandler(this.SignIn_Button_Click);
            // 
            // Signin_Register_Link
            // 
            this.Signin_Register_Link.AutoSize = true;
            this.Signin_Register_Link.Location = new System.Drawing.Point(399, 297);
            this.Signin_Register_Link.Name = "Signin_Register_Link";
            this.Signin_Register_Link.Size = new System.Drawing.Size(0, 20);
            this.Signin_Register_Link.TabIndex = 5;
            // 
            // SignIn_Title_Lable
            // 
            this.SignIn_Title_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignIn_Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Title_Lable.Location = new System.Drawing.Point(224, 42);
            this.SignIn_Title_Lable.Name = "SignIn_Title_Lable";
            this.SignIn_Title_Lable.Size = new System.Drawing.Size(366, 56);
            this.SignIn_Title_Lable.TabIndex = 6;
            this.SignIn_Title_Lable.Text = "Student Signin ";
            this.SignIn_Title_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInFailedMessage
            // 
            this.SignInFailedMessage.AutoSize = true;
            this.SignInFailedMessage.ForeColor = System.Drawing.Color.Red;
            this.SignInFailedMessage.Location = new System.Drawing.Point(315, 261);
            this.SignInFailedMessage.Name = "SignInFailedMessage";
            this.SignInFailedMessage.Size = new System.Drawing.Size(218, 20);
            this.SignInFailedMessage.TabIndex = 7;
            this.SignInFailedMessage.Text = "Error: Student Does not exist.";
            this.SignInFailedMessage.Visible = false;
            // 
            // Student_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignInFailedMessage);
            this.Controls.Add(this.SignIn_Title_Lable);
            this.Controls.Add(this.Signin_Register_Link);
            this.Controls.Add(this.SignIn_Button);
            this.Controls.Add(this.userName_Label);
            this.Controls.Add(this.userID_TextBox);
            this.Name = "Student_SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userID_TextBox;
        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.Button SignIn_Button;
        private System.Windows.Forms.Label Signin_Register_Link;
        private System.Windows.Forms.Label SignIn_Title_Lable;
        private System.Windows.Forms.Label SignInFailedMessage;
    }
}