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
    public partial class Testing : Form {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/
        public Testing() {
            InitializeComponent();
        }

        private void StudentTestButton_Click(object sender, EventArgs e) {
            //Student s1 = new Student(4.0, 9, "Matthew", "Wright", "Mattwright@gmail.com", new Address("121 Pine Ridge Rd", "White", "GA", 30184));
            //Section sec1 = new Section(5555, "C1133", "MW 1-3", "F1112", 7);
            //s1.schedule.addSection(sec1);
            //s1.display();

            // testing the select database method.
            //Student s2 = new Student();
            //s2.selectDB(1);
            //s2.display();

            //// testing the insert database method.
            //Student s3 = new Student(4.0, 33, "Matthew", "Wright", "Mattwright@gmail.com", new Address("121 Pine Ridge Rd", "White", "GA", 30184));
            //s3.insertDB();

            //// testing the update database method.
            //Student s4 = new Student();
            //s4.selectDB(33);
            //s4.address.setStreetName("123 Example Ln Dr");
            //s4.updateDB();
            //s4.display();

            //// testing the delete row from a database method. 
            //Student s5 = new Student();
            //s5.selectDB(33);
            //s5.deleteDB();

            // testing the select method which now inlucdeds the student getSchedule() method from the database
            Student s6 = new Student();
            s6.selectDB(12);
            s6.display();

            Student s7 = new Student();
            s7.selectDB(11);
            s7.display();
        }// end StudentTestButton_Click

        private void TeacherTestButton_Click(object sender, EventArgs e) {
            //Teacher t1 = new Teacher("F3512", 7, "Lanier", "Turley", "LTurley@gmail.com", new Address("231 Eliane Brook St", "Cartersville", "GA", 30121));
            //Console.WriteLine("=========TEST========");
            //Section sec1 = new Section(5555, "C1133", "MW 1-3", "F1112", 7);
            //t1.schedule.addSection(sec1);
            //t1.display();

            //// testing the select database method.
            //Teacher t2 = new Teacher();
            //t2.selectDB(6);
            //t2.display();

            //// testing the insert database method.
            //Teacher t3 = new Teacher("F3512", 30, "Lanier", "Turley", "LTurley@gmail.com", new Address("231 Eliane Brook St", "Cartersville", "GA", 30121));
            //t3.insertDB();

            //// testing the update database method.
            //Teacher t3 = new Teacher();
            //t3.selectDB(6);
            //t3.setFirstName("Jacob");
            //t3.setLastName("Rittweger");
            //t3.updateDB();

            //// testing the update database method.
            //Teacher t3 = new Teacher();
            //t3.selectDB(30);
            //t3.deleteDB();

            // testing the select method which now inlucdeds the Teacher getSchedule() method from the database
            Teacher t4 = new Teacher();
            t4.selectDB(4);
            t4.display();

            Teacher t5 = new Teacher();
            t5.selectDB(3);
            t5.display();
        }// end TeacherTestButton_Click

        private void CourseDB_Test_Btn_Click(object sender, EventArgs e) {
            //// testing the select database method.
            //Courses c1 = new Courses();
            //c1.selectDB("CIST 1001");
            //c1.display();

            //// testing the insert database method.
            //Courses c2 = new Courses("CIST 1313", "Intro to Python", "Intro to Python Programming Language.", 4);
            //c2.insertDB();

            //// testing the update database method.
            //Courses c3 = new Courses();
            //c3.selectDB("CIST 1313");
            //c3.setCourseName("PHP 2");
            //c3.setCourseDescription("Intro Update PHP 1");
            //c3.setCreditHours(7);
            //c3.updateDB();

            // testing the delete row of data method.
            Courses c4 = new Courses();
            c4.selectDB("CIST 1313");
            c4.deleteDB();
        }// end CourseDB_Test_Btn_Click

        private void SectionDB_Test_Btn_Click(object sender, EventArgs e) {
            //// testing the select database method.
            //Section s1 = new Section();
            //s1.selectDB(30101);
            //s1.display();

            //// testing the insert database method.
            //Section s2 = new Section(40307, "CIST 1313", "TTr 1-5pm", "F1177", 6);
            //s2.insertDB();

            //// testing the update database method.
            //Section s3 = new Section();
            //s3.selectDB(40307);
            //s3.setTimeDays("TTH 1-7pm");
            //s3.setRoomNum("F1133");
            //s3.updateDB();

            // testing the delete a row of data from the database method.
            Section s4 = new Section();
            s4.selectDB(40307);
            s4.deleteDB();
        }// end SectionDB_Test_Btn_Click


        // As of 10/08/2019 @ 4:25am Student, Teacher, Courses, Section all need deleteDB() methods.

    }// end TestCodeButton_Click
}
