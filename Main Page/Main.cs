using Agreements_Page;
using Announcements_Page;
using WinFormsApp1;

namespace Main_Page
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgreementsPage temp = new AgreementsPage();
            temp.Show();
        }

        private void TaskCalendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaskCalendar temp = new TaskCalendar();
            temp.Show();
        }

        private void GroceriesButton_Click(object sender, EventArgs e)
        {

        }

        private void HouseRulesButton_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnnouncementsPage temp = new AnnouncementsPage();
            temp.Show();
        }
    }
}