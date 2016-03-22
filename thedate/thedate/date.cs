using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thedate
{
    class date
    {
        private int day;
        private int month;
        private int year;
        public date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public int GetDay()
        {
            return this.day;
        }
        public int GetMonth()
        {
            return this.month;
        }
        public int GetYear()
        {
            return this.year;
        }
        public string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }
        public void UpTomorrow()
        {
            this.day = this.day + 1;
        }
    }
}
