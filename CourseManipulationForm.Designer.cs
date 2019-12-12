namespace StudentRegistrationSystem {
    partial class CourseManipulationForm {
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
            this.admin_courseID_Label = new System.Windows.Forms.Label();
            this.admin_courseName_label = new System.Windows.Forms.Label();
            this.admin_description_label = new System.Windows.Forms.Label();
            this.admin_creditHours_label = new System.Windows.Forms.Label();
            this.admin_GoBack_Button = new System.Windows.Forms.Button();
            this.admin_creditHours_TextBox = new System.Windows.Forms.TextBox();
            this.admin_description_textBox = new System.Windows.Forms.TextBox();
            this.admin_courseName_textBox = new System.Windows.Forms.TextBox();
            this.admin_courseID_textBox = new System.Windows.Forms.TextBox();
            this.admin_courseView_button = new System.Windows.Forms.Button();
            this.admin_courseCreate_Button = new System.Windows.Forms.Button();
            this.admin_updateUpdate_Button = new System.Windows.Forms.Button();
            this.admin_courseDelete_Button = new System.Windows.Forms.Button();
            this.clearAll_Button = new System.Windows.Forms.Button();
            this.successLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_sectionInstruction_TopLabel
            // 
            this.admin_sectionInstruction_TopLabel.Enabled = false;
            this.admin_sectionInstruction_TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sectionInstruction_TopLabel.Location = new System.Drawing.Point(246, 9);
            this.admin_sectionInstruction_TopLabel.Name = "admin_sectionInstruction_TopLabel";
            this.admin_sectionInstruction_TopLabel.Size = new System.Drawing.Size(451, 40);
            this.admin_sectionInstruction_TopLabel.TabIndex = 42;
            this.admin_sectionInstruction_TopLabel.Text = "Course Manipulation:";
            this.admin_sectionInstruction_TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admin_sectionInstruction_TopLabel.UseMnemonic = false;
            this.admin_sectionInstruction_TopLabel.UseWaitCursor = true;
            // 
            // admin_courseID_Label
            // 
            this.admin_courseID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_courseID_Label.Location = new System.Drawing.Point(52, 96);
            this.admin_courseID_Label.Name = "admin_courseID_Label";
            this.admin_courseID_Label.Size = new System.Drawing.Size(188, 40);
            this.admin_courseID_Label.TabIndex = 44;
            this.admin_courseID_Label.Text = "Course ID: ";
            this.admin_courseID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_courseID_Label.UseWaitCursor = true;
            // 
            // admin_courseName_label
            // 
            this.admin_courseName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_courseName_label.Location = new System.Drawing.Point(52, 141);
            this.admin_courseName_label.Name = "admin_courseName_label";
            this.admin_courseName_label.Size = new System.Drawing.Size(188, 40);
            this.admin_courseName_label.TabIndex = 45;
            this.admin_courseName_label.Text = "Course Name: ";
            this.admin_courseName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_courseName_label.UseWaitCursor = true;
            // 
            // admin_description_label
            // 
            this.admin_description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_description_label.Location = new System.Drawing.Point(52, 184);
            this.admin_description_label.Name = "admin_description_label";
            this.admin_description_label.Size = new System.Drawing.Size(193, 40);
            this.admin_description_label.TabIndex = 46;
            this.admin_description_label.Text = "Description: ";
            this.admin_description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_description_label.UseWaitCursor = true;
            // 
            // admin_creditHours_label
            // 
            this.admin_creditHours_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_creditHours_label.Location = new System.Drawing.Point(52, 230);
            this.admin_creditHours_label.Name = "admin_creditHours_label";
            this.admin_creditHours_label.Size = new System.Drawing.Size(188, 40);
            this.admin_creditHours_label.TabIndex = 47;
            this.admin_creditHours_label.Text = "Credit Hours: ";
            this.admin_creditHours_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_creditHours_label.UseWaitCursor = true;
            // 
            // admin_GoBack_Button
            // 
            this.admin_GoBack_Button.Location = new System.Drawing.Point(793, 12);
            this.admin_GoBack_Button.Name = "admin_GoBack_Button";
            this.admin_GoBack_Button.Size = new System.Drawing.Size(101, 46);
            this.admin_GoBack_Button.TabIndex = 48;
            this.admin_GoBack_Button.Text = "Go Back";
            this.admin_GoBack_Button.UseVisualStyleBackColor = false;
            this.admin_GoBack_Button.Click += new System.EventHandler(this.Admin_GoBack_Button_Click);
            // 
            // admin_creditHours_TextBox
            // 
            this.admin_creditHours_TextBox.Location = new System.Drawing.Point(246, 239);
            this.admin_creditHours_TextBox.Name = "admin_creditHours_TextBox";
            this.admin_creditHours_TextBox.Size = new System.Drawing.Size(451, 26);
            this.admin_creditHours_TextBox.TabIndex = 49;
            // 
            // admin_description_textBox
            // 
            this.admin_description_textBox.Location = new System.Drawing.Point(246, 193);
            this.admin_description_textBox.Name = "admin_description_textBox";
            this.admin_description_textBox.Size = new System.Drawing.Size(451, 26);
            this.admin_description_textBox.TabIndex = 50;
            // 
            // admin_courseName_textBox
            // 
            this.admin_courseName_textBox.Location = new System.Drawing.Point(246, 150);
            this.admin_courseName_textBox.Name = "admin_courseName_textBox";
            this.admin_courseName_textBox.Size = new System.Drawing.Size(451, 26);
            this.admin_courseName_textBox.TabIndex = 51;
            // 
            // admin_courseID_textBox
            // 
            this.admin_courseID_textBox.Location = new System.Drawing.Point(246, 105);
            this.admin_courseID_textBox.Name = "admin_courseID_textBox";
            this.admin_courseID_textBox.Size = new System.Drawing.Size(451, 26);
            this.admin_courseID_textBox.TabIndex = 52;
            // 
            // admin_courseView_button
            // 
            this.admin_courseView_button.Location = new System.Drawing.Point(175, 342);
            this.admin_courseView_button.Name = "admin_courseView_button";
            this.admin_courseView_button.Size = new System.Drawing.Size(101, 46);
            this.admin_courseView_button.TabIndex = 54;
            this.admin_courseView_button.Text = "View";
            this.admin_courseView_button.UseVisualStyleBackColor = false;
            this.admin_courseView_button.Click += new System.EventHandler(this.Admin_courseView_button_Click);
            // 
            // admin_courseCreate_Button
            // 
            this.admin_courseCreate_Button.Location = new System.Drawing.Point(324, 342);
            this.admin_courseCreate_Button.Name = "admin_courseCreate_Button";
            this.admin_courseCreate_Button.Size = new System.Drawing.Size(101, 46);
            this.admin_courseCreate_Button.TabIndex = 55;
            this.admin_courseCreate_Button.Text = "Create";
            this.admin_courseCreate_Button.UseVisualStyleBackColor = false;
            this.admin_courseCreate_Button.Click += new System.EventHandler(this.Admin_courseCreate_Button_Click);
            // 
            // admin_updateUpdate_Button
            // 
            this.admin_updateUpdate_Button.Location = new System.Drawing.Point(472, 342);
            this.admin_updateUpdate_Button.Name = "admin_updateUpdate_Button";
            this.admin_updateUpdate_Button.Size = new System.Drawing.Size(103, 46);
            this.admin_updateUpdate_Button.TabIndex = 56;
            this.admin_updateUpdate_Button.Text = "Update";
            this.admin_updateUpdate_Button.UseVisualStyleBackColor = false;
            this.admin_updateUpdate_Button.Click += new System.EventHandler(this.Admin_updateUpdate_Button_Click);
            // 
            // admin_courseDelete_Button
            // 
            this.admin_courseDelete_Button.Location = new System.Drawing.Point(629, 342);
            this.admin_courseDelete_Button.Name = "admin_courseDelete_Button";
            this.admin_courseDelete_Button.Size = new System.Drawing.Size(101, 46);
            this.admin_courseDelete_Button.TabIndex = 57;
            this.admin_courseDelete_Button.Text = "Delete";
            this.admin_courseDelete_Button.UseVisualStyleBackColor = false;
            this.admin_courseDelete_Button.Click += new System.EventHandler(this.Admin_courseDelete_Button_Click);
            // 
            // clearAll_Button
            // 
            this.clearAll_Button.Location = new System.Drawing.Point(793, 74);
            this.clearAll_Button.Name = "clearAll_Button";
            this.clearAll_Button.Size = new System.Drawing.Size(101, 46);
            this.clearAll_Button.TabIndex = 58;
            this.clearAll_Button.Text = "Clear All";
            this.clearAll_Button.UseVisualStyleBackColor = false;
            this.clearAll_Button.Click += new System.EventHandler(this.ClearAll_Button_Click);
            // 
            // successLabel
            // 
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.successLabel.Location = new System.Drawing.Point(246, 283);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(451, 34);
            this.successLabel.TabIndex = 59;
            this.successLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successLabel.Visible = false;
            // 
            // CourseManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 427);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.clearAll_Button);
            this.Controls.Add(this.admin_courseDelete_Button);
            this.Controls.Add(this.admin_updateUpdate_Button);
            this.Controls.Add(this.admin_courseCreate_Button);
            this.Controls.Add(this.admin_courseView_button);
            this.Controls.Add(this.admin_courseID_textBox);
            this.Controls.Add(this.admin_courseName_textBox);
            this.Controls.Add(this.admin_description_textBox);
            this.Controls.Add(this.admin_creditHours_TextBox);
            this.Controls.Add(this.admin_GoBack_Button);
            this.Controls.Add(this.admin_creditHours_label);
            this.Controls.Add(this.admin_description_label);
            this.Controls.Add(this.admin_courseName_label);
            this.Controls.Add(this.admin_courseID_Label);
            this.Controls.Add(this.admin_sectionInstruction_TopLabel);
            this.Name = "CourseManipulationForm";
            this.Text = "CourseManipulationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_sectionInstruction_TopLabel;
        private System.Windows.Forms.Label admin_courseID_Label;
        private System.Windows.Forms.Label admin_courseName_label;
        private System.Windows.Forms.Label admin_description_label;
        private System.Windows.Forms.Label admin_creditHours_label;
        private System.Windows.Forms.Button admin_GoBack_Button;
        private System.Windows.Forms.TextBox admin_creditHours_TextBox;
        private System.Windows.Forms.TextBox admin_description_textBox;
        private System.Windows.Forms.TextBox admin_courseName_textBox;
        private System.Windows.Forms.TextBox admin_courseID_textBox;
        private System.Windows.Forms.Button admin_courseView_button;
        private System.Windows.Forms.Button admin_courseCreate_Button;
        private System.Windows.Forms.Button admin_updateUpdate_Button;
        private System.Windows.Forms.Button admin_courseDelete_Button;
        private System.Windows.Forms.Button clearAll_Button;
        private System.Windows.Forms.Label successLabel;
    }
}