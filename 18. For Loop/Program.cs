using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the For Loop");

            for (int i = 0; i<=5;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("This is the While Loop");
            int x = 0;

            while (x<=5)
            {
                Console.WriteLine(x);
                x++;
            }

            //freeze console
            Console.ReadLine();
        }
    }
}
