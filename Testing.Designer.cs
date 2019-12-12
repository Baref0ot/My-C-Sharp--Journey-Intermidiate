namespace StudentRegistrationSystem {
    partial class Testing {
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
            this.StudentTestButton = new System.Windows.Forms.Button();
            this.TeacherTestButton = new System.Windows.Forms.Button();
            this.CourseDB_Test_Btn = new System.Windows.Forms.Button();
            this.SectionDB_Test_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentTestButton
            // 
            this.StudentTestButton.Location = new System.Drawing.Point(45, 48);
            this.StudentTestButton.Name = "StudentTestButton";
            this.StudentTestButton.Size = new System.Drawing.Size(151, 49);
            this.StudentTestButton.TabIndex = 0;
            this.StudentTestButton.Text = "Student Test";
            this.StudentTestButton.UseVisualStyleBackColor = true;
            this.StudentTestButton.Click += new System.EventHandler(this.StudentTestButton_Click);
            // 
            // TeacherTestButton
            // 
            this.TeacherTestButton.Location = new System.Drawing.Point(221, 48);
            this.TeacherTestButton.Name = "TeacherTestButton";
            this.TeacherTestButton.Size = new System.Drawing.Size(151, 49);
            this.TeacherTestButton.TabIndex = 1;
            this.TeacherTestButton.Text = "Teacher Test";
            this.TeacherTestButton.UseVisualStyleBackColor = true;
            this.TeacherTestButton.Click += new System.EventHandler(this.TeacherTestButton_Click);
            // 
            // CourseDB_Test_Btn
            // 
            this.CourseDB_Test_Btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CourseDB_Test_Btn.Location = new System.Drawing.Point(397, 48);
            this.CourseDB_Test_Btn.Name = "CourseDB_Test_Btn";
            this.CourseDB_Test_Btn.Size = new System.Drawing.Size(151, 49);
            this.CourseDB_Test_Btn.TabIndex = 3;
            this.CourseDB_Test_Btn.Text = "CourseDB Test";
            this.CourseDB_Test_Btn.UseVisualStyleBackColor = true;
            this.CourseDB_Test_Btn.Click += new System.EventHandler(this.CourseDB_Test_Btn_Click);
            // 
            // SectionDB_Test_Btn
            // 
            this.SectionDB_Test_Btn.Location = new System.Drawing.Point(585, 48);
            this.SectionDB_Test_Btn.Name = "SectionDB_Test_Btn";
            this.SectionDB_Test_Btn.Size = new System.Drawing.Size(152, 49);
            this.SectionDB_Test_Btn.TabIndex = 4;
            this.SectionDB_Test_Btn.Text = "SectionsDB Test";
            this.SectionDB_Test_Btn.UseVisualStyleBackColor = true;
            this.SectionDB_Test_Btn.Click += new System.EventHandler(this.SectionDB_Test_Btn_Click);
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SectionDB_Test_Btn);
            this.Controls.Add(this.CourseDB_Test_Btn);
            this.Controls.Add(this.TeacherTestButton);
            this.Controls.Add(this.StudentTestButton);
            this.Name = "Testing";
            this.Text = "Testing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentTestButton;
        private System.Windows.Forms.Button TeacherTestButton;
        private System.Windows.Forms.Button CourseDB_Test_Btn;
        private System.Windows.Forms.Button SectionDB_Test_Btn;
    }
}

