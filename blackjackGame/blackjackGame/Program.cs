using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackGame
{
    class Program
    {
        //Declare the random class
        static Random rndGenerator = new Random();

        //Variables
        const int amountSuits = 8;
        const int amountRanks = 13;
        static bool gameStatus = true;

        //Arrays
        static string[,] shoe = new string[amountSuits, amountRanks]; //Even though there are only 4 suits the value 8 is used to simulate 2 decks
        static bool[,] shoePlacementHolder = new bool[amountSuits, amountRanks];

        //Functions

        //Function for initializing array
        static string[,] shoeInit(string[,] shoe)
        {
            //Temp variables used in selecting and temp storing assignment values
            int suitSelector = 1;
            string tempSuitHolder = string.Empty;
            //Assign values to the first row of suits and then the next until all are filled
            for (int x = 0; x < amountSuits; x++)
            {
                for (int y = 1; (y - 1) < amountRanks; y++) //y starts at 1 so rank 1 isn't created (since 1 is called Ace)
                {
                    switch (suitSelector)
                    {
                        case 1:
                            tempSuitHolder = "Hearts";
                            break;
                        case 2:
                            tempSuitHolder = "Diamonds";
                            break;
                        case 3:
                            tempSuitHolder = "Clubs";
                            break;
                        case 4:
                            tempSuitHolder = "Spades";
                            break;
                        case 5:
                            tempSuitHolder = "Hearts";
                            break;
                        case 6:
                            tempSuitHolder = "Diamonds";
                            break;
                        case 7:
                            tempSuitHolder = "Clubs";
                            break;
                        case 8:
                            tempSuitHolder = "Spades";
                            break;
                        default:
                            tempSuitHolder = "Error with string tempSuitHolder!";
                            break;
                    }
                    //Takes y - 1 so the array isn't overwritten
                    switch (y)
                    {
                        case 1:
                            shoe[x, y - 1] = tempSuitHolder + " " + "Ace";
                            break;
                        case 11:
                            shoe[x, y - 1] = tempSuitHolder + " " + "Jack";
                            break;
                        case 12:
                            shoe[x, y - 1] = tempSuitHolder + " " + "Queen";
                            break;
                        case 13:
                            shoe[x, y - 1] = tempSuitHolder + " " + "King";
                            break;
                        default:
                            shoe[x, y - 1] = tempSuitHolder + " " + y.ToString();
                            break;
                    }
                }

                suitSelector++; //Goes to next suit after one suit has been filled with values

            }

            return shoe;
        }

        static void Main(string[] args)
        {
            while (gameStatus == true)
            {
                Console.Write("\nDo you want to draw a card? (y/n): ");
                char playerSelection = Console.ReadKey().KeyChar;

                if (gameStatus == false || playerSelection == 'n') //For ending game
                {
                    Console.WriteLine("\n\nGame over!");
                    break;
                }
                else if (playerSelection == 'y')
                {
                    //Call functions here
                }
                else
                {
                    Console.WriteLine("\nInvalid entry!");
                }
            }
        }
    }
}
