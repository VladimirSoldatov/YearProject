using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearMyProject
{
    class DatePlus:Date
    {
        public DatePlus() { }
        public DatePlus(int year, int month, int day) : base(year, month, day) { }
        public int DaySince1600
        {
            get
            {
                return 365 - (Year - 1606) + (Year - 1597) / 4 - (Year - 1601) / 100 * (Year - 1601) / 400 + DayOfYear;
            }

        }
        public override string ToString()
        {
            string[] str = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
            return String.Format("{0} {1} {2}", Day, str[Month - 1], Year);
        }
        public static int operator-(DatePlus obj1, DatePlus obj2)
        {
            return obj1.DaySince1600 - obj2.DaySince1600;
        }
    }
}
