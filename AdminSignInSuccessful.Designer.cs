namespace StudentRegistrationSystem {
    partial class AdminSignInSuccessful {
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
            this.adminName_Label = new System.Windows.Forms.Label();
            this.adminName_displayBox = new System.Windows.Forms.Label();
            this.admin_instructorMan_Button = new System.Windows.Forms.Button();
            this.admin_studentMan_Button = new System.Windows.Forms.Button();
            this.admin_SectionMan_Button = new System.Windows.Forms.Button();
            this.admin_courseMan_Button = new System.Windows.Forms.Button();
            this.Admin_logOut_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminName_Label
            // 
            this.adminName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName_Label.Location = new System.Drawing.Point(12, 9);
            this.adminName_Label.Name = "adminName_Label";
            this.adminName_Label.Size = new System.Drawing.Size(103, 40);
            this.adminName_Label.TabIndex = 4;
            this.adminName_Label.Text = "Name: ";
            this.adminName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminName_Label.UseWaitCursor = true;
            // 
            // adminName_displayBox
            // 
            this.adminName_displayBox.BackColor = System.Drawing.SystemColors.Control;
            this.adminName_displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName_displayBox.Location = new System.Drawing.Point(95, 15);
            this.adminName_displayBox.Name = "adminName_displayBox";
            this.adminName_displayBox.Size = new System.Drawing.Size(386, 31);
            this.adminName_displayBox.TabIndex = 22;
            this.adminName_displayBox.Text = "Matthew Wright";
            this.adminName_displayBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminName_displayBox.UseWaitCursor = true;
            // 
            // admin_instructorMan_Button
            // 
            this.admin_instructorMan_Button.Location = new System.Drawing.Point(146, 140);
            this.admin_instructorMan_Button.Name = "admin_instructorMan_Button";
            this.admin_instructorMan_Button.Size = new System.Drawing.Size(243, 46);
            this.admin_instructorMan_Button.TabIndex = 23;
            this.admin_instructorMan_Button.Text = "Instructor Manipulation";
            this.admin_instructorMan_Button.UseVisualStyleBackColor = true;
            this.admin_instructorMan_Button.Click += new System.EventHandler(this.Admin_instructorMan_Button_Click);
            // 
            // admin_studentMan_Button
            // 
            this.admin_studentMan_Button.Location = new System.Drawing.Point(146, 88);
            this.admin_studentMan_Button.Name = "admin_studentMan_Button";
            this.admin_studentMan_Button.Size = new System.Drawing.Size(243, 46);
            this.admin_studentMan_Button.TabIndex = 24;
            this.admin_studentMan_Button.Text = "Student Manipulationion";
            this.admin_studentMan_Button.UseVisualStyleBackColor = false;
            this.admin_studentMan_Button.Click += new System.EventHandler(this.Admin_studentMan_Button_Click);
            // 
            // admin_SectionMan_Button
            // 
            this.admin_SectionMan_Button.Location = new System.Drawing.Point(146, 192);
            this.admin_SectionMan_Button.Name = "admin_SectionMan_Button";
            this.admin_SectionMan_Button.Size = new System.Drawing.Size(243, 46);
            this.admin_SectionMan_Button.TabIndex = 25;
            this.admin_SectionMan_Button.Text = "Section Manipulation";
            this.admin_SectionMan_Button.UseVisualStyleBackColor = true;
            this.admin_SectionMan_Button.Click += new System.EventHandler(this.Admin_SectionMan_Button_Click);
            // 
            // admin_courseMan_Button
            // 
            this.admin_courseMan_Button.Location = new System.Drawing.Point(146, 244);
            this.admin_courseMan_Button.Name = "admin_courseMan_Button";
            this.admin_courseMan_Button.Size = new System.Drawing.Size(243, 46);
            this.admin_courseMan_Button.TabIndex = 26;
            this.admin_courseMan_Button.Text = "Course Manipulation";
            this.admin_courseMan_Button.UseVisualStyleBackColor = true;
            this.admin_courseMan_Button.Click += new System.EventHandler(this.Admin_courseMan_Button_Click);
            // 
            // Admin_logOut_Button
            // 
            this.Admin_logOut_Button.Location = new System.Drawing.Point(437, 12);
            this.Admin_logOut_Button.Name = "Admin_logOut_Button";
            this.Admin_logOut_Button.Size = new System.Drawing.Size(105, 46);
            this.Admin_logOut_Button.TabIndex = 27;
            this.Admin_logOut_Button.Text = "Log Out";
            this.Admin_logOut_Button.UseVisualStyleBackColor = true;
            this.Admin_logOut_Button.Click += new System.EventHandler(this.Admin_logOut_Button_Click);
            // 
            // AdminSignInSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 383);
            this.Controls.Add(this.Admin_logOut_Button);
            this.Controls.Add(this.admin_courseMan_Button);
            this.Controls.Add(this.admin_SectionMan_Button);
            this.Controls.Add(this.admin_studentMan_Button);
            this.Controls.Add(this.admin_instructorMan_Button);
            this.Controls.Add(this.adminName_displayBox);
            this.Controls.Add(this.adminName_Label);
            this.Name = "AdminSignInSuccessful";
            this.Text = "AdminSignInSuccessful";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label adminName_Label;
        private System.Windows.Forms.Label adminName_displayBox;
        private System.Windows.Forms.Button admin_instructorMan_Button;
        private System.Windows.Forms.Button admin_studentMan_Button;
        private System.Windows.Forms.Button admin_SectionMan_Button;
        private System.Windows.Forms.Button admin_courseMan_Button;
        private System.Windows.Forms.Button Admin_logOut_Button;
    }
}