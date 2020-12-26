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
    public partial class EventsModifierUI : Form
    {
        UserEventsUI userEvent;
        public EventsModifierUI(UserEventsUI eventsUI)
        {
            InitializeComponent();
            this.userEvent = eventsUI;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserEventsUI userEventsUI = new UserEventsUI(textBox1.Text);
            userEventsUI.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EventsModifierUI_Load(object sender, DataGridViewCellEventArgs e1)
        {
            textBox4.Text = userEvent.loadUserAllEvents.Rows[e1.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = userEvent.loadUserAllEvents.Rows[e1.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = userEvent.loadUserAllEvents.Rows[e1.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = userEvent.loadUserAllEvents.Rows[e1.RowIndex].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventServices eventServices = new EventServices();
            int id = Convert.ToInt32(textBox4.Text);
            eventServices.UpdateExistingEvent(textBox1.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EventServices eventServices = new EventServices();
            int id = Convert.ToInt32(textBox4.Text);
            eventServices.DeleteExitingEvent(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersLoginUI usersLoginUI = new UsersLoginUI();
            usersLoginUI.Show();
            this.Hide();
        }

        private void EventsModifierUI_Load(object sender, EventArgs e)
        {
           
        }
    }
}
