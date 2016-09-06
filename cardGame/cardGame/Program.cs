using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGame
{
    class Program
    {
        //Declaration of random class
        static Random random = new Random();
        
        //Const variables declarations
        const int amountColourTypes = 4;
        const int amountCardTypes   = 13;
        const int amountTotalCards  = 52; //Maybe remove?

        //Array declarations
        static string[,] cardDeckString= new String[amountColourTypes,amountCardTypes]; //Used to hold all card values
        static bool[,] cardDeckBool = new bool[amountColourTypes, amountCardTypes];     //Used to check if cards have been placed

        //Functions
       
        //Function for initializing string array
        static string[,] cardDeckInit(string[,] cardDeckString)
        {
            int colourPicker = 1; //Used in loop to designate what colour to assign card (1 = Hearts, 2 = Diamonds, 3 = Clubs, 4 = Spades)
            string tempColourHolder  = string.Empty; //String for holding special values
            //Loop assigns cards into the array starting with Hearts Ace
            for (int x = 0; x < amountColourTypes; x++)
            {
                for (int y = 1; y - 1 < amountCardTypes; y++) //Add 1 to y so "Colour 1" isn't printed (since Ace is = 1)
                {
                    switch(colourPicker)
                    {
                        case 1:
                            tempColourHolder = "Hearts";
                            break;
                        case 2:
                            tempColourHolder = "Diamonds";
                            break;
                        case 3:
                            tempColourHolder = "Clubs";
                            break;
                        case 4:
                            tempColourHolder = "Spades";
                            break;
                        default:
                            tempColourHolder = "Error with string tempColourHolder!";
                            break;
                    }
                    //Checks for Ace, Jack, Queen & King and names there after, else just give the y number as name
                    //Takes y - 1 so we don't try to write outside the array
                    switch (y)
                    {
                        case 1:
                            cardDeckString[x, y - 1] = tempColourHolder + " " + "Ace";
                            break;
                        case 11:
                            cardDeckString[x, y - 1] = tempColourHolder + " " + "Jack";
                            break;
                        case 12:
                            cardDeckString[x, y - 1] = tempColourHolder + " " + "Queen";
                            break;
                        case 13:
                            cardDeckString[x, y - 1] = tempColourHolder + " " + "King";
                            break;
                        default:
                            //Assign value to array, whitespace used for seperating colour & type
                            cardDeckString[x, y - 1] = tempColourHolder + " " + y.ToString();
                            break;
                    }
                    //End of inner-loop
                }
                colourPicker++; //Updates to next colour after running through one color
                //End of outer-Loop
            }

            return cardDeckString;
        }
        //Function for checking if a card has been placed
        static bool cardDealtCheck(int x, int y)
        {
            bool cardDealtCheckAnswer = false;

            if (cardDeckBool[x,y] == true)
            {
                cardDealtCheckAnswer = true;
            }

            return cardDealtCheckAnswer;
        }
        //Function for giving user a random card
        static string getRndCard()
        {
            int x = random.Next(0, amountColourTypes);
            int y = random.Next(0, amountCardTypes);

            if(cardDealtCheck(x, y) == true)
            {
                return getRndCard();
            }

            cardDeckBool[x,y] = true; //Sets card status to placed
            return cardDeckString[x,y];
        }

        static void Main(string[] args)
        {
            cardDeckInit(cardDeckString);
            //Loop for giving out cards For testing, to be changed!!!!
            for (int i = 1; i <= amountTotalCards; i++)
            {
                Console.WriteLine("Press enter to get a card");
                Console.ReadLine();

                Console.WriteLine("\n" + getRndCard());
            }
        }
    }
}
