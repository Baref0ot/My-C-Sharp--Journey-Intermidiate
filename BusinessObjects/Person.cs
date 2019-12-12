using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem {
    public class Person {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/

        // Properties
        private int ID = 0;
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        public Address address = new Address();
        public Schedule schedule = new Schedule();

        // Methods
        public void setID(int id) {
            ID = id;
        }// end setID 
        public int getID() {
            return ID;
        }// end getID
        public void setFirstName(string fName) {
            firstName = fName;
        }// end setFirstName
        public string getFirstName() {
            return firstName;
        }// end getFirstName
        public void setLastName(string lName) {
            lastName = lName;
        }// end setLastName
        public string getLastName() {
            return lastName;
        }// end getLastName
        public void setEmail(string eml) {
            email = eml;
        }// end setEmail
        public string getEmail() {
            return email;
        }// end getEmail

        public void setAddress(Address a1) {
            address = a1;
        }// end setAddress
        public Address getAddress() {
            return address;
        }// end getAddress

        public void setSchedule(Schedule sc1) {
            schedule = sc1;
        }// end setSchedule


        // Display for testing
        public void display() {
            Console.WriteLine("");
            Console.WriteLine("Person Class:");
            Console.WriteLine("ID: " + getID());
            Console.WriteLine("First Name: " + getFirstName());
            Console.WriteLine("Last Name: " + getLastName());
            Console.WriteLine("Email: " + getEmail());
            address.display();
            schedule.display();
            Console.WriteLine("");
        }// end display()

        // Consructor
        public Person() {
            setID(0);
            setFirstName("");
            setLastName("");
            setEmail("");
            address = new Address();
            schedule = new Schedule();
        }// end empty Construct
        public Person(int d, string fName, string lName, string eml, Address a1) {
            setID(d);
            setFirstName(fName);
            setLastName(lName);
            setEmail(eml);
            setAddress(a1);
        }// end param Construct

    }// end class
}
