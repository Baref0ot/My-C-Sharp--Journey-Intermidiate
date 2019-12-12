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
    public partial class Admin_SignIn : Form {

        public Admin_SignIn() {
            InitializeComponent();
        }// end Admin_SignIn

        private void Admin_SignIn_Button_Click(object sender, EventArgs e) {
            int adminID = 0;

            if (admin_userID_TextBox.Text == "" || admin_userID_TextBox.Text == null) { // checks that text box is not empty.
                SignInFailedMessage.Text = "Must enter an Admin id.";
                SignInFailedMessage.Visible = true;
            }// end if
            else {
                bool isAnInteger = int.TryParse(admin_userID_TextBox.Text, out adminID);
                if (isAnInteger != true) { // checks if value entered is not an integer
                    SignInFailedMessage.Text = "Sign in Username Must be a number";
                    SignInFailedMessage.Visible = true;
                }// end if
                else {

                    
                    if (adminID != 12345) { // check if the object has an actual first name and last name from the database stored inside its getter methods.
                        SignInFailedMessage.Text = "Error: The Admin does not exist";
                        SignInFailedMessage.Visible = true;
                    }// end if
                    else {
                        // Go to Objects Profile
                        AdminSignInSuccessful AdminSignedInForm = new AdminSignInSuccessful();
                        AdminSignedInForm.Show();
                        // Close this form
                        this.Close();
                    }// end inner most else

                }// end else
            }// end else
        }// end Admin_SignIn_Button_Click

        /** This button takes the user back to the main page to select weather they are a student or admin. **/
        private void GoBack_AdminSignIn_Button_Click(object sender, EventArgs e) {
            Admin_OR_Student aOs = new Admin_OR_Student();
            aOs.Show();
            this.Close();
        }// end  GoBack_AdminSignIn_Button_Click
    }// end class
}// end namespace

