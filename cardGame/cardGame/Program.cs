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
        Random random = new Random();
        
        //Const variables declarations
        const int amountColourTypes = 4;
        const int amountCardTypes   = 13;

        //Array declarations
        static string[,] cardDeckString= new String[amountColourTypes,amountCardTypes]; //Used to hold all card values
        static bool[,] cardDeckBool = new bool[amountColourTypes, amountCardTypes];     //Used to check if cards have been placed

        //Functions
        
        //Function for initializing string array
        static string[,] cardDeckInit(string[,] cardDeckString)
        {
            int colourPicker = 1; //Used in loop to designate what colour to assign card (1 = Hearts, 2 = Diamonds, 3 = Clubs, 4 = Spades)
            //String for holding special values
            string tempColourHolder  = string.Empty;
            //Loop assigns cards into the array starting with Hearts Ace
            for (int x = 0; x < amountColourTypes; x++)
            {
                for (int y = 0; y < amountCardTypes; y++)
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
                    switch(y)
                    {
                        case 1:
                            cardDeckString[x, y] = tempColourHolder + " " + "Ace";
                            break;
                        case 11:
                            cardDeckString[x, y] = tempColourHolder + " " + "Jack";
                            break;
                        case 12:
                            cardDeckString[x, y] = tempColourHolder + " " + "Queen";
                            break;
                        case 13:
                            cardDeckString[x, y] = tempColourHolder + " " + "King";
                            break;
                        default:
                            //Assign value to array, whitespace used for seperating colour & type
                            cardDeckString[x, y] = tempColourHolder + " " + y.ToString();
                            break;
                    }
                    //End of inner-loop
                }
                colourPicker++; //Updates to next colour after running through one color
                //End of outer-Loop
            }

            return cardDeckString;
        }

        static void Main(string[] args)
        {
            cardDeckInit(cardDeckString);

            //For testing to be REMOVED
            foreach (string card in cardDeckString)
            {
                Console.WriteLine(card);
            }
        }
    }
}
