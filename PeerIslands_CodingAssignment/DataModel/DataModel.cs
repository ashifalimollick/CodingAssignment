using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    public class Db
    {
        //Model : Database structure with each property representing a unique table structure
        public List<DoctorEntity> doctor { get; set; }
        public List<PatientEntity> patient { get; set; }
        public List<DoctorTypeEntity> doctortype { get; set; }
        public List<ErrorLog> errorlog { get; set; }

        public Db()
        {
            doctor = new List<DoctorEntity>();
            patient = new List<PatientEntity>();
            doctortype = new List<DoctorTypeEntity>();
            errorlog = new List<ErrorLog>();
        }
    }
}
