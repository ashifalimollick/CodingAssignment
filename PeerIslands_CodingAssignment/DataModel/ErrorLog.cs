using System;
using System.Collections.Generic;
using System.Text;

namespace PeerIslands_CodingAssignment
{
    //Model to represent Error log 
    public class ErrorLog
    {
        public DateTime logTime { get; set; }
        public string error { get; set; }
        public string errorModule { get; set; }
    }
}
