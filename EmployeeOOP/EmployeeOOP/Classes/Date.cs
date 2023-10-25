using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day;
        #endregion
        #region Method
        public Date(int day, int month, int year)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }
        private bool IsLeapYear(int year)
        {
            return (year % 400 == 0 || year % 4 == 0  && year % 100 != 0);
        }
        private int ValidateDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            
            if(month == 2 && day  == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeadYearException(isLeapYear,year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month]) { 
                return day; 
            }
            else { 
                throw new DayException(String.Format("El día {0} no es valido para mes {1}.", year)); 
            }
        }

        private void IsLeadYearException(bool isLeapYear, int year )
        {
            if (!isLeapYear)
            {
                //Exception creation
                throw new YearException(String.Format("El año {0} no es bisiesto.", year));
            }
        }
        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Exception creation
                throw new YearException(String.Format("El año {0} no es válido.", year));
            }
        }
        private int ValidateMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }
            else
            {
                //Exception creation
                throw new MonthException(String.Format("El mes {0} no es válido.",month));
            }
        }
        public override string ToString()
        {
            //dia/mes/año
            //var dateConcatenated = _day + "/" + _month + "/" + _year;
            //var dateConcatenated2 = $"{_day}/{_month}/{_year}";
            var dateConcatenated = String.Format("{0}/{1}/{2}", _day,_month,_year);
            return dateConcatenated;
        }
        #endregion
    }
}
