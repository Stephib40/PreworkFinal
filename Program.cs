using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreworkFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number to Reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Your Reverse Number is {0}", Reverse);
            Console.ReadLine();
        }
    }
    }
}
