using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nHello, what's your last name?: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nHej " + lastName);
        }
    }
}
