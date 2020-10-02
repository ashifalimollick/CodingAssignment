using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    //Model to represent Patient Entity
    public class PatientEntity
    {
        public int pId { get; set; }
        public int doctorId { get; set; }
        public PersonEntity personEntity { get; set; }

        public PatientEntity()
        {
            personEntity = new PersonEntity();
        }

    }
}
