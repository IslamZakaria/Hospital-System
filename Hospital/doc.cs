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
    public partial class doc : Form
    {
        public system hosp = new system();
        public doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hosp.update_diagnosise(textBox1.Text, textBox2.Text);
            patient x = new patient(textBox1.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox2.Text);
            hosp.add_patient(x);
            hosp.save_patient();
            MessageBox.Show("successfuly added. ");
            this.Hide();
            this.Show();
           }

        private void button2_Click(object sender, EventArgs e)
        {
            hosp.add_dead(textBox3.Text,textBox4.Text);
            hosp.del_patient(textBox3.Text);
            MessageBox.Show("successfuly added. ");
            this.Hide();
            this.Show();
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void doc_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s = new signin();
            s.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s = new signin();
            s.Show();
            
        }
    }
}
