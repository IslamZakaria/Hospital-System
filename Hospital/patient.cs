using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class patient
    {
        public string name;
        public string address;
        public string phone;
        public string age;
        public string diagnosis;
        public patient()
        {

        }
        public patient(string n, string add, string phone, string age,string d)
        {
            name = n;
            address = add;
            this.phone = phone;
            this.age = age;
            diagnosis = d;

        }

    }
}
