using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class room
    {
        public string patient_name;
        public bool available;
        public string room_type;
        public room()
        {
            available = true;
            patient_name = "UNKOWN";
            room_type = "UNKOWN"; 
        }
        public room(string p, string type)
        {
            patient_name = p;
            room_type = type;
        }
    }
}
