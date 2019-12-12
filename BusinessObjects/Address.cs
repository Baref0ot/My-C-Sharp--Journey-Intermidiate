using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem {
    public class Address {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/

        //properties
        private string streetName = "";
        private string city = "";
        private string state = "";
        private int zip = 0;

        //methods
        public void setStreetName(string stname) {
            streetName = stname;
        }// end setStreetName
        public string getStreetName() {
            return streetName;
        }// end getStreetName
        public void setCity(string cty) {
            city = cty;
        }// end setCity
        public string getCity() {
            return city;
        }// end getCity
        public void setState(string ste) {
            state = ste;
        }// end setState
        public string getState() {
            return state;
        }// end getState
        public void setZip(int zp) {
            zip = zp;
        }// end set
        public int getZip() {
            return zip;
        }// end getZip

        //constructor
        public Address() {
            setStreetName("");
            setCity("");
            setState("");
            setZip(0);
        }// end empty Construct
        public Address(string stName, string cty, string ste, int zp) {
            setStreetName(stName);
            setCity(cty);
            setState(ste);
            setZip(zp);
        }// end param Construct

        //display for testing
        public void display() {
            Console.WriteLine("");
            Console.WriteLine("Address Class:");
            Console.WriteLine("Street: " + getStreetName());
            Console.WriteLine("City: " + getCity());
            Console.WriteLine("State: " + getState());
            Console.WriteLine("Zip: " + getZip());
            Console.WriteLine("");
        }// end display
    }// end class
}
