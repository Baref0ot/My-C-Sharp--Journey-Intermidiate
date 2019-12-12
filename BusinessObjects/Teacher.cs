using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem {
    public class Teacher: Person {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/

        private string officeNum = "";

        //methods
        public void setOfficeNum(string offNum) {
            officeNum = offNum;
        }// end setOfficeNum
        public string getOfficeNum() {
            return officeNum;
        }// end getOfficeNum


        /**
         * Create database Object variables that will contain the behaviors for DataElements.
         **/
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;
        /**
         * DBSetup();
         * Database setup function. This method setups all the funtionallity 
         * required to access a desired database by instanciating the required 
         * DB Objects including OleDbDataAdapter, which contains 4 other objects(OlsDbSelectCommand, 
		 * oleDbInsertCommand, oleDbUpdateCommand, oleDbDeleteCommand.) And each
		 * Command object contains a Connection object and an SQL string object.
         * 
         * OleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RegistrationMDB.mdb;";
        **/
        public void DBSetup() {
            // instanciated System database objects
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;" +
                                                "Jet OLEDB:Registry Path=;" +
                                                "Jet OLEDB:Database Locking Mode=1;" +
                                                "Data Source=C:\\Users\\Mattw\\Desktop\\C# II\\Week # 4\\StudentRegistrationSystem\\RegistrationMDB.mdb;" +
                                                "Jet OLEDB:Engine Type=5;" +
                                                "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                                "Jet OLEDB:System database=;" +
                                                "Jet OLEDB:SFP=False;" +
                                                "persist security info=False;" +
                                                "Extended Properties=;" +
                                                "Mode=S" + "hare Deny None;" +
                                                "Jet OLEDB:Encrypt Database=False;" +
                                                "Jet OLEDB:Create System Database=False;" +
                                                "Jet OLEDB:Don't Copy Locale on Compact=False;" +
                                                "Jet OLEDB:Compact Without Replica Repair=False;" +
                                                "User ID=Admin;" +
                                                "Jet OLEDB:Global Bulk Transactions=1";
        }// end DBSetup()


        /**
         * selectDB(int tid);
         * This method is the select method that will pull data 
         * from the database by the Course ID attribute and 
         * display it into the application.
         **/
        public bool selectDB(int tid) {
            setID(tid);
            DBSetup();
            cmd = "Select * from Instructors where ID = " + getID();
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                if (dr.Read()) {
                    setID(tid);
                    setFirstName(dr.GetValue(1) + "");
                    setLastName(dr.GetValue(2) + "");
                    address.setStreetName(dr.GetValue(3) + "");
                    address.setCity(dr.GetValue(4) + "");
                    address.setState(dr.GetValue(5) + "");
                    address.setZip(Int32.Parse(dr.GetValue(6) + ""));
                    setOfficeNum(dr.GetValue(7) + "");
                    setEmail(dr.GetValue(8) + "");
                    OleDbConnection2.Close();
                    getScedule();
                    return true;
                }// end if
                else {
                    Console.WriteLine("The instructor does not exist.");
                    return false;
                }// end else
            }// end try
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }// end catch
            finally {
                OleDbConnection2.Close();
            }// end finally
        }// end selectDB()


        /**
         * getSchedule(int tid);
         * This method is the get Schedule method that will pull data 
         * from the database by the  attribute and 
         * display it into the application. Not finished.
         **/
        public void getScedule() {
            cmd = "Select CRN from Sections where Instructor = " + getID();
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                Section sec;

                int CRN;
                while (dr.Read()) {
                    CRN = Int32.Parse(dr.GetValue(0) + "");
                    sec = new Section();
                    sec.selectDB(CRN);
                    schedule.addSection(sec);
                }// end while

            }// end try
            catch (Exception ex) {
                Console.WriteLine(ex);
            }// end catch
            finally {
                OleDbConnection2.Close();
            }// end finally
        }// end getSchedule


        /**
         * insertDB();
         * This method is the insert method that will create
         * a new row of data and place it into the database.
         **/
        public bool insertDB() {
            DBSetup();
            cmd = "INSERT into Instructors values("+ getID() +", "+ "'"+getFirstName()+"'" +", "+ "'"+getLastName()+"'" +", "+ "'"+address.getStreetName()+"'" +", "+ "'"+address.getCity()+"'" +", "+ "'"+address.getState()+"'" +", "+ address.getZip() +", "+ "'"+getOfficeNum()+"'" +", "+ "'"+getEmail()+"'" +")";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) {
                    Console.WriteLine("Data Inserted");
                    return true;
                }
                else {
                    Console.WriteLine("ERROR: Inserting Data");
                    return false;
                }// else
            }// end try
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }// end catch
            finally {
                OleDbConnection2.Close();
            }// end finally
        }// end insertDB()


        /**
         * updateDB();
         * This method is the update method that will change
         * a currently existing row within the database if it exist.
         **/
        public bool updateDB() {
            cmd = "Update Instructors set FirstName = '" + getFirstName() + "', " + "LastName = '" + getLastName() + "', " + "Street = '" + address.getStreetName() + "', " + "City = '" + address.getCity() + "', " + "State = '" + address.getState() + "', " + "Zip = " + address.getZip() + ", " + "Office = '" + getOfficeNum() + "', " + "Email = '" + getEmail() + "'" + " where ID = " + getID() + "";
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1) {
                    Console.WriteLine("Data Updated");
                    return true;
                }// end if
                else {
                    Console.WriteLine("ERROR: Updating Data");
                    return false;
                }// end else
            }// end try
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }// end catch
            finally {
                OleDbConnection2.Close();
            }// end finally
        }// end updateDB()


        /**
         * deleteDB();
         * This method is the delete method that will erase
         * a currently existing row within the database if it exist.
         **/
        public bool deleteDB() {
            cmd = "Delete from Instructors where ID = " + getID() + "";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1) {
                    Console.WriteLine("Data Deleted");
                    return true;
                }// end if
                else {
                    Console.WriteLine("ERROR: Deleting Data");
                    return false;
                }// end else
            }// end try
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }// end catch
            finally {
                OleDbConnection2.Close();
            }// end finally
        }// end deleteDB()


        //constructor
        public Teacher() : base(){
            setOfficeNum("");
        }// end empty construct
        public Teacher(string offNum, int d, string fName, string lName, string eml, Address a1) : base(d, fName, lName, eml, a1) {
            setOfficeNum(offNum);
        }// end param construct

        //display for testing
        public void display() {
            Console.WriteLine("");
            Console.WriteLine("Teacher Class: ");
            Console.WriteLine("Office Number: " + getOfficeNum());
            base.display();
            Console.WriteLine("");
        }// end display
    }// end class
}
