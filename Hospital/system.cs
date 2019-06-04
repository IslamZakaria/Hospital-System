using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Hospital
{
    public class system
    {
        private List<account> accounts;
        private List<doctor> doctors;
        private List<dead> death;
        private List<patient> patients;
        private List<room> ROOMS;
        private List<cure> pharmacy;
        public system()
        {
            accounts = new List<account>();
            doctors = new List<doctor>();
            ROOMS = new List<room>();
            death = new List<dead>();
            patients = new List<patient>();
            pharmacy = new List<cure>();
            load();
        }  
        public void load_doctor()
        {
            doctors.Clear();
            // restor list of doctors
            FileStream fdo = new FileStream("doctor.xml", FileMode.Open);
            XmlSerializer s = new XmlSerializer(doctors.GetType());
            doctors = (List<doctor>)s.Deserialize(fdo);
            fdo.Close();
        }
        public void load_patient()
        {
            patients.Clear();
            // restor list of patient
            FileStream fp = new FileStream("patient.xml", FileMode.Open);
            XmlSerializer ss = new XmlSerializer(patients.GetType());
            patients = (List<patient>)ss.Deserialize(fp);
            fp.Close();
        }
        public void load_death()
          {
          death.Clear();
          // restor list of dead
            FileStream fd = new FileStream("dead_people.xml", FileMode.Open);
            XmlSerializer sss = new XmlSerializer(death.GetType());
            death = (List<dead>)sss.Deserialize(fd);
            fd.Close();
          }
        public void load_rooms()
          {
          ROOMS.Clear();
          // restor list of room
            FileStream FR = new FileStream("room.xml", FileMode.Open);
            XmlSerializer sssss = new XmlSerializer(ROOMS.GetType());
            ROOMS = (List<room>)sssss.Deserialize(FR);
            FR.Close();
            
         }
        public void load_pharmacy()
          {
          pharmacy.Clear();
          // restor list of cures
            FileStream cur = new FileStream("cure.xml", FileMode.Open);
            XmlSerializer ssssss = new XmlSerializer(pharmacy.GetType());
            pharmacy = (List<cure>)ssssss.Deserialize(cur);
            cur.Close();
          }
        public void load_accounts()
          {
          accounts.Clear();
          // restor list of accounts
            FileStream acc = new FileStream("account.xml", FileMode.Open);
            XmlSerializer sssssss = new XmlSerializer(accounts.GetType());
            accounts = (List<account>)sssssss.Deserialize(acc);
            acc.Close();
          }

        public void load()
        {
            /*
             load_doctor();
             * load_patient();
             * load_death();
             * load_rooms();
             * load_pharmacy();
             * load_accounts();
             */
            accounts.Clear();
            doctors.Clear();
            ROOMS.Clear();
            death.Clear();
            patients.Clear();
            pharmacy.Clear(); 

            // restor list of doctors
            FileStream fdo = new FileStream("doctor.xml", FileMode.Open);
            XmlSerializer s = new XmlSerializer(doctors.GetType());
            doctors = (List<doctor>)s.Deserialize(fdo);
            fdo.Close();
            
            // restor list of patient
            FileStream fp = new FileStream("patient.xml", FileMode.Open);
            XmlSerializer ss = new XmlSerializer(patients.GetType());
            patients = (List<patient>)ss.Deserialize(fp);
            fp.Close();
            
            // restor list of dead
            FileStream fd = new FileStream("dead_people.xml", FileMode.Open);
            XmlSerializer sss = new XmlSerializer(death.GetType());
            death = (List<dead>)sss.Deserialize(fd);
            fd.Close();

            
            
            // restor list of room
            FileStream FR = new FileStream("room.xml", FileMode.Open);
            XmlSerializer sssss = new XmlSerializer(ROOMS.GetType());
            ROOMS = (List<room>)sssss.Deserialize(FR);
            FR.Close();
            
            // restor list of cures
            FileStream cur = new FileStream("cure.xml", FileMode.Open);
            XmlSerializer ssssss = new XmlSerializer(pharmacy.GetType());
            pharmacy = (List<cure>)ssssss.Deserialize(cur);
            cur.Close();
            
            // restor list of accounts
            FileStream acc = new FileStream("account.xml", FileMode.Open);
            XmlSerializer sssssss = new XmlSerializer(accounts.GetType());
            accounts = (List<account>)sssssss.Deserialize(acc);
            acc.Close();
            
        }

        public void save_doctor(){
          //store doctors information
            FileStream f = new FileStream("doctor.xml", FileMode.Create);
            XmlSerializer s = new XmlSerializer(doctors.GetType());
            s.Serialize(f, doctors);
            f.Close();
            }
        public void save_patient(){
          //store patients information
            FileStream ff = new FileStream("patient.xml", FileMode.Create);
            XmlSerializer ss = new XmlSerializer(patients.GetType());
            ss.Serialize(ff, patients);
            ff.Close();
          }
        public void save_death(){
           //store dead information
            FileStream fd = new FileStream("dead_people.xml", FileMode.Create);
            XmlSerializer sd = new XmlSerializer(death.GetType());
            sd.Serialize(fd, death);
            fd.Close();
          }
        public void save_accounts(){
          //store account information
          FileStream facc = new FileStream("account.xml", FileMode.Create);
            XmlSerializer saccou = new XmlSerializer(accounts.GetType());
            saccou.Serialize(facc, accounts);
            facc.Close();
          }
        public void save_pharmacy(){
          //store pharmacy information
           FileStream fcure = new FileStream("cure.xml", FileMode.Create);
            XmlSerializer scu = new XmlSerializer(pharmacy.GetType());
            scu.Serialize(fcure, pharmacy);
            fcure.Close();
         }
        public void save_rooms(){
         //store rooms information
            FileStream fr = new FileStream("room.xml", FileMode.Create);
            XmlSerializer sr = new XmlSerializer(ROOMS.GetType());
            sr.Serialize(fr, ROOMS);
            fr.Close();

         }

        public void save()
        {
            //store doctors information
            FileStream f = new FileStream("doctor.xml", FileMode.Create);
            XmlSerializer s = new XmlSerializer(doctors.GetType());
            s.Serialize(f, doctors);
            f.Close();
            
            //store patients information
            FileStream ff = new FileStream("patient.xml", FileMode.Create);
            XmlSerializer ss = new XmlSerializer(patients.GetType());
            ss.Serialize(ff, patients);
            ff.Close();

            
            //store deaf information
            FileStream fd = new FileStream("dead_people.xml", FileMode.Create);
            XmlSerializer sd = new XmlSerializer(death.GetType());
            sd.Serialize(fd, death);
            fd.Close();

            //store rooms information
            FileStream fr = new FileStream("room.xml", FileMode.Create);
            XmlSerializer sr = new XmlSerializer(ROOMS.GetType());
            sr.Serialize(fr, ROOMS);
            fr.Close();

            FileStream fcure = new FileStream("cure.xml", FileMode.Create);
            XmlSerializer scu = new XmlSerializer(pharmacy.GetType());
            scu.Serialize(fcure, pharmacy);
            fcure.Close();

            FileStream facc = new FileStream("account.xml", FileMode.Create);
            XmlSerializer saccou = new XmlSerializer(accounts.GetType());
            saccou.Serialize(facc, accounts);
            facc.Close();
            
        }
        public void update()
        {
            load();
        }
        public bool search_acc_existance(string mail, string pass)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].e_mail == mail && accounts[i].password == pass)
                { 
                    return true; 
                }
            }
            return false;
        }
        public string search_acc_type(string mail)
        {
            string fnd = "";
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].e_mail == mail)
                {
                    fnd= accounts[i].type;
                    break;
                }
            }
            return fnd;
        }
        public void search_patient_info(string name, ref List<patient> x)
        {
            for(int i=0;i<patients.Count;i++)
            {
                if(patients[i].name==name)
                {
                    x.Add(patients[i]);
                }
            }
        }
        public void search_dead_info(string name, ref List<dead> x) 
        {
            for(int i=0;i<death.Count;i++)
            {
                if(death[i].name==name)
                {
                    x.Add(death[i]);
                }
            }
        }
        public void delete_acc(string mail)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].e_mail == mail ) 
                {
                    search_doc_available(accounts[i].username);
                    accounts.RemoveAt(i);
                    break;
                }
            }
        }
        public void search_doc_available(string name)
        {
            for(int i=0;i<doctors.Count;i++)
            {
                if(doctors[i].name==name)
                {
                    doctors[i].available = false;
                    save_doctor();
                    load_doctor();
                    break;
                }
            }
        }
        public void update_room(string patient_name)
        {
            for(int i=0;i<ROOMS.Count;i++)
            {
                if(ROOMS[i].patient_name==patient_name)
                {
                    ROOMS[i].available = true;
                    ROOMS[i].patient_name = "UNKNOWN"; 
                    break;
                }
            }
        }
        public void update_diagnosise(string name,string diag)
        {
            for(int i=0;i<patients.Count;i++)
            {
                if(patients[i].name==name)
                {
                    patients[i].diagnosis = diag;
                    save_patient();
                    load_patient();
                    break;
                }
            }
        }
        public void doctor_spiciality(string spiciality , ref List<string> s){
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].speciality == spiciality&&doctors[i].available==true)
                    s.Add(doctors[i].name); 
            }
        }
        public bool search_patient_existance(string name)
        {
            bool fnd = false;
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].name == name)
                {
                    fnd = true;
                    break;
                }
            }
            return fnd;
        }

        public void add_patient(patient p)
        {
            patients.Add(p);
        }
        public void add_dead(dead d)
        {
            death.Add(d);
        }
        public void add_cure(string cure_name, int quentity)
        {
            bool find = false;
            cure c = new cure(cure_name, quentity);
            for (int i = 0; i < pharmacy.Count; i++)
            {
                if (pharmacy[i].name == cure_name)
                {
                    pharmacy[i].quentity += quentity;
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                pharmacy.Add(c);
            }
        }
        public bool buy_cure(string cure_name, int quentity)
        {
            bool find = false;
            
            for (int i = 0; i < pharmacy.Count; i++)
            {
                if (pharmacy[i].name == cure_name && pharmacy[i].quentity >= quentity)
                {
                    pharmacy[i].quentity -= quentity;
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                return find;
            }
            else { return find; }
        }
        public void add_account(account a)
        {
            accounts.Add(a); 
        }
        public void add_dead(string name,string diag)
        {
            for(int i=0;i<patients.Count;i++)
            {
                if(patients[i].name==name)
                {
                    dead x = new dead();
                    x.name = patients[i].name;
                    x.address = patients[i].address;
                    x.age = patients[i].age;
                    x.satus = diag;
                    death.Add(x);

                    save_death();
                    load_death();
                    break;
                }
            }
        }
        public void del_patient(string name)
        {
            for(int i=0;i<patients.Count;i++)
            {
                if(patients[i].name==name)
                {
                    patients.RemoveAt(i);
                    save_patient();
                    load_patient();
                    break;
                }
            }
        }     
        public void add_doctor(doctor d)
        {
            doctors.Add(d);
        }
        public void add_room(string name , string type)
        {
            for (int i = 0; i < ROOMS.Count; i++)
            {
                if (ROOMS[i].room_type == type && ROOMS[i].available == true)
                {
                    ROOMS[i].patient_name = name;
                    ROOMS[i].available = false;
                    save_rooms(); 
                    break; 
                }
            }
        }
        public bool room_type(string type)
        {
            for(int i=0; i<ROOMS.Count; i++)
            {
                if (ROOMS[i].room_type == type && ROOMS[i].available == true)
                {
                    return true; 
                }
            }
                    return false; 
        }
        public bool available(string email)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].e_mail == email )
                {
                    return false;
                }
            }
            return true;
        }
        ~system()
        {
            save();
        }
        
    }
}