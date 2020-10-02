using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    //Model to represent Doctor Entity
    public class DoctorEntity
    {
        public int dId { get; set; }
        public string doctorType { get; set; }
        public PersonEntity personEntity { get; set; }

        public DoctorEntity()
        {
            personEntity = new PersonEntity();
        }
        
    }
}
