using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int month, year;
        int nameNumber = 0;
        List<string> namesList = new List<string> { "Peter", "George", "Tom", "Jordan", "Felix", "LeBron" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbdate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month+1, 1); //get the first day of the month

            int days;
            if (month == 0)
            {
                days = 31;
            }
            else
            {
                days = DateTime.DaysInMonth(year, month + 1); //get the count of days of the month
            }
            

            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++) //creating blank usercontrol 
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //creating usercontrol for days
            
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();

                ucdays.fillInfo(i, namesList[nameNumber]);
                if(nameNumber < 5)
                {
                    nameNumber++;
                }
                else
                {
                    nameNumber = 0;
                }
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            //clean container before showing next month
            daycontainer.Controls.Clear();
            int days;
            string monthname;
            if (month == 11)
            {
                year++;
                month = 0;
                days = 31;
                monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            }
            else
            {
                month++;
                days = DateTime.DaysInMonth(year, month+1); //get the count of days of the month
                monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            }


                
                lbdate.Text = monthname + " " + year;

                DateTime startofthemonth = new DateTime(year, month+1, 1); //get the first day of the month



            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

                for (int i = 1; i < daysoftheweek; i++) //creating blank usercontrol 
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    daycontainer.Controls.Add(ucblank);
                }

            //creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();

                ucdays.fillInfo(i, namesList[nameNumber]);
                if (nameNumber < 5)
                {
                    nameNumber++;
                }
                else
                {
                    nameNumber = 0;
                }
                daycontainer.Controls.Add(ucdays);
            }



        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clean container before showing next month
            daycontainer.Controls.Clear();

            int days;
            if (month == 0)
            {
                year--;
                month = 11;
                days = 31;
            }
            else
            {
                days = DateTime.DaysInMonth(year, month); //get the count of days of the month
                month--;
                
            }
              
                   
              
                string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
                lbdate.Text = monthname + " " + year;

                DateTime startofthemonth = new DateTime(year, month+1, 1); //get the first day of the month


            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

                for (int i = 1; i < daysoftheweek; i++) //creating blank usercontrol 
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    daycontainer.Controls.Add(ucblank);
                }

            //creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();

                ucdays.fillInfo(i, namesList[nameNumber]);
                if (nameNumber < 5)
                {
                    nameNumber++;
                }
                else
                {
                    nameNumber = 0;
                }
                daycontainer.Controls.Add(ucdays);
            }


        }
    }
}