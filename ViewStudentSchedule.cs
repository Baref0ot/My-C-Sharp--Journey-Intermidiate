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
    public partial class ViewStudentSchedule : Form {

        // create a public object
        public Student student3 = new Student();

        public ViewStudentSchedule(Student s2) {
            student3 = s2;
            InitializeComponent();
        }// end ViewStudentSchedule

        private void ViewStudentSchedule_Load(object sender, EventArgs e) {
            // display the students id and first name.
            viewSchedule_nameLabel_displayBox.Text = student3.getID().ToString();
            viewSchedule_nameDisplayBox.Text = student3.getFirstName() + " " + student3.getLastName();

            // display the students schedule.
            int count = student3.schedule.count;
            int i = 0;
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox1.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox1.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox1.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox1.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox1.Text = se.getTeacherId().ToString();
                i++;
            }// end if
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox2.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox2.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox2.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox2.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox2.Text = se.getTeacherId().ToString();
                i++;
            }// end if
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox3.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox3.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox3.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox3.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox3.Text = se.getTeacherId().ToString();
                i++;
            }// end if
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox4.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox4.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox4.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox4.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox4.Text = se.getTeacherId().ToString();
                i++;
            }// end if
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox5.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox5.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox5.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox5.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox5.Text = se.getTeacherId().ToString();
                i++;
            }// end if
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox6.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox6.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox6.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox6.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox6.Text = se.getTeacherId().ToString();
                i++;
            }// end if
            if (i < count) {
                Section se = student3.schedule.secArray[i];
                viewSchedule_sectionCRN_displayBox7.Text = se.getCrn().ToString();
                viewSchedule_courseID_displayBox7.Text = se.getCourseId();
                viewSchedule_timeDay_displayBox7.Text = se.getTimeDays();
                viewSchedule_roomNumber_displayBox7.Text = se.getRoomNum();
                viewSchedule_instructor_displayBox7.Text = se.getTeacherId().ToString();
                i++;
            }// end if

        }// end ViewStudentSchedule_Load

        private void ViewSchedule_BackButton_Click(object sender, EventArgs e) {
            Student_SignIn_Successful stSnSuc_Form = new Student_SignIn_Successful(student3);
            stSnSuc_Form.Show();
            this.Close();
        }// end ViewSchedule_BackButton_Click

    }// end class
}// end namespace
