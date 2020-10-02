using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class Choice
    {
        //Function to display data
        public static void displayData(Db db)
        {
            try
            {
                //Take Input from user - Which table to perform read operation
                Console.WriteLine(ConsoleConstants.ChoiceDisplay);
                int choice = Convert.ToInt32(Console.ReadLine());
                string role = string.Empty;
                switch (choice)
                {
                    case 1:
                        DoctorModule.CRUD_Read(db);
                        break;
                    case 2:
                        PatientModule.CRUD_Read(db);
                        break;
                    case 3:
                        DoctorTypeModule.CRUD_Read(db);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }catch(Exception ex)
            {
                db.errorlog= LogModule.insertErrorLog(db.errorlog, ex.ToString(),"Display Records") ;
            }
        }
        public static Db insertData(Db db)
        {
            //Functionm to insert data. 
            //User input - which table to insert data in.
            try { 
            Console.WriteLine(ConsoleConstants.ChoiceInsert);
            int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        db= DoctorModule.CRUD_Write(db);
                        break;
                    case 2:
                        db = PatientModule.CRUD_Write(db);
                        break;
                    case 3:
                        db = DoctorTypeModule.CRUD_Write(db);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                return db;
            }
            catch (Exception ex)
            {
                db.errorlog = LogModule.insertErrorLog(db.errorlog, ex.ToString(), "Insert Records");
            }
            return db;
        }
        public static Db updateData(Db db)
        {
            //Function to update data
            //User input- which table to update
            //Different Modules for each table
            try
            {
                Console.WriteLine(ConsoleConstants.ChoiceUpdate);
                int choice = Convert.ToInt32(Console.ReadLine());
                string role = string.Empty;
                switch (choice)
                {
                    case 1:
                        db = DoctorModule.CRUD_Update(db);
                        break;
                    case 2:
                        db = PatientModule.CRUD_Update(db);
                        break;
                    case 3:
                        db = DoctorTypeModule.CRUD_Update(db);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }catch(Exception ex)
            {
                db.errorlog= LogModule.insertErrorLog(db.errorlog, ex.ToString(),"Update Records") ;
            }

            return db;
        }
        public static Db deleteData(Db db)
        {
            //Function to delete data
            try
            {
                //User input - which table to perform delete operation on
                Console.WriteLine(ConsoleConstants.ChoiceDelete);
                int choice = Convert.ToInt32(Console.ReadLine());
                string role = string.Empty;
                switch (choice)
                {
                    case 1:
                        db = DoctorModule.CRUD_Delete(db);
                        break;
                    case 2:
                        db = PatientModule.CRUD_Delete(db);
                        break;
                    case 3:
                        db = DoctorTypeModule.CRUD_Delete(db);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }catch(Exception ex)
            {
                db.errorlog= LogModule.insertErrorLog(db.errorlog, ex.ToString(),"Delete Records") ;
            }
            return db;
        }
        public static Db displayLogs(Db db)
        {
            //Function to display error logs
            try
            {
                LogModule.showErrorLog(db.errorlog);
            }catch(Exception ex)
            {
                db.errorlog= LogModule.insertErrorLog(db.errorlog, ex.ToString(),"Display Logs") ;
            }
            return db;
        }
    }
}
