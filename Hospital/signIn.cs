using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class signin : Form
    {
        public system hosp = new system(); 
        public signin()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            signup su = new signup();
            su.Show();
            this.Hide();
        }
        
        private void login_Click(object sender, EventArgs e)
        {
           if(hosp.search_acc_existance(textBox1.Text,textBox2.Text)==true)
           {
               string tp = hosp.search_acc_type(textBox1.Text);
               if (tp == "manager")
               {
                   Manegar mg = new Manegar();
                   mg.Show();
                   this.Hide();
               }
               else if (tp == "receptionist")
               {
                   Reciptionist rp = new Reciptionist();
                   rp.Show();
                   this.Hide();
               }
               else if(tp=="doctor")
               {
                   doc d = new doc();
                   d.Show();
                   this.Hide();
               }
               else if(tp == "pharmacist")
               {
                   Pharmacy p = new Pharmacy();
                   p.Show();
                   this.Hide(); 
               }
           }
           else
           {
               MessageBox.Show("Please Enter A Valid Username Or Pass");
           }
        }

        private void signin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
