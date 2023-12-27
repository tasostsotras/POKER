using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Betting
    {
        public double PlayerWallet { get; set; }
        public double ComputerWallet { get; set; }
        public double Pot { get; set; }

        double pontarisma;

        public Betting()
        {
            Console.WriteLine("Posa lefta tha valeis?");
            pontarisma = Convert.ToDouble(Console.ReadLine());

          
        }
    }
}
