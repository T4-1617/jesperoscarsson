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
        static int amountCards = 104;
        static bool gameStatus = true;
        static int playerPoints = 0;

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

        //Function for checking if card has been placed
        static bool cardPlacedCheck(int x, int y)
        {
            bool cardPlacedCheckAnswer = false;

            if (shoePlacementHolder[x, y])
            {
                cardPlacedCheckAnswer = true;
            }

            return cardPlacedCheckAnswer;
        }

        //Function for giving user a random card from shoe
        static string getRndCard()
        {
            int x = rndGenerator.Next(0, amountSuits);
            int y = rndGenerator.Next(0, amountRanks);

            //Return used so it updates actual value in original function
            if (cardPlacedCheck(x, y))
            {
                return getRndCard();
            }
            //Extra task 1.1 & 1.2
            int tempYvalHolder = y;
            switch (tempYvalHolder)
            {
                case 1: //Decide if 1 = 11 or not
                    if (11 + playerPoints <= 21)
                    {
                        tempYvalHolder = 10;
                    }
                    break;
                case 11:
                    tempYvalHolder = 9;
                    break;
                case 12:
                    tempYvalHolder = 9;
                    break;
                case 13:
                    tempYvalHolder = 9;
                    break;
            }

            playerPoints += (tempYvalHolder + 1); //Update point system
            amountCards--;
            shoePlacementHolder[x, y] = true; //Sets card status to placed

            return shoe[x, y];
        }

        //End functions

        static void Main(string[] args)
        {

            shoeInit(shoe);

            while (gameStatus)
            {
                Console.Write("\nDo you want to draw a card? (y/n): ");
                char playerSelection = Console.ReadKey().KeyChar;

                if (amountCards == 0)
                {
                    Console.WriteLine("\nNo cards remaining, ending game");
                    break;
                }
                else if (playerSelection == 'n')
                {
                    Console.WriteLine("\nYou got {0} points, do you want to continue? (y/n): ", playerPoints);
                    char playerNSelection = Console.ReadKey().KeyChar;

                    if (playerNSelection == 'y')
                    {
                        playerPoints = 0;
                        Console.WriteLine();
                    }
                    else
                    {
                        break;
                    }
                }
                else if (playerSelection == 'y')
                {
                    Console.WriteLine("\nYou got a {0} and your total points are: {1}", getRndCard(), playerPoints);

                    if (playerPoints == 21)
                    {
                        Console.WriteLine("\nCongratulations, you've won!!!");
                        break;
                    }
                    else if (playerPoints > 21)
                    {
                        playerPoints = 0;
                        Console.WriteLine("\nYou've lost, better luck next time");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid entry!");
                }
            }
        }
    }
}
