using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class DoctorModule
    {
        //Class to handle all operations on Doctor table

        public static void CRUD_Read(Db db)
        {
            //Take user input - to display all records or selective records
            //Overload functions used .
            //Seperate Modules for each tables.
            Console.WriteLine(ConsoleConstants.ChoiceDisplayOptions);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                var x = DAL.showData(db.doctor);
            }
            else if (choice == 2)
            {
                Console.WriteLine(ConsoleConstants.doctorid);
                int id = Convert.ToInt32(Console.ReadLine());
                var x = DAL.showData(db.doctor, id);
            }
        }

        public static Db CRUD_Write(Db db)
        {
            try
            {
                DoctorEntity e = new DoctorEntity();
                PersonEntity pe = new PersonEntity();
                Console.WriteLine(ConsoleConstants.doctorid);
                e.dId = Convert.ToInt32(Console.ReadLine());
                if (db.doctor.Count > 0)
                {
                    //Validation- Check where any record with this id is already present or not. If present, ask different id
                    e.dId = HelperModule.validateId(e.dId, db.doctor);
                }
                Console.WriteLine(ConsoleConstants.doctorname);
                pe.name = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.gender);
                pe.gender = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.address);
                pe.address = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.email);
                pe.email = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.doctortype);
                e.doctorType = Console.ReadLine();
                e.personEntity = pe;
                db.doctor = DAL.insertData(db.doctor, e);
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
                if (db.doctor.Count > 0)
                {
                    Console.WriteLine(ConsoleConstants.updateDoctor);
                    int id = Convert.ToInt32(Console.ReadLine());
                    db.doctor = DAL.updateData(db.doctor, id);
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
                    db.doctor = DAL.deleteData(db.doctor);
                }
                else if (choice == 2)
                {
                    Console.WriteLine(ConsoleConstants.doctorid);
                    int id = Convert.ToInt32(Console.ReadLine());
                    db.doctor = DAL.deleteData(db.doctor, id);
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
