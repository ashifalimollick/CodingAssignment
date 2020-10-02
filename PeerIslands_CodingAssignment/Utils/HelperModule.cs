using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class HelperModule
    {
        public static string validateUpdate(string newvalue,string orignalvalue)
        {
            if (newvalue == string.Empty)
            {
                return orignalvalue;
            }
            else
            {
                return newvalue;
            }
        }

        public static int validateUpdate(string newvalue, int orignalvalue)
        {
            if (newvalue == string.Empty)
            {
                return orignalvalue;
            }
            else
            {
                return Convert.ToInt32(newvalue);
            }
        }
        public static int validateId(int id, List<DoctorEntity> e)
        {
            Boolean flag = true;
            while (flag)
            {
                flag = false;
                foreach (DoctorEntity de in e)
                {
                    if (id == de.dId)
                    {
                        Console.WriteLine("Record with this id already exists, please enter a different id");
                        id = Convert.ToInt32(Console.ReadLine());
                        flag = true;
                        break;
                    }
                }
            }
            return id;
        }

        public static int validateId(int id, List<PatientEntity> e)
        {
            Boolean flag = true;
            while (flag)
            {
                flag = false;
                foreach (PatientEntity pe in e)
                {
                    if (id == pe.pId)
                    {
                        Console.WriteLine("Record with this id already exists, please enter a different id");
                        id = Convert.ToInt32(Console.ReadLine());
                        flag = true;
                        break;
                    }
                }
            }
            return id;
        }

        public static string validateId(string dtype, List<DoctorTypeEntity> e)
        {
            Boolean flag = true;
            while (flag)
            {
                flag = false;
                foreach (DoctorTypeEntity de in e)
                {
                    if (dtype == de.doctorType)
                    {
                        Console.WriteLine("Record with this id already exists, please enter a different id");
                        dtype = Console.ReadLine();
                        flag = true;
                        break;
                    }
                }
            }
            return dtype;
        }
    }
}
