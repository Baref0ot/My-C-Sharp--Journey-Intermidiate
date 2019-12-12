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
    public partial class Student_SignIn_Successful : Form {

        // Student Object
        public Student student2 = new Student();

        public Student_SignIn_Successful(Student s1) {
            student2 = s1;
            InitializeComponent();
        }// end Student_SignIn_Successful

        private void Student_SignIn_Successful_Load(object sender, EventArgs e) {
            nameLabel_displayBox.Text = student2.getFirstName() +" "+student2.getLastName();
            emailLabel_displayBox.Text = student2.getEmail();
            addressLabel_displayBox.Text = student2.address.getStreetName() + " " + student2.address.getCity() + ", " + student2.address.getState() + " " + student2.address.getZip();
        }// end Student_SignIn_Successful_Load

        private void ScheduleViewButton_Click(object sender, EventArgs e) {
            ViewStudentSchedule vSsch = new ViewStudentSchedule(student2);
            vSsch.Show();
            this.Close();
        }// end ScheduleViewButton_Click

        private void AddClassButton_Click(object sender, EventArgs e) {
            AddStudentClassToSchedule asc_ts = new AddStudentClassToSchedule(student2);
            asc_ts.Show();
            this.Close();
        }// end AddClassButton_Click

    }// end class
}// end namespace
