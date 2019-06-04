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
    public partial class signup : Form
    {
        signin s = new signin(); 
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!= ""&&textBox3.Text!= ""&& comboBox1.Text!="" &&textBox4.Text!= ""&&textBox5.Text!= ""&&textBox6.Text!= ""&&textBox7.Text!= "" && male.Checked == true || female.Checked == true)
            {
                if (s.hosp.available(textBox3.Text))
                {
                    if (comboBox1.Text == "doctor")
                    {
                        doctor d = new doctor(textBox2.Text, textBox6.Text, textBox7.Text, Int32.Parse(textBox5.Text), textBox1.Text);
                        s.hosp.add_doctor(d);
                        //s.hosp.save();
                        s.hosp.save_doctor();
                        s.hosp.save_pharmacy();
                        account a = new account(textBox3.Text, textBox4.Text, textBox2.Text, comboBox1.Text);
                        s.hosp.add_account(a);
                        //  s.hosp.save();
                        s.hosp.save_accounts();
                        MessageBox.Show("successfully Registered");
                        signin x = new signin();
                        this.Hide();
                        x.Show();
                    }
                    else if (comboBox1.Text == "pharmacist")
                    {
                        doctor d = new doctor(textBox2.Text, textBox6.Text, textBox7.Text, Int32.Parse(textBox5.Text), "pharmacist");
                        s.hosp.add_doctor(d);
                        //s.hosp.save();
                        s.hosp.save_doctor();
                        s.hosp.save_pharmacy();
                        account a = new account(textBox3.Text, textBox4.Text, textBox2.Text, comboBox1.Text);
                        s.hosp.add_account(a);
                        //  s.hosp.save();
                        s.hosp.save_accounts();
                        MessageBox.Show("successfully Registered");
                        signin x = new signin();
                        this.Hide();
                        x.Show();
                    }
                    
                    else if (comboBox1.Text == "receptionist")
                    {
                        account a = new account(textBox3.Text, textBox4.Text, textBox2.Text, comboBox1.Text);
                        s.hosp.add_account(a);
                        //s.hosp.save();
                        s.hosp.save_accounts();
                        MessageBox.Show("successfully Registered");
                        signin x = new signin();
                        this.Hide();
                        x.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("This E-mail Is Already Exist");
                }
            }
            else
            {
                MessageBox.Show("Please enter all your information");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "doctor")
                textBox1.Show();
            else
                textBox1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
