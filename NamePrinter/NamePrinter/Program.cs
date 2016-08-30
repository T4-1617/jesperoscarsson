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
            Console.Write("What's your first name?: ");
            string firstName = Console.ReadLine();
            Console.Write("\nWhat's your last name?: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nHej " + firstName + " " + lastName);
        }
    }
}
