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
    public partial class AddStudentClassToSchedule : Form {

        //create a public object
        Student student4 = new Student();

        // class constructor
        public AddStudentClassToSchedule(Student s5) {
            student4 = s5;
            InitializeComponent();
        }// end AddStudentClassToSchedule

        private void AddStudentClassToSchedule_Load(object sender, EventArgs e) {
            addStudentClassToSchedule_studentID_displayBox.Text = student4.getID().ToString();
            addStudentClassToSchedule_studentName_displayBox.Text = student4.getFirstName() + " " + student4.getLastName();

            // populate the select box (combobox) with with a list of sections from the database.
            Section sectionObject = new Section();
            string[] listOfSections = sectionObject.selectAllDB();
            sectionSelect_comboBox1.Items.AddRange(listOfSections);
        }// end AddStudentClassToSchedule_Load

        private void BackButton_Click(object sender, EventArgs e) {
            Student_SignIn_Successful sss = new Student_SignIn_Successful(student4);
            sss.Show();
            this.Close();
        }// end BackButton_Click

        private void AddClass_Button_Click(object sender, EventArgs e) {
            // get the users selected class from the dropdown menu
            int sectionCRN = Int32.Parse(sectionSelect_comboBox1.Text);
            // create the Objects neccessary and add the selected class to this students schedule
            Section sectionObject = new Section();
            sectionObject.selectDB(sectionCRN);
            if (student4.schedule.addSection(sectionObject)) {
                successLabel.Visible = true;
                successLabel.Text = "Section " +sectionCRN+ " was added to your schedule.";
                successLabel.ForeColor = System.Drawing.Color.LimeGreen;
            }// end if
        }// end AddClass_Button_Click

    }// end class
}// end namespace
