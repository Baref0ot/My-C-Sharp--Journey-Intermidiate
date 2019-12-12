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
    public partial class SectionManipulationForm : Form {

        // global object variable
        Section section = new Section();

        public SectionManipulationForm() {
            InitializeComponent();
        }// end SectionManipulationForm

        /** This method selects a row of date from a table based on the id. **/
        private void Admin_sectionView_button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Enter Section CRN:";
            // checks to see that the entered Id is a number.
            int sectionCRN;
            bool isAnInteger = int.TryParse(admin_sectionCRN_TextBox.Text, out sectionCRN);
            if (isAnInteger != true) { // checks if value entered is not an integer
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "The section Id Must be a number";
                successLabel.Visible = true;
            }// end if
            else {
                // checks to see if the student exist
                if (section.selectDB(sectionCRN)) {
                    // populate the corresponding text boxes with the students information.
                    admin_sectionCourseId_TextBox.Text = section.getCourseId();
                    admin_sectionTimeDay_TextBox.Text = section.getTimeDays();
                    admin_sectionRoomNumber_TextBox.Text = section.getRoomNum();
                    admin_sectionInstructorId_TextBox.Text = section.getTeacherId().ToString(); // converting int to a string
                    // display success label
                    successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                    successLabel.Text = "This section has been successfully selected.";
                    successLabel.Visible = true;
                }// end if
                else {
                    // display success label
                    successLabel.ForeColor = System.Drawing.Color.Red;
                    successLabel.Text = "Error: The selected section does not exist.";
                    successLabel.Visible = true;
                }// end else
            }// end else
        }// end Admin_sectionView_button_Click

        /** This method works to create a new row of data. **/
        private void Admin_sectionCreate_Button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Fill Out all Input Boxes:";
            // populate the corresponding text boxes with the students information.
            section.setCrn(Int32.Parse(admin_sectionCRN_TextBox.Text)); // converts a string to an int
            section.setCourseId(admin_sectionCourseId_TextBox.Text);
            section.setTimeDays(admin_sectionTimeDay_TextBox.Text);
            section.setRoomNum(admin_sectionRoomNumber_TextBox.Text);
            section.setTeacherId(Int32.Parse(admin_sectionInstructorId_TextBox.Text)); // converts an string to an int
            // call the insertDB student method to create a new student based on the info given in the textboxes.
            if (section.insertDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "A section was successfully created.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The section could not be created. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// Admin_sectionCreate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to update a row of data. **/
        private void Admin_sectionUpdate_Button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Use 'View' and change the desired info, Click Update when finished: ";
            section.setCrn(Int32.Parse(admin_sectionCRN_TextBox.Text)); // converts a string to an int
            section.setCourseId(admin_sectionCourseId_TextBox.Text);
            section.setTimeDays(admin_sectionTimeDay_TextBox.Text);
            section.setRoomNum(admin_sectionRoomNumber_TextBox.Text);
            section.setTeacherId(Int32.Parse(admin_sectionInstructorId_TextBox.Text)); // converts an string to an int
            // call the section update method, if updated success.
            if (section.updateDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "A section was successfully updated.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected section was not updated.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_sectionUpdate_Button_Click

        /** This method works in conjunction with the selectDB method of the object to delete a row of data. **/
        private void Admin_sectionDelete_Button_Click(object sender, EventArgs e) {
            admin_sectionInstruction_TopLabel.Text = "Use 'View' to select and click delete: ";
            // get the entered section CRN from the text box and use the entered value to select a instructors from database table.
            int enteredCRN = Int32.Parse(admin_sectionCRN_TextBox.Text);
            section.selectDB(enteredCRN);
            if (section.deleteDB()) {
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
                successLabel.Text = "The selected section was successfully deleted.";
                successLabel.Visible = true;
            }// end if
            else {
                successLabel.ForeColor = System.Drawing.Color.Red;
                successLabel.Text = "Error: The selected section could not be deleted. Contact Developer.";
                successLabel.Visible = true;
            }// end else
        }// end Admin_sectionDelete_Button_Click

        /** This method goes back to the Admin Main Page. **/
        private void Admin_GoBack_Button_Click(object sender, EventArgs e) {
            AdminSignInSuccessful admSS = new AdminSignInSuccessful();
            admSS.Show();
            this.Close();
        }// end Admin_GoBack_Button_Click

        /** This method clears all the text boxes **/
        private void ClearAll_Button_Click(object sender, EventArgs e) {
            admin_sectionCRN_TextBox.Text = "";
            admin_sectionCourseId_TextBox.Text = "";
            admin_sectionTimeDay_TextBox.Text = "";
            admin_sectionRoomNumber_TextBox.Text = "";
            admin_sectionInstructorId_TextBox.Text = "";
            // displaying comfirmation 
            successLabel.ForeColor = System.Drawing.Color.Purple;
            successLabel.Text = "Text Boxes Cleared.";
        }// end ClearAll_Button_Click

    }// end class
}
