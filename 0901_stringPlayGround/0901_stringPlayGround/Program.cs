using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0901_stringPlayGround
{
    class Program
    {
        //Function go here

        //Perform some actions on string before usage
        static string stringProcessing(string name)
        {
            name = name.Trim();
            return name;
        }

        //Compare value and creates a leet string
        static string leetConverter(char i)
        {
            string leetNum = string.Empty;
            //Limited to 4 since I don't want to type 200 rows of switch case
            switch (i)
            {
                case 'a':
                    leetNum = "4";
                    break;
                case 'e':
                    leetNum = "3";
                    break;
                case 'l':
                    leetNum = "1";
                    break;
                case 't':
                    leetNum = "7";
                    break;
                default:
                    leetNum = char.ToString(i);
                    break;
            }

            return leetNum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Greetings! What's your full name?"); //Get name
            string name = Console.ReadLine(); //Save name
            stringProcessing(name);           //Send to a function that trims the string (One can add other functions to the function later if needed)

            Console.WriteLine("\n\tInfo:");
            //Char stats
            Console.WriteLine("Total amount of characters: " + name.Length);
            Console.WriteLine("Amount of characters without spacing: " + name.Replace(" ", "").Length); //Print length with all spaces turned to ""

            //Name stats
            //First name
            int indexOfSpace = name.IndexOf(' ');
            string fName = name.Substring(0, indexOfSpace);
            Console.WriteLine("Your first name is: " + fName + ",\tand it contains: (" + indexOfSpace + ") characters"); //Prints first name and character count
            //Second name
            string sName = name.Substring(++indexOfSpace, (name.Length - fName.Length)-1);
            //Prints second name and character count
            Console.WriteLine("Your second name is: " + sName + ",\tand it contains: (" + (name.Length - indexOfSpace) + ") characters");
            //Reversed name print
            Console.WriteLine("Reversed name:" + sName + " " + fName);

            //Vertical print
            string upperCaseName = name;
            upperCaseName = upperCaseName.ToUpper();    //Saves name in CAPS to new string
            Console.WriteLine("\nVertical Print:");
                //First name
            foreach (char item in upperCaseName.Split(' ')[0])  //Prints first name
            {
                Console.WriteLine("----->" + item);
            }

                //Second name
            foreach (char item in upperCaseName.Split(' ')[1])  //Prints second name
            {
                Console.WriteLine("------->" + item);
            }

            //Backwards print
            string lowerCaseName = name;
            lowerCaseName = lowerCaseName.ToLower();    //Saves name in lowercase
            Console.Write("\nBackwards: ");

            for (int i = (name.Length-1); i >= 0 ; i--) //Prints the name backwards
            {
                Console.Write(lowerCaseName[i]);
            }

            //Varied case (LiKe ThIs)

            Console.Write("\nSwitched up: ");
            bool switcher = true; //Used to change between upper and lowercase
            int u = 0;  //Used to break loop, each loop gives one tick until u = name.Length

            while(u < name.Length)
            {
                switch (switcher) //Changes state of switcher depending on previous state, also prints letter in correct case
                {
                    case true:
                        Console.Write(upperCaseName[u]);
                        switcher = false;
                        break;
                    case false:
                        Console.Write(lowerCaseName[u]);
                        switcher = true;
                        break;
                    default:
                        break;
                }

                u++;

            }

            //Leet speak (133 = lee etc.)
            List<string> leetSpeech = new List<string>(); //Creates list to easily hold values from the function leetConverter

            for(int i = 0; i < name.Length; i++)
            {
                leetSpeech.Add(leetConverter(lowerCaseName[i])); //Adds the value to the list
            }
                //Prints out
            Console.Write("\n\nLeet speak: ");
                //Converts list to string for ease of writing out
            string leetSpeechPrintable = leetSpeech.ToString();
            foreach (var item in leetSpeech)
            {
                Console.Write(item);
            }
            Console.Write("\n");
        }
    }
}
