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
    public partial class Manegar : Form
    {
        public system hosp = new system();
        public Manegar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(email.Text=="")
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else
            {
                hosp.delete_acc(email.Text);
                hosp.save_accounts();
                MessageBox.Show("remove successfuly. ");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            signup su = new signup();
            su.Show();
            this.Hide();
        }

        private void Manegar_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            hosp.update();
            MessageBox.Show("update successfuly. ");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin si = new signin();
            si.Show();
            this.Hide();
        }
    }
}
