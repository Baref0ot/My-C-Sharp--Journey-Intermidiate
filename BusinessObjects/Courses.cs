using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem {
    public class Courses {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/

        /**
         * Declare Properties
         **/
        private string courseId = "";
        private string courseName = "";
        private string courseDescription = "";
        private int    creditHours = 0;

        /**
         * Create Setter and Getter Methods
         **/
        public void setCourseId(string cid) {
            courseId = cid;
        }// end setCourseId
        public string getCourseId() {
            return courseId;
        }// end getCourseId
        public void setCourseName(string cn) {
            courseName = cn;
        }// end setCourseName
        public string getCourseName() {
            return courseName;
        }// end getCourseName
        public void setCourseDescription(string cd) {
            courseDescription = cd;
        }// end setCourseDescription
        public string getCourseDescription() {
            return courseDescription;
        }// end getCourseDescription
        public void setCreditHours(int ch) {
            creditHours = ch;
        }// end setCreditHours
        public int getCreditHours() {
            return creditHours;
        }// end getCreditHours


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
            OleDbSelectCommand2  = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2  = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2  = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2  = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2     = new System.Data.OleDb.OleDbConnection();

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
         * selectDB(string cid);
         * This method is the select method that will pull data 
         * from the database by the Course ID attribute and 
         * display it into the application.
         **/
        public bool selectDB(string cid) {
            setCourseId(cid);
            DBSetup();
            cmd = "Select * from Courses where CourseID = " + "'"+ getCourseId()+"'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                if (dr.Read()) {
                    setCourseId(cid);
                    setCourseName(dr.GetValue(1) + "");
                    setCourseDescription(dr.GetValue(2) + "");
                    setCreditHours(Int32.Parse(dr.GetValue(3) + ""));
                    return true;
                }// end if
                else {
                    Console.WriteLine("The course does not exist.");
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
         * insertDB();
         * This method is the insert method that will create
         * a new row of data and place it into the database.
         **/
        public bool insertDB() {
            DBSetup();
            cmd = "INSERT into Courses values("+ "'"+getCourseId()+"'" +", "+ "'"+getCourseName()+"'" +", "+ "'"+getCourseDescription()+"'" +", "+ getCreditHours()+ ")";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n==1) {
                    Console.WriteLine("Data Inserted");
                    return true;
                }// end if
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
            cmd = "Update Courses set CourseName = '"+getCourseName()+"'," +"Description = '"+getCourseDescription()+"'," +"CreditHours = "+getCreditHours()+" where CourseID = '"+getCourseId()+"'";
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
            cmd = "Delete from Courses where CourseID = " + "'"+getCourseId()+"'";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n==1) {
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
        public Courses() {
            setCourseId("");
            setCourseName("");
            setCourseDescription("");
            setCreditHours(0);
        }// end empty Course Construct
        public Courses(string cid, string cName, string cDesc, int ch) {
            setCourseId(cid);
            setCourseName(cName);
            setCourseDescription(cDesc);
            setCreditHours(ch);
        }// end param Course Construct

        //display for testing
        public void display() {
            Console.WriteLine("");
            Console.WriteLine("Course Class: ");
            Console.WriteLine("Course Id: " + getCourseId());
            Console.WriteLine("Course Name: " + getCourseName());
            Console.WriteLine("Course Description: " + getCourseDescription());
            Console.WriteLine("Credit Hours: " + getCreditHours());
            Console.WriteLine("");
        }// end display
    }// end class
}

