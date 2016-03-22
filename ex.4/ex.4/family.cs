using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._4
{
    class family
    {
        private String names;
        private int adults;
        private int teenagers;
        private int child;
        private double income;

        public family(string names)
        {
            //טענת כניסה: הפעולה מקבלת שם משפחה 
            //טענת יציאה: הפעולה בונה עצם מסוג "משפחה"
            this.names = names;
            this.adults = 0;
            this.teenagers = 0;
            this.child = 0;
            this.income = 0;
        }

        public string GetNames()
        {
            return names;
        }

        public int GetAdults()
        {
            return adults;
        }

        public int GetTeenagers()
        {
            return teenagers;
        }

        public int GetChild()
        {
            return child;
        }

        public double GetIncome()
        {
            return income;
        }

        public void SetNames(string names)
        {
            this.names = names;
        }

        public void SetAdults(int adults)
        {
            this.adults = adults;
        }

        public void SetTeenagers(int teenagers)
        {
            this.teenagers = teenagers;
        }

        public void SetChild(int child)
        {
            this.child = child;
        }

        public void SetIncome(double income)
        {
            this.income = income;
        }
        
        public string ToFamilyString()
        {
            return "in " + this.names  + " family there is " + this.child + " kids, " + this.teenagers + " teens and " + this.adults + " adults. the income is " +this.income;
        }

        public double water()
        {
            double points = this.adults + this.teenagers * 0.7 + this.child * 0.5;
            return points;
        }

        public string Income(double AvIncome)
        {
            if (AvIncome*1.1 < this.income)
            {
                return "above average";
            }
            else if ((this.income < AvIncome*1.1)&&(this.income > AvIncome *0.9))
            {
                return "average";
            }
            else
            {
                return "below average";
            }
        }

        public void ChildToTeen()
        {
            this.child--;
            this.teenagers++;
        }

        public void TeenToAdult()
        {
            this.teenagers--;
            this.adults++;
        }
    }
}
