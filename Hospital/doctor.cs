using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class doctor
    {
        public string name;
        public string address;
        public string phone;
        public int age;
        public int salary;
        public string speciality;
        public bool available;

        public doctor()
        {

        }
        public doctor(string n, string ad, string ph, int age, string specialist)
        {
            name = n;
            address = ad;
            phone = ph;
            speciality = specialist;
            this.age = age;
            available = true;
        }
    }
}
