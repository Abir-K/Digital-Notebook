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
    public partial class UserEventsUI : Form
    {
        public UserEventsUI(string userName)
        {
            InitializeComponent();
            userId.Text = userName;

        }

        private void loadUserAllEvents_CellContentClick(object sender, EventArgs e)
        {
            EventServices eventServices = new EventServices();
            int id = Convert.ToInt32(userId.Text);
            loadUserAllEvents.DataSource = eventServices.GetAllEvents(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventsCreatorUI eventsCreatorUI = new EventsCreatorUI(this);
            eventsCreatorUI.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsersLoginUI usersLoginUI = new UsersLoginUI();
            usersLoginUI.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EventsModifierUI eventsModifierUI = new EventsModifierUI(this);
            eventsModifierUI.Show();
            this.Hide();
        }

        private void loadUserAllEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text= loadUserAllEvents.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void UserEventsUI_Load(object sender, EventArgs e)
        {
            EventServices eventServices = new EventServices();
            int id = Convert.ToInt32(userId.Text);
            loadUserAllEvents.DataSource = eventServices.GetAllEvents(id);
        }
    }
}
