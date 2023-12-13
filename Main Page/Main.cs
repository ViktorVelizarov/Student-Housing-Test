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

        }

        private void TaskCalendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var temp = new TaskCalendar();
            temp.Show();
        }
    }
}