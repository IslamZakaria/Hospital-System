using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class hospital_system
    {
        public system S;
        public hospital_system()
        {
            S = new system(); 
            S.load(); 
        }
        ~hospital_system()
        {
            S.save(); 
        }
    }
}
