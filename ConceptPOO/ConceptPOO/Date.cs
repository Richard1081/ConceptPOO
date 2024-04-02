using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(day);
        }

        private int CheckDay(int day)
        {
            if( day == 29 && _month == 2 && IsLeapYear(_year))
            {
                return day;
            }
            int[] dayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(day >= 1 && day <= dayPerMonth[_month] )
            {
                return day;
            }

            throw new DayException("Invalid day");
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 || year %400 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("Invalid month");
        }

        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }
    }
}
