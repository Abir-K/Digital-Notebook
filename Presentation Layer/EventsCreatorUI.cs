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
    public partial class EventsCreatorUI : Form
    {
        UserEventsUI userEvents;
        public EventsCreatorUI(UserEventsUI eventsUI)
        {
            InitializeComponent();
            this.userEvents = eventsUI;
            button2.Click += this.RefreshGridView;
        }

        public void RefreshGridView(object sender, EventArgs e)
        {
            EventServices eventServices = new EventServices();
            int id = Convert.ToInt32(userEvents.userId.Text);
            userEvents.loadUserAllEvents.DataSource = eventServices.GetAllEvents(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventServices eventServices = new EventServices();
            int userId = Convert.ToInt32(userEvents.userId.Text);
            int result = eventServices.AddnewEvent(textBox1.Text, dateTimePicker1.Text, comboBox1.Text, textBox3.Text,userId);
            if(result>0)
            {
                MessageBox.Show("Event Added");
                textBox1.Text = comboBox1.Text = textBox3.Text = string.Empty;
            }

            else { MessageBox.Show("Something Wrong"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersLoginUI usersLoginUI = new UsersLoginUI();
            usersLoginUI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userEvents.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EventsCreatorUI_Load(object sender, EventArgs e)
        {
            string str1 = "high";
            string str2 = "modarate";
            string str3 = "Less Important";
            comboBox1.Items.Add(str1);
            comboBox1.Items.Add(str2);
            comboBox1.Items.Add(str3);
        }
    }
}
