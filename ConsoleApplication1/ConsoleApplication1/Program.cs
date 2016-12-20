using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string message = "";
                if (i % 3 == 0)
                    message += "On";
                if (i % 7 == 0)
                    message += "Base";
                Console.WriteLine("Number: " + i + " " + message);
            }
            
            System.Console.ReadKey();
        }
    }
}
