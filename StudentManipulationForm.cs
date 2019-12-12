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
    public partial class StudentManipulationForm : Form {

        // global student object variable
        Student student = new Student();

        public StudentManipulationForm() {
            InitializeComponent();
        }// end StudentManipulationForm

        /** This method works in conjunction with the selectDB selects a row of date from a table based on the id. **/
    private void Admin_studentView_button_Click(object sender, EventArgs e) {
            admin_studentInstruction_TopLabel.Text = "Enter Student ID: ";
            // checks to see that the entered Id is a number.
            int studentId;
            bool isAnInteger = int.TryParse(admin_studentUserID_TextBox.Text, out studentId);
            if (isAnInteger != true) { // checks if value entered is not an integer
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "The Student Id Must be a number";
                successLabel.Visible = true;
            }// end if
            else {
                // checks to see if the student exist
                if (student.selectDB(studentId)) {
                    // populate the corresponding text boxes with the students information.
                    admin_studentFirstName_TextBox.Text = student.getFirstName();
                    admin_studentLastName_textbox.Text = student.getLastName();
                    admin_studentEmail_textbox.Text = student.getEmail();
                    admin_studentStreet_textbox.Text = student.address.getStreetName();
                    admin_studentCity_textbox.Text = student.address.getCity();
                    admin_studentState_textbox.Text = student.address.getState();
                    admin_studentZip_textbox.Text = student.address.getZip().ToString();// int is converted to string
                    admin_studentGrade_textbox.Text = student.getGPA().ToString(); // int is converted to string
                    // display success label
                    successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                    successLabel.Text = "This student has been successfully selected.";
                    successLabel.Visible = true;
                }// end if
                else {
                    // display success label
                    successLabel.ForeColor = System.Drawing.Color.Red;
                    successLabel.Text = "Error: The selected student account does not exist.";
                    successLabel.Visible = true;
                }// end else
            }// end else
        }// end Admin_studentView_button_Click

        /** This method works to create a new row of data. **/
        private void Admin_studentCreate_Button_Click(object sender, EventArgs e) {
            admin_studentInstruction_TopLabel.Text = "Fill Out all Input Boxes: ";
            // populate the corresponding text boxes with the students information.
            student.setID(Int32.Parse(admin_studentUserID_TextBox.Text));
            student.setFirstName(admin_studentFirstName_TextBox.Text);
            student.setLastName(admin_studentLastName_textbox.Text);
            student.setEmail(admin_studentEmail_textbox.Text);
            student.address.setStreetName(admin_studentStreet_textbox.Text);
            student.address.setCity(admin_studentCity_textbox.Text);
            student.address.setState(admin_studentState_textbox.Text);
            student.address.setZip(Int32.Parse(admin_studentZip_textbox.Text));// int is converted to string
            student.setGPA(Double.Parse(admin_studentGrade_textbox.Text)); // int is converted to string
            // call the insertDB student method to create a new student based on the info given in the textboxes.
            if (student.insertDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "A student was successfully created.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The student could not be created. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_studentCreate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to update a row of data. **/
        private void Admin_studentUpdate_Button_Click(object sender, EventArgs e) {
            admin_studentInstruction_TopLabel.Text = "Use 'View' and change the desired info, Click Update when finished: ";
            // get the information from the textboxes and set them to the objects setter methods
            student.setFirstName(admin_studentFirstName_TextBox.Text);
            student.setLastName(admin_studentLastName_textbox.Text);
            student.setEmail(admin_studentEmail_textbox.Text);
            student.address.setStreetName(admin_studentStreet_textbox.Text);
            student.address.setCity(admin_studentCity_textbox.Text);
            student.address.setState(admin_studentState_textbox.Text);
            student.address.setZip(Int32.Parse(admin_studentZip_textbox.Text)); // string converted to int
            student.setGPA(Double.Parse(admin_studentGrade_textbox.Text)); // string converted to double
            // call the student update method, if updated success.
            if (student.updateDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "A student was successfully updated.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected student was not updated.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_studentUpdate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to delete a row of data. **/
        private void Admin_studentDelete_Button_Click(object sender, EventArgs e) {
            admin_studentInstruction_TopLabel.Text = "Use 'View' to select and click delete: ";
            // get the entered user ID from the text box and use the entered value to select a student from database table.
            int enteredUserID = Int32.Parse(admin_studentUserID_TextBox.Text);
            student.selectDB(enteredUserID);
            if (student.deleteDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "The selected student was successfully deleted.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected student could not be deleted. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_studentDelete_Button_Click

        /** This method clears all the text boxes **/
        private void ClearAll_Button_Click(object sender, EventArgs e) {
            admin_studentUserID_TextBox.Text = "";
            admin_studentFirstName_TextBox.Text = "";
            admin_studentLastName_textbox.Text = "";
            admin_studentEmail_textbox.Text = "";
            admin_studentStreet_textbox.Text = "";
            admin_studentCity_textbox.Text = "";
            admin_studentState_textbox.Text = "";
            admin_studentZip_textbox.Text = "";
            admin_studentGrade_textbox.Text = "";
            // displaying comfirmation 
            successLabel.ForeColor = System.Drawing.Color.Purple;
            successLabel.Text = "Text Boxes Cleared.";
        }// end ClearAll_Button_Click

        /** This method goes back to the Admin Main Page. **/
        private void Admin_GoBack_Button_Click(object sender, EventArgs e) {
            AdminSignInSuccessful admSS = new AdminSignInSuccessful();
            admSS.Show();
            this.Close();
        }// end Admin_GoBack_Button_Click
    } // end class
}// end namespace
