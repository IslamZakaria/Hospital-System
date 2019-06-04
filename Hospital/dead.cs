using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class dead
    {
        public string name;
        public string address;
        public string satus;
        public string age;

        public dead()
        {

        }
        public dead(string n,string add,string satus,string age)
        {
            name = n;
            address = add;
            this.satus = satus;
            this.age = age; 
        }
    }
}
