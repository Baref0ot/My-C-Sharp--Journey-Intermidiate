namespace StudentRegistrationSystem {
    partial class AddStudentClassToSchedule {
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
            this.studentID_Label = new System.Windows.Forms.Label();
            this.studentName_Label = new System.Windows.Forms.Label();
            this.viewSchedule_sectionCRN_Label = new System.Windows.Forms.Label();
            this.addClass_Button = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.addSection_descriptionLabel = new System.Windows.Forms.Label();
            this.addStudentClassToSchedule_studentID_displayBox = new System.Windows.Forms.Label();
            this.addStudentClassToSchedule_studentName_displayBox = new System.Windows.Forms.Label();
            this.sectionSelect_comboBox1 = new System.Windows.Forms.ComboBox();
            this.successLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentID_Label
            // 
            this.studentID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentID_Label.Location = new System.Drawing.Point(12, 9);
            this.studentID_Label.Name = "studentID_Label";
            this.studentID_Label.Size = new System.Drawing.Size(121, 40);
            this.studentID_Label.TabIndex = 3;
            this.studentID_Label.Text = "Student ID: ";
            this.studentID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentID_Label.UseWaitCursor = true;
            // 
            // studentName_Label
            // 
            this.studentName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName_Label.Location = new System.Drawing.Point(2, 49);
            this.studentName_Label.Name = "studentName_Label";
            this.studentName_Label.Size = new System.Drawing.Size(189, 40);
            this.studentName_Label.TabIndex = 4;
            this.studentName_Label.Text = "Student Name: ";
            this.studentName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentName_Label.UseWaitCursor = true;
            // 
            // viewSchedule_sectionCRN_Label
            // 
            this.viewSchedule_sectionCRN_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSchedule_sectionCRN_Label.Location = new System.Drawing.Point(12, 138);
            this.viewSchedule_sectionCRN_Label.Name = "viewSchedule_sectionCRN_Label";
            this.viewSchedule_sectionCRN_Label.Size = new System.Drawing.Size(167, 40);
            this.viewSchedule_sectionCRN_Label.TabIndex = 12;
            this.viewSchedule_sectionCRN_Label.Text = "Section CRN: ";
            this.viewSchedule_sectionCRN_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewSchedule_sectionCRN_Label.UseWaitCursor = true;
            // 
            // addClass_Button
            // 
            this.addClass_Button.Location = new System.Drawing.Point(257, 352);
            this.addClass_Button.Name = "addClass_Button";
            this.addClass_Button.Size = new System.Drawing.Size(133, 46);
            this.addClass_Button.TabIndex = 17;
            this.addClass_Button.Text = "Add Class";
            this.addClass_Button.UseVisualStyleBackColor = true;
            this.addClass_Button.Click += new System.EventHandler(this.AddClass_Button_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(473, 352);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(133, 46);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addSection_descriptionLabel
            // 
            this.addSection_descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSection_descriptionLabel.Location = new System.Drawing.Point(222, 92);
            this.addSection_descriptionLabel.Name = "addSection_descriptionLabel";
            this.addSection_descriptionLabel.Size = new System.Drawing.Size(352, 40);
            this.addSection_descriptionLabel.TabIndex = 19;
            this.addSection_descriptionLabel.Text = "Select a CRN to add to your schedule: ";
            this.addSection_descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addSection_descriptionLabel.UseWaitCursor = true;
            // 
            // addStudentClassToSchedule_studentID_displayBox
            // 
            this.addStudentClassToSchedule_studentID_displayBox.BackColor = System.Drawing.SystemColors.Control;
            this.addStudentClassToSchedule_studentID_displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentClassToSchedule_studentID_displayBox.Location = new System.Drawing.Point(139, 15);
            this.addStudentClassToSchedule_studentID_displayBox.Name = "addStudentClassToSchedule_studentID_displayBox";
            this.addStudentClassToSchedule_studentID_displayBox.Size = new System.Drawing.Size(551, 31);
            this.addStudentClassToSchedule_studentID_displayBox.TabIndex = 21;
            this.addStudentClassToSchedule_studentID_displayBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentClassToSchedule_studentID_displayBox.UseWaitCursor = true;
            // 
            // addStudentClassToSchedule_studentName_displayBox
            // 
            this.addStudentClassToSchedule_studentName_displayBox.BackColor = System.Drawing.SystemColors.Control;
            this.addStudentClassToSchedule_studentName_displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentClassToSchedule_studentName_displayBox.Location = new System.Drawing.Point(166, 56);
            this.addStudentClassToSchedule_studentName_displayBox.Name = "addStudentClassToSchedule_studentName_displayBox";
            this.addStudentClassToSchedule_studentName_displayBox.Size = new System.Drawing.Size(524, 28);
            this.addStudentClassToSchedule_studentName_displayBox.TabIndex = 22;
            this.addStudentClassToSchedule_studentName_displayBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentClassToSchedule_studentName_displayBox.UseWaitCursor = true;
            // 
            // sectionSelect_comboBox1
            // 
            this.sectionSelect_comboBox1.DropDownHeight = 80;
            this.sectionSelect_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionSelect_comboBox1.FormattingEnabled = true;
            this.sectionSelect_comboBox1.IntegralHeight = false;
            this.sectionSelect_comboBox1.ItemHeight = 20;
            this.sectionSelect_comboBox1.Location = new System.Drawing.Point(170, 147);
            this.sectionSelect_comboBox1.Name = "sectionSelect_comboBox1";
            this.sectionSelect_comboBox1.Size = new System.Drawing.Size(520, 28);
            this.sectionSelect_comboBox1.TabIndex = 23;
            
            // 
            // successLabel
            // 
            this.successLabel.ForeColor = System.Drawing.Color.Red;
            this.successLabel.Location = new System.Drawing.Point(170, 178);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(520, 30);
            this.successLabel.TabIndex = 24;
            this.successLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successLabel.Visible = false;
            // 
            // AddStudentClassToSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.sectionSelect_comboBox1);
            this.Controls.Add(this.addStudentClassToSchedule_studentName_displayBox);
            this.Controls.Add(this.addStudentClassToSchedule_studentID_displayBox);
            this.Controls.Add(this.addSection_descriptionLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.addClass_Button);
            this.Controls.Add(this.viewSchedule_sectionCRN_Label);
            this.Controls.Add(this.studentName_Label);
            this.Controls.Add(this.studentID_Label);
            this.Name = "AddStudentClassToSchedule";
            this.Text = "addStudentClassToSchedule";
            this.Load += new System.EventHandler(this.AddStudentClassToSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label studentID_Label;
        private System.Windows.Forms.Label studentName_Label;
        private System.Windows.Forms.Label viewSchedule_sectionCRN_Label;
        private System.Windows.Forms.Button addClass_Button;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label addSection_descriptionLabel;
        private System.Windows.Forms.Label addStudentClassToSchedule_studentID_displayBox;
        private System.Windows.Forms.Label addStudentClassToSchedule_studentName_displayBox;
        private System.Windows.Forms.ComboBox sectionSelect_comboBox1;
        private System.Windows.Forms.Label successLabel;
    }
}