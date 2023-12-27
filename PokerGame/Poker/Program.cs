using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(65, 50);
            //Remove scroll bars by setting buffer to window size
            Console.BufferWidth = 65;
            Console.BufferHeight = 50;            
            Console.Title = "Play poker with the computer";
            DealCards dc = new DealCards();
            bool exodos = false;

            while (!exodos)
            {
                dc.Deal();
                int x = 0; int y = 0;
                Console.SetCursorPosition(x,y);

                char epilogi = ' ';
                while(!epilogi.Equals('Y') && !epilogi.Equals('N'))
                {
                    Console.SetCursorPosition(0, 48);                 
                    Console.WriteLine("Pame pali? (Y)es or (N)o");
                    epilogi = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (epilogi.Equals('Y'))
                        exodos = false;
                    else if (epilogi.Equals('N'))
                        exodos = true;
                    else
                        Console.WriteLine("Mh egkyrh epilogh, prospathise pali.");

                }
            }
        }
    }
}
