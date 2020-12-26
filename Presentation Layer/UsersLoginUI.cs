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
    public partial class UsersLoginUI : Form
    {
        public UsersLoginUI()
        {
            InitializeComponent();
        }

        private void UsersLoginUI_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username or Password Field Must be Filled");
            }
            else
            {
                UsersLoginServices userLoginService = new UsersLoginServices();
                bool result = userLoginService.UsersLogin(textBox1.Text, textBox2.Text);
                if (result)
                {
                    UserEventsUI eventsUI = new UserEventsUI(textBox1.Text);
                    eventsUI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Icorrect Username or Password");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserRegistrationUI userRegistrationUI = new UserRegistrationUI();
            userRegistrationUI.Show();
            this.Hide();
        }
    }
}
