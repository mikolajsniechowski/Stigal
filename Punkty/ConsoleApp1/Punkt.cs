using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Punkt
    {
        public double x { get; set; }
        public double y { get; set; }
        public Punkt (double xpkt, double ypkt)
        {
            this.x = xpkt;
            this.y = ypkt;
        }
        public void  Print()
        {
            Console.WriteLine("X: " + x + " Y: " + y);
        }


    }
}
