using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class PatientModule
    {
        //Class to handle all operations on Patient table
        public static void CRUD_Read(Db db)
        {
            //Take user input - to display all records or selective records
            //Overload functions used .
            //Seperate Modules for each tables.
            Console.WriteLine(ConsoleConstants.ChoiceDisplayOptions);
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                var x= DAL.showData(db.patient);
            }
            else if (choice == 2)
            {
                Console.WriteLine(ConsoleConstants.patientid);
                int id = Convert.ToInt32(Console.ReadLine());
                var x =DAL.showData(db.patient, id);
            }
        }

        public static Db CRUD_Write(Db db)
        {
            try
            {
                PatientEntity e = new PatientEntity();
                PersonEntity pe = new PersonEntity();
                Console.WriteLine(ConsoleConstants.patientid);
                e.pId = Convert.ToInt32(Console.ReadLine());
                if (db.patient.Count > 0)
                {
                    //Validation- Check where any record with this id is already present or not. If present, ask different id
                    e.pId = HelperModule.validateId(e.pId, db.patient);
                }
                Console.WriteLine(ConsoleConstants.patientname);
                pe.name = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.gender);
                pe.gender = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.address);
                pe.address = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.email);
                pe.email = Console.ReadLine();
                Console.WriteLine(ConsoleConstants.doctorid);
                e.doctorId = Convert.ToInt32(Console.ReadLine());
                e.personEntity = pe;
                db.patient = DAL.insertData(db.patient, e);
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
                if (db.patient.Count > 0)
                {
                    Console.WriteLine(ConsoleConstants.updateDoctorType);
                    int id = Convert.ToInt32(Console.ReadLine());
                    db.patient = DAL.updateData(db.patient, id);
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
                    db.patient = DAL.deleteData(db.patient);
                }
                else if (choice == 2)
                {
                    Console.WriteLine(ConsoleConstants.patientid);
                    int id = Convert.ToInt32(Console.ReadLine());
                    db.patient = DAL.deleteData(db.patient, id);
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
