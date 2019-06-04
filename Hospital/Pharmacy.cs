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
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {
            
        }

        private void buy_Click(object sender, EventArgs e)
        {
            signin s = new signin();
            bool ans = s.hosp.buy_cure(textBox2.Text, Int32.Parse(textBox1.Text));
            if (ans == true)
            {
               // s.hosp.save();
                //s.hosp.load();
                s.hosp.save_pharmacy();
                s.hosp.load_pharmacy();
                MessageBox.Show("Successful buying process");
            }
            else
            {
                MessageBox.Show("A failed purchase"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signin s = new signin();
            s.hosp.add_cure(textBox2.Text, Int32.Parse(textBox1.Text));
         //   s.hosp.save();
           // s.hosp.load();
            s.hosp.save_pharmacy();
            s.hosp.load_pharmacy();
            MessageBox.Show("Successfully added");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s = new signin();
            s.Show();
        }
    }
}
