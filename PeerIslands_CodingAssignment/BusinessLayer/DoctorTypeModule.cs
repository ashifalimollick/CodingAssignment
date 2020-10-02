using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class DoctorTypeModule
    {
        //Class to handle all operations on Doctor Type table

        public static void CRUD_Read(Db db)
        {
            //Take user input - to display all records or selective records
            //Overload functions used .
            //Seperate Modules for each tables.
            Console.WriteLine(ConsoleConstants.ChoiceDisplayOptions);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                var x=DAL.showData(db.doctortype);
            }
            else if (choice == 2)
            {
                Console.WriteLine(ConsoleConstants.doctortype);
                string speciality = Console.ReadLine();
                var x=DAL.showData(db.doctortype, speciality);
            }
        }

        public static Db CRUD_Write(Db db)
        {
            try
            {
                DoctorTypeEntity e = new DoctorTypeEntity();
                Console.WriteLine(ConsoleConstants.doctortype);
                e.doctorType = Console.ReadLine();
                if (db.doctortype.Count > 0)
                {
                    //Validation - Check whether the id is already present or not. If present ask for a different id
                    e.doctorType = HelperModule.validateId(e.doctorType, db.doctortype);
                }
                Console.WriteLine(ConsoleConstants.doctortypedescription);
                e.description = Console.ReadLine();
                db.doctortype = DAL.insertData(db.doctortype, e);
                return db;
            }
            catch
            {
                throw;
            }
        }

        public static Db CRUD_Update(Db db)
        {
            try
            {
                if (db.doctortype.Count > 0)
                {
                    Console.WriteLine(ConsoleConstants.updateDoctorType);
                    string speciality = Console.ReadLine();
                    db.doctortype = DAL.updateData(db.doctortype, speciality);
                }
                else
                {
                    Console.WriteLine(ConsoleConstants.ZeroRecord);
                }
                return db;
            }
            catch
            {
                throw;
            }
        }

        public static Db CRUD_Delete(Db db)
        {
            try
            {
                //User input - to delete all data or delete selective data
                Console.WriteLine(ConsoleConstants.ChoiceDeleteOptions);
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    db.doctortype = DAL.deleteData(db.doctortype);
                }
                else if (choice == 2)
                {
                    Console.WriteLine(ConsoleConstants.doctortype);
                    string speciality = Console.ReadLine();
                    db.doctortype = DAL.deleteData(db.doctortype, speciality);
                }
                return db;
            }
            catch
            {
                throw;
            }
        }

    }
}
