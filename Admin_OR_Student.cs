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
    public partial class Admin_OR_Student : Form {

        public Admin_OR_Student() {
            InitializeComponent();
        }// end Student_OR_Teacher

        private void IAmStudent__Button_Click(object sender, EventArgs e) {
            Student_SignIn stdntSignInForm = new Student_SignIn();
            stdntSignInForm.Show();

            // if this (the starting form) is closed with the Close() method the program will stop running.
            this.Hide();
        }// end IAmStudent__Button_Click

        private void IAmAdmin_Button_Click(object sender, EventArgs e) {
            Admin_SignIn tcherSignForm = new Admin_SignIn();
            tcherSignForm.Show();

            // if this (the starting form) is closed with the Close() method the program will stop running.
            this.Hide();
        }// end 

    }// end class
}// end namespace
