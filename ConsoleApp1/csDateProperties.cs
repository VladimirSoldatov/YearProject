using System;
namespace YearMyProject
{
    class csDateProperties
    {
        static void Main(string[] args)
        {
            Date mydate = new Date();
            try
            {
                mydate.Month = 12;
                mydate.Day = 31;
                mydate.Year = 2001;
                Console.WriteLine("Day of year {0}", mydate.DayOfYear);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Date
    {
        int year;
        int month;
        int day;
        static int[] MonthDays = new int[] { 0, 31, 59, 90, 120, 151, 181, 212, 243, 274, 304, 334 };
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1600)
                    throw new ArgumentOutOfRangeException("Year");
                else
                    year = value;
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value < 1 || value >12)
                    throw new ArgumentOutOfRangeException("Month");
                else
                    month = value;
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentOutOfRangeException("Day");
                else
                    day = value;
            }
        }
        public Date()
        {
            Year = 1600;
            Month = 1;
            Day = 1;
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public int DayOfYear
        {
            get
            {
                return MonthDays[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
            }
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year / 400 == 0));
        }
    }
}
