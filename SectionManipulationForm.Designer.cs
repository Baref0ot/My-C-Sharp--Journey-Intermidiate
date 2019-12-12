namespace StudentRegistrationSystem {
    partial class SectionManipulationForm {
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
            this.admin_sectionInstruction_TopLabel = new System.Windows.Forms.Label();
            this.admin_GoBack_Button = new System.Windows.Forms.Button();
            this.admin_sectionCRN_Label = new System.Windows.Forms.Label();
            this.admin_sectionCourseId_Label = new System.Windows.Forms.Label();
            this.admin_sectionTimeDay_Label = new System.Windows.Forms.Label();
            this.admin_sectionRoomNum_Label = new System.Windows.Forms.Label();
            this.admin_sectionInstructorID_Label = new System.Windows.Forms.Label();
            this.admin_sectionCRN_TextBox = new System.Windows.Forms.TextBox();
            this.admin_sectionCourseId_TextBox = new System.Windows.Forms.TextBox();
            this.admin_sectionTimeDay_TextBox = new System.Windows.Forms.TextBox();
            this.admin_sectionRoomNumber_TextBox = new System.Windows.Forms.TextBox();
            this.admin_sectionInstructorId_TextBox = new System.Windows.Forms.TextBox();
            this.admin_sectionView_button = new System.Windows.Forms.Button();
            this.admin_sectionCreate_Button = new System.Windows.Forms.Button();
            this.admin_sectionUpdate_Button = new System.Windows.Forms.Button();
            this.admin_sectionDelete_Button = new System.Windows.Forms.Button();
            this.clearAll_Button = new System.Windows.Forms.Button();
            this.successLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_sectionInstruction_TopLabel
            // 
            this.admin_sectionInstruction_TopLabel.Enabled = false;
            this.admin_sectionInstruction_TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionInstruction_TopLabel.Location = new System.Drawing.Point(231, 9);
            this.admin_sectionInstruction_TopLabel.Name = "admin_sectionInstruction_TopLabel";
            this.admin_sectionInstruction_TopLabel.Size = new System.Drawing.Size(451, 40);
            this.admin_sectionInstruction_TopLabel.TabIndex = 41;
            this.admin_sectionInstruction_TopLabel.Text = "Section Manipulation:";
            this.admin_sectionInstruction_TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admin_sectionInstruction_TopLabel.UseWaitCursor = true;
            // 
            // admin_GoBack_Button
            // 
            this.admin_GoBack_Button.Location = new System.Drawing.Point(775, 12);
            this.admin_GoBack_Button.Name = "admin_GoBack_Button";
            this.admin_GoBack_Button.Size = new System.Drawing.Size(101, 46);
            this.admin_GoBack_Button.TabIndex = 42;
            this.admin_GoBack_Button.Text = "Go Back";
            this.admin_GoBack_Button.UseVisualStyleBackColor = false;
            this.admin_GoBack_Button.Click += new System.EventHandler(this.Admin_GoBack_Button_Click);
            // 
            // admin_sectionCRN_Label
            // 
            this.admin_sectionCRN_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionCRN_Label.Location = new System.Drawing.Point(31, 52);
            this.admin_sectionCRN_Label.Name = "admin_sectionCRN_Label";
            this.admin_sectionCRN_Label.Size = new System.Drawing.Size(194, 40);
            this.admin_sectionCRN_Label.TabIndex = 43;
            this.admin_sectionCRN_Label.Text = "Section CRN: ";
            this.admin_sectionCRN_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_sectionCRN_Label.UseWaitCursor = true;
            // 
            // admin_sectionCourseId_Label
            // 
            this.admin_sectionCourseId_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionCourseId_Label.Location = new System.Drawing.Point(31, 92);
            this.admin_sectionCourseId_Label.Name = "admin_sectionCourseId_Label";
            this.admin_sectionCourseId_Label.Size = new System.Drawing.Size(194, 40);
            this.admin_sectionCourseId_Label.TabIndex = 44;
            this.admin_sectionCourseId_Label.Text = "Course ID: ";
            this.admin_sectionCourseId_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_sectionCourseId_Label.UseWaitCursor = true;
            // 
            // admin_sectionTimeDay_Label
            // 
            this.admin_sectionTimeDay_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionTimeDay_Label.Location = new System.Drawing.Point(31, 132);
            this.admin_sectionTimeDay_Label.Name = "admin_sectionTimeDay_Label";
            this.admin_sectionTimeDay_Label.Size = new System.Drawing.Size(194, 40);
            this.admin_sectionTimeDay_Label.TabIndex = 45;
            this.admin_sectionTimeDay_Label.Text = "Time / Day: ";
            this.admin_sectionTimeDay_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_sectionTimeDay_Label.UseWaitCursor = true;
            // 
            // admin_sectionRoomNum_Label
            // 
            this.admin_sectionRoomNum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionRoomNum_Label.Location = new System.Drawing.Point(31, 172);
            this.admin_sectionRoomNum_Label.Name = "admin_sectionRoomNum_Label";
            this.admin_sectionRoomNum_Label.Size = new System.Drawing.Size(194, 40);
            this.admin_sectionRoomNum_Label.TabIndex = 46;
            this.admin_sectionRoomNum_Label.Text = "Room Number: ";
            this.admin_sectionRoomNum_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_sectionRoomNum_Label.UseWaitCursor = true;
            // 
            // admin_sectionInstructorID_Label
            // 
            this.admin_sectionInstructorID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionInstructorID_Label.Location = new System.Drawing.Point(31, 212);
            this.admin_sectionInstructorID_Label.Name = "admin_sectionInstructorID_Label";
            this.admin_sectionInstructorID_Label.Size = new System.Drawing.Size(194, 40);
            this.admin_sectionInstructorID_Label.TabIndex = 47;
            this.admin_sectionInstructorID_Label.Text = "Instructor ID: ";
            this.admin_sectionInstructorID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_sectionInstructorID_Label.UseWaitCursor = true;
            // 
            // admin_sectionCRN_TextBox
            // 
            this.admin_sectionCRN_TextBox.Location = new System.Drawing.Point(231, 61);
            this.admin_sectionCRN_TextBox.Name = "admin_sectionCRN_TextBox";
            this.admin_sectionCRN_TextBox.Size = new System.Drawing.Size(451, 26);
            this.admin_sectionCRN_TextBox.TabIndex = 48;
            // 
            // admin_sectionCourseId_TextBox
            // 
            this.admin_sectionCourseId_TextBox.Location = new System.Drawing.Point(231, 101);
            this.admin_sectionCourseId_TextBox.Name = "admin_sectionCourseId_TextBox";
            this.admin_sectionCourseId_TextBox.Size = new System.Drawing.Size(451, 26);
            this.admin_sectionCourseId_TextBox.TabIndex = 49;
            // 
            // admin_sectionTimeDay_TextBox
            // 
            this.admin_sectionTimeDay_TextBox.Location = new System.Drawing.Point(231, 141);
            this.admin_sectionTimeDay_TextBox.Name = "admin_sectionTimeDay_TextBox";
            this.admin_sectionTimeDay_TextBox.Size = new System.Drawing.Size(451, 26);
            this.admin_sectionTimeDay_TextBox.TabIndex = 50;
            // 
            // admin_sectionRoomNumber_TextBox
            // 
            this.admin_sectionRoomNumber_TextBox.Location = new System.Drawing.Point(231, 181);
            this.admin_sectionRoomNumber_TextBox.Name = "admin_sectionRoomNumber_TextBox";
            this.admin_sectionRoomNumber_TextBox.Size = new System.Drawing.Size(451, 26);
            this.admin_sectionRoomNumber_TextBox.TabIndex = 51;
            // 
            // admin_sectionInstructorId_TextBox
            // 
            this.admin_sectionInstructorId_TextBox.Location = new System.Drawing.Point(231, 221);
            this.admin_sectionInstructorId_TextBox.Name = "admin_sectionInstructorId_TextBox";
            this.admin_sectionInstructorId_TextBox.Size = new System.Drawing.Size(451, 26);
            this.admin_sectionInstructorId_TextBox.TabIndex = 52;
            // 
            // admin_sectionView_button
            // 
            this.admin_sectionView_button.Location = new System.Drawing.Point(162, 316);
            this.admin_sectionView_button.Name = "admin_sectionView_button";
            this.admin_sectionView_button.Size = new System.Drawing.Size(101, 46);
            this.admin_sectionView_button.TabIndex = 53;
            this.admin_sectionView_button.Text = "View";
            this.admin_sectionView_button.UseVisualStyleBackColor = false;
            this.admin_sectionView_button.Click += new System.EventHandler(this.Admin_sectionView_button_Click);
            // 
            // admin_sectionCreate_Button
            // 
            this.admin_sectionCreate_Button.Location = new System.Drawing.Point(317, 316);
            this.admin_sectionCreate_Button.Name = "admin_sectionCreate_Button";
            this.admin_sectionCreate_Button.Size = new System.Drawing.Size(101, 46);
            this.admin_sectionCreate_Button.TabIndex = 54;
            this.admin_sectionCreate_Button.Text = "Create";
            this.admin_sectionCreate_Button.UseVisualStyleBackColor = false;
            this.admin_sectionCreate_Button.Click += new System.EventHandler(this.Admin_sectionCreate_Button_Click);
            // 
            // admin_sectionUpdate_Button
            // 
            this.admin_sectionUpdate_Button.Location = new System.Drawing.Point(467, 316);
            this.admin_sectionUpdate_Button.Name = "admin_sectionUpdate_Button";
            this.admin_sectionUpdate_Button.Size = new System.Drawing.Size(103, 46);
            this.admin_sectionUpdate_Button.TabIndex = 55;
            this.admin_sectionUpdate_Button.Text = "Update";
            this.admin_sectionUpdate_Button.UseVisualStyleBackColor = false;
            this.admin_sectionUpdate_Button.Click += new System.EventHandler(this.Admin_sectionUpdate_Button_Click);
            // 
            // admin_sectionDelete_Button
            // 
            this.admin_sectionDelete_Button.Location = new System.Drawing.Point(615, 316);
            this.admin_sectionDelete_Button.Name = "admin_sectionDelete_Button";
            this.admin_sectionDelete_Button.Size = new System.Drawing.Size(101, 46);
            this.admin_sectionDelete_Button.TabIndex = 56;
            this.admin_sectionDelete_Button.Text = "Delete";
            this.admin_sectionDelete_Button.UseVisualStyleBackColor = false;
            this.admin_sectionDelete_Button.Click += new System.EventHandler(this.Admin_sectionDelete_Button_Click);
            // 
            // clearAll_Button
            // 
            this.clearAll_Button.Location = new System.Drawing.Point(775, 81);
            this.clearAll_Button.Name = "clearAll_Button";
            this.clearAll_Button.Size = new System.Drawing.Size(101, 46);
            this.clearAll_Button.TabIndex = 57;
            this.clearAll_Button.Text = "Clear All";
            this.clearAll_Button.UseVisualStyleBackColor = false;
            this.clearAll_Button.Click += new System.EventHandler(this.ClearAll_Button_Click);
            // 
            // successLabel
            // 
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.successLabel.Location = new System.Drawing.Point(231, 262);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(451, 34);
            this.successLabel.TabIndex = 58;
            this.successLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successLabel.Visible = false;
            // 
            // SectionManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 397);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.clearAll_Button);
            this.Controls.Add(this.admin_sectionDelete_Button);
            this.Controls.Add(this.admin_sectionUpdate_Button);
            this.Controls.Add(this.admin_sectionCreate_Button);
            this.Controls.Add(this.admin_sectionView_button);
            this.Controls.Add(this.admin_sectionInstructorId_TextBox);
            this.Controls.Add(this.admin_sectionRoomNumber_TextBox);
            this.Controls.Add(this.admin_sectionTimeDay_TextBox);
            this.Controls.Add(this.admin_sectionCourseId_TextBox);
            this.Controls.Add(this.admin_sectionCRN_TextBox);
            this.Controls.Add(this.admin_sectionInstructorID_Label);
            this.Controls.Add(this.admin_sectionRoomNum_Label);
            this.Controls.Add(this.admin_sectionTimeDay_Label);
            this.Controls.Add(this.admin_sectionCourseId_Label);
            this.Controls.Add(this.admin_sectionCRN_Label);
            this.Controls.Add(this.admin_GoBack_Button);
            this.Controls.Add(this.admin_sectionInstruction_TopLabel);
            this.Name = "SectionManipulationForm";
            this.Text = "SectionManipulationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_sectionInstruction_TopLabel;
        private System.Windows.Forms.Button admin_GoBack_Button;
        private System.Windows.Forms.Label admin_sectionCRN_Label;
        private System.Windows.Forms.Label admin_sectionCourseId_Label;
        private System.Windows.Forms.Label admin_sectionTimeDay_Label;
        private System.Windows.Forms.Label admin_sectionRoomNum_Label;
        private System.Windows.Forms.Label admin_sectionInstructorID_Label;
        private System.Windows.Forms.TextBox admin_sectionCRN_TextBox;
        private System.Windows.Forms.TextBox admin_sectionCourseId_TextBox;
        private System.Windows.Forms.TextBox admin_sectionTimeDay_TextBox;
        private System.Windows.Forms.TextBox admin_sectionRoomNumber_TextBox;
        private System.Windows.Forms.TextBox admin_sectionInstructorId_TextBox;
        private System.Windows.Forms.Button admin_sectionView_button;
        private System.Windows.Forms.Button admin_sectionCreate_Button;
        private System.Windows.Forms.Button admin_sectionUpdate_Button;
        private System.Windows.Forms.Button admin_sectionDelete_Button;
        private System.Windows.Forms.Button clearAll_Button;
        private System.Windows.Forms.Label successLabel;
    }
}