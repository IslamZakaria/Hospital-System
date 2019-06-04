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
    public partial class Reciptionist : Form
    {
        public system hosp = new system();
        public Reciptionist()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchh_Click(object sender, EventArgs e)
        {
            if(patient.Checked==true && textBox2.Text!="")
            {
                List<patient> info = new List<patient>();
                hosp.search_patient_info(textBox2.Text, ref info);
                if (info.Count == 0)
                    MessageBox.Show("Not found. ");
                else
                {
                    richTextBox2.Clear();
                    for (int i = 0; i < info.Count; i++)
                    {
                        richTextBox2.Text = "Name : "+info[i].name + "\n" +"Phone : "+ info[i].phone + "\n" +"Address : "+ info[i].address + "\n" +"Age : "+ info[i].age + "\n" +"Diagnosis : "+ info[i].diagnosis + "\n";
                    }
                }

            }
            else if (dead_people.Checked == true && textBox2.Text != "")
            {
                List<dead> info = new List<dead>();
                hosp.search_dead_info(textBox2.Text, ref info);
                if (info.Count == 0) 
                    MessageBox.Show("Not found. ");
                else
                {
                    richTextBox2.Clear();
                    for (int i = 0; i < info.Count; i++)
                    {
                        richTextBox2.Text = "Name : "+info[i].name + "\n" +"Address : "+ info[i].address + "\n" +"Age : " +info[i].age + "\n" +"Status : "+ info[i].satus + "\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all information");
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reciptionist_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check;
            check = hosp.room_type(typ.Text);
            
            if (check == true&&hosp.search_patient_existance(name_.Text)==true)
            {
                hosp.add_room(name_.Text,typ.Text);
                
                MessageBox.Show("Successfully ADDED");
            }
            else if (check == true && hosp.search_patient_existance(name_.Text) == false)
            {
                MessageBox.Show("Plz Enter a valid name");
            }
            else
            {
                MessageBox.Show("There Is No Room Available"); 
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            hosp.update_room(name.Text);
            //hosp.save();
            hosp.save_rooms();
            MessageBox.Show("sucessfully updated");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {
            //henaaaaaa
            signin s = new signin(); //
            List<string>doc = new List<string>();
            s.hosp.doctor_spiciality(special.Text, ref doc);
            MessageBox.Show(doc.Count.ToString());
            if (doc.Count == 0)
                MessageBox.Show("NOT FOUND.");
            else
            {
                richTextBox1.Clear();

                for (int i = 0; i < doc.Count; i++)
                {
                    richTextBox1.Text += doc[i] + "\n";
                }
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_patient_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin s = new signin();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
