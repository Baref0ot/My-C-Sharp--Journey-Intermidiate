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
    public partial class InstructorManipulationForm : Form {

        // global object variable
        Teacher teacher = new Teacher();

        public InstructorManipulationForm() {
            InitializeComponent();
        }// end InstructorManipulationForm

        /** This method works in conjunction with the selectDB selects a row of date from a table based on the id. **/
        private void Admin_instructorView_button_Click(object sender, EventArgs e) {
            admin_instructorInstruction_TopLabel.Text = "Enter Instructor ID: ";
            // checks to see that the entered Id is a number.
            int teacherId;
            bool isAnInteger = int.TryParse(admin_instructorUserID_TextBox.Text, out teacherId);
            if (isAnInteger != true) { // checks if value entered is not an integer
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "The Instructor Id Must be a number";
                successLabel.Visible = true;
            }// end if
            else {
                // checks to see if the student exist
                if (teacher.selectDB(teacherId)) {
                    // populate the corresponding text boxes with the students information.
                    admin_instructorFirstName_textbox.Text = teacher.getFirstName();
                    admin_instructorLastName_textbox.Text = teacher.getLastName();
                    admin_instructorEmail_textbox.Text = teacher.getEmail();
                    admin_instructorOfficeNum_textbox.Text = teacher.getOfficeNum();
                    admin_instructorStreet_textbox.Text = teacher.address.getStreetName();
                    admin_instructorCity_textbox.Text = teacher.address.getCity();
                    admin_instructorState_textbox.Text = teacher.address.getState();
                    admin_instructorZip_textbox.Text = teacher.address.getZip().ToString();// int is converted to string
                    // display success label
                    successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                    successLabel.Text = "This instructor has been successfully selected.";
                    successLabel.Visible = true;
                }// end if
                else {
                    // display success label
                    successLabel.ForeColor = System.Drawing.Color.Red;
                    successLabel.Text = "Error: The selected instructor account does not exist.";
                    successLabel.Visible = true;
                }// end else
            }// end else
        }// end Admin_instructorView_button_Click

        /** This method works to create a new row of data. **/
        private void Admin_instructorCreate_Button_Click(object sender, EventArgs e) {
            admin_instructorInstruction_TopLabel.Text = "Fill Out all Input Boxes: ";
            // populate the corresponding text boxes with the students information.
            teacher.setID(Int32.Parse(admin_instructorUserID_TextBox.Text));
            teacher.setFirstName(admin_instructorFirstName_textbox.Text);
            teacher.setLastName(admin_instructorLastName_textbox.Text);
            teacher.setEmail(admin_instructorEmail_textbox.Text);
            teacher.setOfficeNum(admin_instructorOfficeNum_textbox.Text);
            teacher.address.setStreetName(admin_instructorStreet_textbox.Text);
            teacher.address.setCity(admin_instructorCity_textbox.Text);
            teacher.address.setState(admin_instructorState_textbox.Text);
            teacher.address.setZip(Int32.Parse(admin_instructorZip_textbox.Text));// int is converted to string
            // call the insertDB student method to create a new student based on the info given in the textboxes.
            if (teacher.insertDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "An instructor was successfully created.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The instructor could not be created. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_instructorCreate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to update a row of data. **/
        private void Admin_instructorUpdate_Button_Click(object sender, EventArgs e) {
            admin_instructorInstruction_TopLabel.Text = "Use 'View' and change the desired info, Click Update when finished: ";
            // get the information from the textboxes and set them to the objects setter methods
            teacher.setID(Int32.Parse(admin_instructorUserID_TextBox.Text));
            teacher.setFirstName(admin_instructorFirstName_textbox.Text);
            teacher.setLastName(admin_instructorLastName_textbox.Text);
            teacher.setEmail(admin_instructorEmail_textbox.Text);
            teacher.setOfficeNum(admin_instructorOfficeNum_textbox.Text);
            teacher.address.setStreetName(admin_instructorStreet_textbox.Text);
            teacher.address.setCity(admin_instructorCity_textbox.Text);
            teacher.address.setState(admin_instructorState_textbox.Text);
            teacher.address.setZip(Int32.Parse(admin_instructorZip_textbox.Text));// int is converted to string
            // call the student update method, if updated success.
            if (teacher.updateDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "An instructor was successfully updated.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected instructor was not updated.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_instructorUpdate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to delete a row of data. **/
        private void Admin_instructorDelete_Button_Click(object sender, EventArgs e) {
            admin_instructorInstruction_TopLabel.Text = "Use 'View' to select and click delete: ";
            // get the entered user ID from the text box and use the entered value to select a instructors from database table.
            int enteredUserID = Int32.Parse(admin_instructorUserID_TextBox.Text);
            teacher.selectDB(enteredUserID);
            if (teacher.deleteDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "The selected instructor was successfully deleted.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected instructor could not be deleted. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_instructorDelete_Button_Click

        /** This method goes back to the Admin Main Page. **/
        private void Admin_GoBack_Button_Click(object sender, EventArgs e) {
            AdminSignInSuccessful admSS = new AdminSignInSuccessful();
            admSS.Show();
            this.Close();
        }// end Admin_GoBack_Button_Click

        /** This method clears all the text boxes **/
        private void ClearAll_Button_Click(object sender, EventArgs e) {
            admin_instructorUserID_TextBox.Text = "";
            admin_instructorFirstName_textbox.Text = "";
            admin_instructorLastName_textbox.Text = "";
            admin_instructorEmail_textbox.Text = "";
            admin_instructorOfficeNum_textbox.Text = "";
            admin_instructorStreet_textbox.Text = "";
            admin_instructorCity_textbox.Text = "";
            admin_instructorState_textbox.Text = "";
            admin_instructorZip_textbox.Text = "";
            // displaying comfirmation 
            successLabel.ForeColor = System.Drawing.Color.Purple;
            successLabel.Text = "Text Boxes Cleared.";
        }// end ClearAll_Button_Click
    }// end class
}
