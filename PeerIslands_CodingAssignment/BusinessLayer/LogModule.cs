using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class LogModule
    {
        //Class to handle all operations on Log table

        //Function to display error logs
        public static void showErrorLog(List<ErrorLog> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    foreach (ErrorLog data in db)
                    {
                        Console.WriteLine(data.logTime.ToString() + "\t" + data.error + "\t" + data.errorModule);
                    }
                }
                else
                {
                    Console.WriteLine(ConsoleConstants.ZeroRecord);
                }
            }
            catch
            {
                throw;
            }
        }


        //Function to insert data in error log
        public static List<ErrorLog> insertErrorLog(List<ErrorLog> db,string error, string errorModule)
        {
            try
            {
                ErrorLog e = new ErrorLog();
                e.logTime = DateTime.Now;
                e.error = error;
                e.errorModule = errorModule;
                db.Add(e);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while inserting error log"+ex.ToString());
            }
            return db;
        }
    }
}
