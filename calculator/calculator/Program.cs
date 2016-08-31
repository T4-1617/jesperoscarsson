using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double numberOne = double.Parse(Console.ReadLine()); //Retrieves a string from Console and converts it into double for saving

            Console.Write("\nEnter the Second number: ");
            double numberTwo = double.Parse(Console.ReadLine()); //Retrieves a string from Console and converts it into double for saving

            Console.Write("\n\nEnter your operation: + | - | / | * : ");
            string operation = Console.ReadLine(); //Saves the operator in a string

            double answer = 0; //Initialize a variable that will hold the answer later

            switch (operation) //Matches the selected operator and calculates answer
            {
                case "+":
                    answer = numberOne + numberTwo;
                    break;
                case "-":
                    answer = numberOne - numberTwo;
                    break;
                case "/":
                    answer = numberOne / numberTwo;
                    break;
                case "*":
                    answer = numberOne * numberTwo;
                    break;
                default: //If a invalid value is named this appears and the answer stays at 0
                    Console.Write("\n\nError,invalid entry!");
                    break;
            }
            string show = String.Format("\nAnswer: {0} {1} {2} = {3}", numberOne, operation, numberTwo, answer);

            Console.WriteLine(show);
        }
    }
}
