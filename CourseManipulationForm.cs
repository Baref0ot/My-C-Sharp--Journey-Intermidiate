using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem {
    /********************************************************************************************
     * Name: Matthew Wright
     * Assignment: C#2 Project1
     * Date: November 15,2019
     ********************************************************************************************/
    public partial class CourseManipulationForm : Form {

        // global object variable
        Courses course = new Courses();

        public CourseManipulationForm() {
            InitializeComponent();
        }// end CourseManipulationForm

        /** This method selects a row of date from a table based on the id. **/
        private void Admin_courseView_button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Enter Section CRN:";
            // checks to see that the entered Id is a number.
            string courseId = admin_courseID_textBox.Text;     
            // checks to see if the course exist
            if (course.selectDB(courseId)) {
            // populate the corresponding text boxes with the course information.
                admin_courseName_textBox.Text = course.getCourseName();
                admin_description_textBox.Text = course.getCourseDescription();
                admin_creditHours_TextBox.Text = course.getCreditHours().ToString(); // converting int to a string
                // display success label
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "This course has been successfully selected.";
                successLabel.Visible = true;
            }// end if
            else {
                // display success label
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected course does not exist.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_courseView_button_Click

        /** This method works to create a new row of data. **/
        private void Admin_courseCreate_Button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Fill Out all Input Boxes:";
            // populate the corresponding text boxes with the students information.
            course.setCourseId(admin_courseID_textBox.Text); 
            course.setCourseName(admin_courseName_textBox.Text);
            course.setCourseDescription(admin_description_textBox.Text);
            course.setCreditHours(Int32.Parse(admin_creditHours_TextBox.Text)); // converts string to int
            // call the insertDB course method to create a new course based on the info given in the textboxes.
            if (course.insertDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "A new course was successfully created.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The course could not be created. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end 

        /** This method works in conjunction with the selectDB method of the object to update a row of data. **/
        private void Admin_updateUpdate_Button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Use 'View' and change the desired info, Click Update when finished: ";
            course.setCourseId(admin_courseID_textBox.Text);
            course.setCourseName(admin_courseName_textBox.Text);
            course.setCourseDescription(admin_description_textBox.Text);
            course.setCreditHours(Int32.Parse(admin_creditHours_TextBox.Text)); // converts string to int
            // call the section update method, if updated success.
            if (course.updateDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "This course was successfully updated.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected course was not updated.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_updateUpdate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to delete a row of data. **/
        private void Admin_courseDelete_Button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Use 'View' to select and click delete: ";
            string enteredCourseId = admin_courseID_textBox.Text;
            // get the entered course Id from the text box and use the entered value to select a course row from the database table.
            course.selectDB(enteredCourseId);
            if (course.deleteDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "The selected course was successfully deleted.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected course could not be deleted. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_courseDelete_Button_Click

        /** This method goes back to the Admin Main Page. **/
        private void Admin_GoBack_Button_Click(object sender, EventArgs e) {
            AdminSignInSuccessful admSS = new AdminSignInSuccessful();
            admSS.Show();
            this.Close();
        }// end Admin_GoBack_Button_Click

        /** This method clears all the text boxes **/
        private void ClearAll_Button_Click(object sender, EventArgs e) {
            admin_courseID_textBox.Text = "";
            admin_courseName_textBox.Text = "";
            admin_description_textBox.Text = "";
            admin_creditHours_TextBox.Text = "";
            // displaying comfirmation 
            successLabel.ForeColor = System.Drawing.Color.Purple;
            successLabel.Text = "Text Boxes Cleared.";
        }// end ClearAll_Button_Click
    }// end class
}// end namespace
