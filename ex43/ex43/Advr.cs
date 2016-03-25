using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex43
{
    class Advr
    {
        private string advrName;
        private string cmpName;
        private int sec;
        
        public Advr(string advrName, string cmpName, int sec)
        {
            this.advrName = advrName;
            this.cmpName = cmpName;
            this.sec = sec;
        }

        public Advr()
        {
             
        }

        public string getAdvrName()
        {
            return this.advrName;
        }

        public string getCmpName()
        {
            return this.cmpName;
        }

        public int getSec()
        {
            return this.sec;
        }

        public void setAdvrName(string advrName)
        {
            this.advrName = advrName;
        }

        public void setCmpName(string cmpName)
        {
            this.cmpName = cmpName;
        }

        public void setSec(int sec)
        {
            this.sec = sec;
        }

        public string ToString()
        {
            return  ""
        }
    }
}
