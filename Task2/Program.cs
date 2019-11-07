using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
           var skaiciai = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            var antrasskaicius = int.Parse(Console.ReadLine());
                Console.WriteLine($"Sum is: {skaiciai + antrasskaicius}"); // “result” is variable name;
            Console.ReadKey();

        }
    }
}
