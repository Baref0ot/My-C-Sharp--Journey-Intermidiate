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
    public partial class AdminSignInSuccessful : Form {
        public AdminSignInSuccessful() {
            InitializeComponent();
        }// end AdminSignInSuccessful

        private void Admin_studentMan_Button_Click(object sender, EventArgs e) {
            StudentManipulationForm studmf = new StudentManipulationForm();
            studmf.Show();
            this.Close();
        }// end Admin_studentMan_Button_Click

        private void Admin_instructorMan_Button_Click(object sender, EventArgs e) {
            InstructorManipulationForm imf = new InstructorManipulationForm();
            imf.Show();
            this.Close();
        }// end Admin_instructorMan_Button_Click

        private void Admin_SectionMan_Button_Click(object sender, EventArgs e) {
            SectionManipulationForm secmf = new SectionManipulationForm();
            secmf.Show();
            this.Close();
        }// end Admin_SectionMan_Button_Click

        private void Admin_courseMan_Button_Click(object sender, EventArgs e) {
            CourseManipulationForm crsmf = new CourseManipulationForm();
            crsmf.Show();
            this.Close();
        }// end Admin_courseMan_Button_Click

        /** This button signs the admin out and takes them back to the main page to select weather they are an student or a admin. **/
        private void Admin_logOut_Button_Click(object sender, EventArgs e) {
            Admin_OR_Student aOs = new Admin_OR_Student();
            aOs.Show();
            this.Close();
        }// end Admin_logOut_Button_Click
    }// end class
}// end namespace
