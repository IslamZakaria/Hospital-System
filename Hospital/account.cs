using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class account
    {
        public string username;
        public string e_mail;
        public string password;
        public string type;
        
        public account(string mail, string pass, string username, string type)
        {
            this.username = username;
            e_mail = mail;
            password = pass;
            this.type = type;
        }
        public account()
        {

        }
    }
}
