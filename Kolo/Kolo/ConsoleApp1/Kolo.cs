using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kolo
    {
        public double r {get;set;}
        public Kolo(double r)
        {
            this.r = r;
        }
        public double Pole()
        {
            return Math.PI * Math.Pow(this.r, 2);
        }
        public double Obwod()
        {
            return 2 * Math.PI * this.r; 
        }
    }
}
