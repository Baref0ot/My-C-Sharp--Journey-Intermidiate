using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem {
    public class Schedule {
        /***********************************************
         * Name:          Matthew Wright
         * Instructor:    Ron Enz
         * Course:        C# Programming 2
         * Lab #:         Lab 7
         ***********************************************/

        public int count;
        public Section[] secArray = new Section[10];

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
         * insertSectionDB();
         * This method is the insert method that will create
         * a new row of data and place it into the database.
         **/
        public bool insertsSectionDB(int studentID, int sectionCRN) {
            DBSetup();
            cmd = "INSERT into StudentSchedule values(" + studentID + ", " + sectionCRN + ")";

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
        }// end insertsSectionDB()


        /** Adds a section to the schedule **/
        public bool addSection(Section sec) {
            secArray[count] = sec;
            count++;
            return true;
        }// end addSection

        public void display() {
            for (int i = 0; i < count; i++) {
                Section sec = secArray[i];
                sec.display();
            }// end foreach
        }// end display
    }// end class
}
