using Digital_NoteBooK.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_NoteBooK.Presentation_Layer
{
    public partial class UserRegistrationUI : Form
    {
        public UserRegistrationUI()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsersLoginUI usersLoginUI = new UsersLoginUI();
            usersLoginUI.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationServices registrationServices = new RegistrationServices();
            int result = registrationServices.AddnewUser(textBox1.Text + textBox2.Text,textBox4.Text,textBox3.Text,dateTimePicker1.Text,textBox5.Text);

            if(result>0)
            {
                MessageBox.Show("Congo! You are now a Member");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            }
            else { MessageBox.Show("Something Wrong"); }

            
        }
    }
}
