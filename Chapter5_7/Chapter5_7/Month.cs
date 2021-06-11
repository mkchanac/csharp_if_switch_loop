using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_7
{
    class Month
    {
        private int monthNumber;

        public Month() 
        {
        
        }

        public Month(int num)
        {
            monthNumber = num;
        }

        public int MonthNumber
        {
            get 
            { 
                return monthNumber; 
            }
            set
            {
                monthNumber = value;
            }
        }

        public string ReturnMonthName()
        {
            string name;
            switch (monthNumber) 
            {
                case 1:
                    name = "January";
                    break;
                case 2:
                    name = "February";
                    break;
                case 3:
                    name = "March";
                    break;
                case 4:
                    name = "April";
                    break;
                case 5:
                    name = "May";
                    break;
                case 6:
                    name = "June";
                    break;
                case 7:
                    name = "July";
                    break;
                case 8:
                    name = "August";
                    break;
                case 9:
                    name = "September";
                    break;
                case 10:
                    name = "October";
                    break;
                case 11:
                    name = "Novemember";
                    break;
                case 12:
                    name = "December";
                    break;
                default:
                    name = "Invalid Month Number";
                    break;

            }

            return name;
        }

        public int ReturnDayOfMonth()
        {
            int day;
            switch (monthNumber)
            {
                case 1:
                    day = 31;
                    break;
                case 2:
                    day = 28;
                    break;
                case 3:
                    day = 31;
                    break;
                case 4:
                    day = 30;
                    break;
                case 5:
                    day = 31;
                    break;
                case 6:
                    day = 30;
                    break;
                case 7:
                    day = 31;
                    break;
                case 8:
                    day = 31;
                    break;
                case 9:
                    day = 30;
                    break;
                case 10:
                    day = 31;
                    break;
                case 11:
                    day = 30;
                    break;
                case 12:
                    day = 31;
                    break;
                default:
                    day = 0;
                    break;

            }

            return day;
        }

        public override string ToString()
        {
            return "Month Name: " + ReturnMonthName() + "\nDay of Month: " + ReturnDayOfMonth();
        }
    }
}
