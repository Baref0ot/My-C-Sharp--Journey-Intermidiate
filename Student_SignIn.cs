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
    public partial class Student_SignIn : Form {

        // Student Object
        public Student s1 = null;

        public Student_SignIn() {
            InitializeComponent();
        }// end SignIn

        private void SignIn_Button_Click(object sender, EventArgs e) {
            int studentID = 0;
            if(userID_TextBox.Text == "" || userID_TextBox.Text == null) { // checks that text box is not empty.
                SignInFailedMessage.Text = "Must enter a student id.";
                SignInFailedMessage.Visible = true;
            }// end if
            else {
                bool isAnInteger = int.TryParse(userID_TextBox.Text, out studentID);
                if (isAnInteger != true) { // checks if value entered is not an integer
                    SignInFailedMessage.Text = "Sign in Username Must be a number";
                    SignInFailedMessage.Visible = true;
                }// end if
                else {
                    // set the string value to the integer variable.
                    studentID = Int32.Parse(userID_TextBox.Text);
                    //create a new student object and search the database
                    s1 = new Student();
                    s1.selectDB(studentID);
                    // try to get the first and last name of the selected object to see if a valid student property values from the database have been stored in the variables "studentFirstName" and "studentLastName".
                    string studentFirstName = s1.getFirstName();
                    string studentLastName = s1.getLastName();
                    if (studentFirstName == "" && studentLastName == "") { // check if the object has an actual first name and last name from the database stored inside its getter methods.
                        SignInFailedMessage.Text = "Error: The student record does not exist";
                        SignInFailedMessage.Visible = true;
                    }// end if
                    else {
                        // Go to Students Profile
                        Student_SignIn_Successful StudentSignedInForm = new Student_SignIn_Successful(s1);
                        StudentSignedInForm.Show();
                        // Close this form
                        this.Close();
                    }// end inner most else
                }// end else
            }// end else
        }// end SignIn_Button_Click

    }// end class
}// end namespace
