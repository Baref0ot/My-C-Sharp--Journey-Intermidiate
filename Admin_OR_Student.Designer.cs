namespace StudentRegistrationSystem {
    partial class Admin_OR_Student {
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
            this.iAmStudent__Button = new System.Windows.Forms.Button();
            this.iAmAdmin_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIn_Title_Lable
            // 
            this.SignIn_Title_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignIn_Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Title_Lable.Location = new System.Drawing.Point(213, 41);
            this.SignIn_Title_Lable.Name = "SignIn_Title_Lable";
            this.SignIn_Title_Lable.Size = new System.Drawing.Size(366, 56);
            this.SignIn_Title_Lable.TabIndex = 8;
            this.SignIn_Title_Lable.Text = "Login";
            this.SignIn_Title_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iAmStudent__Button
            // 
            this.iAmStudent__Button.Location = new System.Drawing.Point(162, 185);
            this.iAmStudent__Button.Name = "iAmStudent__Button";
            this.iAmStudent__Button.Size = new System.Drawing.Size(203, 69);
            this.iAmStudent__Button.TabIndex = 11;
            this.iAmStudent__Button.Text = "Student";
            this.iAmStudent__Button.UseVisualStyleBackColor = true;
            this.iAmStudent__Button.Click += new System.EventHandler(this.IAmStudent__Button_Click);
            // 
            // iAmAdmin_Button
            // 
            this.iAmAdmin_Button.Location = new System.Drawing.Point(420, 185);
            this.iAmAdmin_Button.Name = "iAmAdmin_Button";
            this.iAmAdmin_Button.Size = new System.Drawing.Size(203, 69);
            this.iAmAdmin_Button.TabIndex = 12;
            this.iAmAdmin_Button.Text = "Administrator";
            this.iAmAdmin_Button.UseVisualStyleBackColor = true;
            this.iAmAdmin_Button.Click += new System.EventHandler(this.IAmAdmin_Button_Click);
            // 
            // Admin_OR_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iAmAdmin_Button);
            this.Controls.Add(this.iAmStudent__Button);
            this.Controls.Add(this.SignIn_Title_Lable);
            this.Name = "Admin_OR_Student";
            this.Text = "Student_OR_Teacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SignIn_Title_Lable;
        private System.Windows.Forms.Button iAmStudent__Button;
        private System.Windows.Forms.Button iAmAdmin_Button;
    }
}