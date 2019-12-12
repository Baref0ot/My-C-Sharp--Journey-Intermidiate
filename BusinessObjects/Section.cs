using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem {
    public class Section {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/

        // Properties 
        private int crn = 0;
        private string courseId = "";
        private string timeDays = "";
        private string roomNum = "";
        private int teacherId = 0;

        // Methods
        public void setCrn(int cn) {
            crn = cn;
        }// end setCrn
        public int getCrn() {
            return crn;
        }// end getCrn
        public void setCourseId(string cid) {
            courseId = cid;
        }// end setCourseId
        public string getCourseId() {
            return courseId;
        }// end getCourseId
        public void setTimeDays(string td) {
            timeDays = td;
        }// end setTimeDays
        public string getTimeDays() {
            return timeDays;
        }// end getTimeDays
        public void setRoomNum(string rm) {
            roomNum = rm;
        }// end setRoomNum
        public string getRoomNum() {
            return roomNum;
        }// end getRoomNum
        public void setTeacherId(int tid) {
            teacherId = tid;
        }// end setTeacherId
        public int getTeacherId() {
            return teacherId;
        }// end getTeacherId


        /**
         * Database Objects that contain the behaviors for DataElements.
         **/
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;
        /**
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
         * This method is the select method that will pull data 
         * from the database by the Section's CRN attribute and 
         * display it into the application.
         **/
        public string[] selectAllDB() {
            // create a string array that all the section crns will be stored inside of.
            string[] allSections = null;
            DBSetup();
            cmd = "Select CRN from Sections";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                var sectionList = new List<string>();
                if (dr.Read()) {
                    // get all the section crns in the database while there are some.
                    while (dr.Read()) {
                        setCrn(Int32.Parse(dr.GetValue(0) + ""));
                        // add each crn to a list
                        sectionList.Add(getCrn().ToString());
                        // convert the list to a string.
                        allSections = sectionList.ToArray();
                    }// end while
                    return allSections;
                }// end if
                else {
                    Console.WriteLine("Something went wrong.");
                    return allSections;
                }// end else
            }// end try
            catch (Exception ex) {
                Console.WriteLine(ex);
                return allSections;
            }// end catch
            finally {
                OleDbConnection2.Close();
            }// end finally
        }// end selectAllDB()


        /**
         * This method is the select method that will pull data 
         * from the database by the Section's CRN attribute and 
         * display it into the application.
         **/
        public bool selectDB(int crn) {
            setCrn(crn);
            DBSetup();
            cmd = "Select * from Sections where CRN = " + getCrn();
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                if (dr.Read()) {
                    setCrn(crn);
                    setCourseId(dr.GetValue(1) + "");
                    setTimeDays(dr.GetValue(2) + "");
                    setRoomNum(dr.GetValue(3) + "");
                    setTeacherId(Int32.Parse(dr.GetValue(4) + ""));
                    return true;
                }// end if
                else {
                    Console.WriteLine("The section does not exist.");
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
            cmd = "INSERT into Sections values(" + getCrn() +", "+ "'"+getCourseId()+"'" +", "+ "'"+getTimeDays()+"'" +", "+ "'"+getRoomNum()+"'" +","+ getTeacherId()+ ")";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1) {
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
            cmd = "Update Sections set CourseID = '" + getCourseId() + "', " + "TimeDays = '" + getTimeDays() + "', " + "RoomNo = '"+getRoomNum()+"', " + "Instructor = "+getTeacherId()+ " where CRN = "+getCrn()+"";
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
            cmd = "Delete from Sections where CRN = " + getCrn() +"";
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


        // Constructor
        public Section() {
            setCrn(0);
            setCourseId("");
            setTimeDays("");
            setRoomNum("");
            setTeacherId(0);
        }// end empty Construct
        public Section(int cn, string cid, string td, string rm, int tid) {
            setCrn(cn);
            setCourseId(cid);
            setTimeDays(td);
            setRoomNum(rm);
            setTeacherId(tid);
        }// end param Construct

        //display for testing
        public void display() {
            Console.WriteLine("");
            Console.WriteLine("Section Class:");
            Console.WriteLine("Section CRN: " + getCrn());
            Console.WriteLine("Section Course Id: " + getCourseId());
            Console.WriteLine("Section Time and Day: " + getTimeDays());
            Console.WriteLine("Section Room Number: " + getRoomNum());
            Console.WriteLine("Section Instructor: " + getTeacherId());
            Console.WriteLine("");
        }// end display
    }// end class
}
