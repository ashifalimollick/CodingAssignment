using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class DAL
    {

        //Overloaded function to display all doctor records
        public static List<DoctorEntity> showData(List<DoctorEntity> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    foreach (DoctorEntity data in db)
                    {
                        Console.WriteLine(data.dId.ToString() + "\t" + data.doctorType + "\t" + data.personEntity.name + "\t" + data.personEntity.email + "\t" + data.personEntity.address + "\t" + data.personEntity.gender + "\n");
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
            return db;
        }

        //Overloaded function to display selective doctor records based on unique id
        public static DoctorEntity showData(List<DoctorEntity> db, int id)
        {
            try
            {
                DoctorEntity doc = new DoctorEntity();
                if (db.Count > 0)
                {
                    int count = 0;
                    foreach (DoctorEntity data in db)
                    {
                        if (data.dId == id)
                        {
                            doc = data;
                            Console.WriteLine(data.dId.ToString() + "\t" + data.doctorType + "\t" + data.personEntity.name + "\t" + data.personEntity.email + "\t" + data.personEntity.address + "\t" + data.personEntity.gender + "\n");
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(ConsoleConstants.NoRecord);
                    }
                }
                else
                {
                    Console.WriteLine(ConsoleConstants.ZeroRecord);
                }
                return doc;
            }
            catch
            {
                throw;
            }
        }

        //Overloaded function to display all records
        public static List<DoctorTypeEntity> showData(List<DoctorTypeEntity> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    foreach (DoctorTypeEntity data in db)
                    {
                        Console.WriteLine(data.doctorType + "\t" + data.description + "\n");
                    }
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

        //Overloaded function to display selective records based on unique id
        public static DoctorTypeEntity showData(List<DoctorTypeEntity> db, string id)
        {
            try
            {
                DoctorTypeEntity doctype = new DoctorTypeEntity();
                if (db.Count > 0)
                {
                    int count = 0;
                    foreach (DoctorTypeEntity data in db)
                    {
                        if (data.doctorType == id)
                        {
                            doctype = data;
                            Console.WriteLine(data.doctorType + "\t" + data.description + "\n");
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(ConsoleConstants.NoRecord);
                    }
                }
                else
                {
                    Console.WriteLine(ConsoleConstants.ZeroRecord);
                }
                return doctype;
            }
            catch
            {
                throw;
            }

        }

        //Overloaded function to display all records
        public static List<PatientEntity> showData(List<PatientEntity> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    foreach (PatientEntity data in db)
                    {
                        Console.WriteLine(data.pId.ToString() + "\t" + data.doctorId.ToString() + "\t" + data.personEntity.name + "\t" + data.personEntity.email + "\t" + data.personEntity.address + "\t" + data.personEntity.gender + "\n");
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
            return db;
        }

        //Overloaded function to display selective records based on unique id
        public static PatientEntity showData(List<PatientEntity> db, int id)
        {
            try
            {
                PatientEntity patiententity = new PatientEntity();
                if (db.Count > 0)
                {
                    int count = 0;
                    foreach (PatientEntity data in db)
                    {
                        if (data.pId == id)
                        {
                            patiententity = data;
                            Console.WriteLine(data.pId.ToString() + "\t" + data.doctorId.ToString() + "\t" + data.personEntity.name + "\t" + data.personEntity.email + "\t" + data.personEntity.address + "\t" + data.personEntity.gender + "\n");
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(ConsoleConstants.NoRecord);
                    }
                }
                else
                {
                    Console.WriteLine(ConsoleConstants.ZeroRecord);
                }
                return patiententity;
            }
            catch
            {
                throw;
            }
        }

        //Function to insert data in Doctor table
        public static List<DoctorEntity> insertData(List<DoctorEntity> db,DoctorEntity e)
        {
            try
            {
                db.Add(e);
                return db;
            }
            catch
            {
                throw;
            }
        }

        //Function to insert data 
        public static List<DoctorTypeEntity> insertData(List<DoctorTypeEntity> db,DoctorTypeEntity e)
        {
            try
            {
                db.Add(e);
                return db;
            }
            catch
            {
                throw;
            }
        }

        //Function to insert data
        public static List<PatientEntity> insertData(List<PatientEntity> db,PatientEntity e)
        {
            try
            {
               
                db.Add(e);
                return db;
            }
            catch
            {
                throw;
            }
        }

        //Function to update Data in Doctor table
        public static List<DoctorEntity> updateData(List<DoctorEntity> db,int id)
        {
            try
            {
                int count = 0;
                foreach (DoctorEntity de in db)
                {
                    //Search for specific data row
                    if (de.dId == id)
                    {
                        //Validate user input for each column/elements.
                        //If user does not provide input for a column, existing/old data will be preserved for that column
                        //If user provided any input for that column, new data will be over written in the column
                        Console.WriteLine(ConsoleConstants.genericUpdate);
                        Console.WriteLine(ConsoleConstants.doctorname);
                        de.personEntity.name = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.name);
                        Console.WriteLine(ConsoleConstants.gender);
                        de.personEntity.gender = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.gender);
                        Console.WriteLine(ConsoleConstants.address);
                        de.personEntity.address = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.address);
                        Console.WriteLine(ConsoleConstants.email);
                        de.personEntity.email = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.email);
                        Console.WriteLine(ConsoleConstants.doctortype);
                        de.doctorType = HelperModule.validateUpdate(Console.ReadLine(), de.doctorType);

                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(ConsoleConstants.NoRecord);
                }
                return db;
            }
            catch
            {
                throw;
            }
        }

        //Function to update data
        public static List<DoctorTypeEntity> updateData(List<DoctorTypeEntity> db,string speciality)
        {
            try
            {
                int count = 0;
                foreach (DoctorTypeEntity de in db)
                {
                    if (de.doctorType == speciality)
                    {
                        Console.WriteLine(ConsoleConstants.doctortypedescription);
                        de.description = Console.ReadLine();
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(ConsoleConstants.NoRecord);
                }
                return db;
            }
            catch
            {
                throw;
            }
        }

        //Function to updata data rows
        public static List<PatientEntity> updateData(List<PatientEntity> db,int id)
        {
            try
            {
                int count = 0;
                foreach (PatientEntity de in db)
                {
                    //Search for specific data row
                    if (de.pId == id)
                    {
                        //Validate user input for each column/elements.
                        //If user does not provide input for a column, existing/old data will be preserved for that column
                        //If user provided any input for that column, new data will be over written in the column
                        Console.WriteLine(ConsoleConstants.genericUpdate);
                        Console.WriteLine(ConsoleConstants.patientname);
                        de.personEntity.name = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.name);
                        Console.WriteLine(ConsoleConstants.gender);
                        de.personEntity.gender = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.gender);
                        Console.WriteLine(ConsoleConstants.address);
                        de.personEntity.address = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.address);
                        Console.WriteLine(ConsoleConstants.email);
                        de.personEntity.email = HelperModule.validateUpdate(Console.ReadLine(), de.personEntity.email);
                        Console.WriteLine(ConsoleConstants.doctorid);
                        de.doctorId = HelperModule.validateUpdate(Console.ReadLine(), de.doctorId);

                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(ConsoleConstants.NoRecord);
                }
                return db;
            }
            catch
            {
                throw;
            }
        }

        //Overload function to delete specific data row in Doctor table
        public static List<DoctorEntity> deleteData(List<DoctorEntity> db, int id)
        {
            try
            {
                if (db.Count > 0)
                {
                    int count = 0;
                    foreach (DoctorEntity e in db)
                    {
                        if (e.dId == id)
                        {
                            db.Remove(e);
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(ConsoleConstants.NoRecord);
                    }
                    else
                    {
                        Console.WriteLine(ConsoleConstants.RecordDelete);
                    }
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

        //Overload function to delete all data in Doctor table
        public static List<DoctorEntity> deleteData(List<DoctorEntity> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    db.Clear();
                    Console.WriteLine(ConsoleConstants.RecordClear);
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

        //Overload function to delete specific record
        public static List<DoctorTypeEntity> deleteData(List<DoctorTypeEntity> db, string type)
        {
            try
            {
                if (db.Count > 0)
                {
                    int count = 0;
                    foreach (DoctorTypeEntity e in db)
                    {
                        if (e.doctorType == type)
                        {
                            db.Remove(e);
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(ConsoleConstants.NoRecord);
                    }
                    else
                    {
                        Console.WriteLine(ConsoleConstants.RecordDelete);
                    }
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

        //Overload function to delete all records
        public static List<DoctorTypeEntity> deleteData(List<DoctorTypeEntity> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    db.Clear();
                    Console.WriteLine(ConsoleConstants.RecordClear);
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

        //Overload function to delete specific data row
        public static List<PatientEntity> deleteData(List<PatientEntity> db, int id)
        {
            try
            {
                if (db.Count > 0)
                {
                    int count = 0;
                    foreach (PatientEntity e in db)
                    {
                        if (e.pId == id)
                        {
                            db.Remove(e);
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(ConsoleConstants.NoRecord);
                    }
                    else
                    {
                        Console.WriteLine(ConsoleConstants.RecordDelete);
                    }
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

        //Overload function to delete specific all data
        public static List<PatientEntity> deleteData(List<PatientEntity> db)
        {
            try
            {
                if (db.Count > 0)
                {
                    db.Clear();
                    Console.WriteLine(ConsoleConstants.RecordClear);
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
    }
}
