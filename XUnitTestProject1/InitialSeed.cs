using System;
using System.Collections.Generic;
using System.Text;
using PeerIslands_CodingAssignment;

namespace XUnitTestProject1
{
    //Functions to generate dummy data
    public class InitialSeed
    {
        public static List<DoctorEntity> doctorSeed()
        {
            List<DoctorEntity> db = new List<DoctorEntity>();
            DoctorEntity de = new DoctorEntity();
            de.dId = 1;
            de.doctorType = "Cardiac";
            de.personEntity.name = "Ashif";
            de.personEntity.address = "Abc";
            de.personEntity.email = "ashifalimollick@gmail.com";
            de.personEntity.gender = "M";
            db.Add(de);
            return db;
        }
        public static List<DoctorEntity> doctorSeed1()
        {
            List<DoctorEntity> db = new List<DoctorEntity>();
            DoctorEntity de = new DoctorEntity();
            DoctorEntity de1 = new DoctorEntity();
            de.dId = 1;
            de.doctorType = "Cardiac";
            de.personEntity.name = "Ashif";
            de.personEntity.address = "Abc";
            de.personEntity.email = "ashifalimollick@gmail.com";
            de.personEntity.gender = "M";
            de1.dId = 2;
            de1.doctorType = "Dentist";
            de1.personEntity.name = "Amita";
            de1.personEntity.address = "Bch";
            de1.personEntity.email = "ashifalimollick@gmail.com";
            de1.personEntity.gender = "F";
            db.Add(de);
            db.Add(de1);
            return db;
        }
        public static DoctorEntity doctorSeed2()
        {
            DoctorEntity de1 = new DoctorEntity();
            de1.dId = 2;
            de1.doctorType = "Dentist";
            de1.personEntity.name = "Amita";
            de1.personEntity.address = "Bch";
            de1.personEntity.email = "ashifalimollick@gmail.com";
            de1.personEntity.gender = "F";
            return de1;
        }

        public static List<PatientEntity> patientSeed()
        {
            List<PatientEntity> db = new List<PatientEntity>();
            PatientEntity de = new PatientEntity();
            de.pId = 1;
            de.doctorId =21;
            de.personEntity.name = "Ashif";
            de.personEntity.address = "Abc";
            de.personEntity.email = "ashifalimollick@gmail.com";
            de.personEntity.gender = "M";
            db.Add(de);
            return db;
        }
        public static List<PatientEntity> patientSeed1()
        {
            List<PatientEntity> db = new List<PatientEntity>();
            PatientEntity de = new PatientEntity();
            PatientEntity de1 = new PatientEntity();
            de.pId = 1;
            de.doctorId = 21;
            de.personEntity.name = "Ashif";
            de.personEntity.address = "Abc";
            de.personEntity.email = "ashifalimollick@gmail.com";
            de.personEntity.gender = "M";
            de1.pId = 2;
            de1.doctorId = 31;
            de1.personEntity.name = "Amita";
            de1.personEntity.address = "Bch";
            de1.personEntity.email = "ashifalimollick@gmail.com";
            de1.personEntity.gender = "F";
            db.Add(de);
            db.Add(de1);
            return db;
        }
        public static PatientEntity patientSeed2()
        {
            PatientEntity de1 = new PatientEntity();
            de1.pId = 2;
            de1.doctorId = 31;
            de1.personEntity.name = "Amita";
            de1.personEntity.address = "Bch";
            de1.personEntity.email = "ashifalimollick@gmail.com";
            de1.personEntity.gender = "F";
            return de1;
        }
    }
}
