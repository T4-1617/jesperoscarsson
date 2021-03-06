﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace blackjackGame
{
    class Program
    {
        //Declare the random class
        static Random rndGenerator = new Random();

        //Variables
        const int amountSuits = 16;
        const int amountRanks = 13;
        static int amountCards = 208;
        static bool gameStatus = true;
        static int playerPoints = 0;
        static int playerCurrentPoints = 0;
        static int aiCurrentPoints = 0;
        static bool aiOrPlayer = true; //True = Player, False = AI
        static bool AiTurnCheck = true;

        //Arrays
        static string[,] shoe = new string[amountSuits, amountRanks]; //Even though there are only 4 suits the value 16 is used to simulate 4 decks
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
                        case 5:
                        case 9:
                        case 13:
                            tempSuitHolder = "Hearts";
                            break;
                        case 2:
                        case 6:
                        case 10:
                        case 14:
                            tempSuitHolder = "Diamonds";
                            break;
                        case 3:
                        case 7:
                        case 11:
                        case 15:
                            tempSuitHolder = "Clubs";
                            break;
                        case 4:
                        case 8:
                        case 12:
                        case 16:
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

        //Function for giving user a random card from shoe
        static string getRndCard()
        {
            int x = rndGenerator.Next(0, amountSuits);
            int y = rndGenerator.Next(0, amountRanks);

            //Return used so it updates actual value in original function
            if (shoePlacementHolder[x, y])
            {
                return getRndCard();
            }
            //Extra task 1.1 & 1.2
            int tempYvalHolder = (y + 1);
            switch (tempYvalHolder)
            {
                case 1: //Decide if 1 = 11 or not
                    if (11 + playerCurrentPoints <= 21)
                    {
                        tempYvalHolder = 11;
                    }
                    break;
                case 11:
                case 12:
                case 13:
                    tempYvalHolder = 10;
                    break;
                default:
                    break;
            }
            //Assigns correct player points
            if (aiOrPlayer)
            {
                playerCurrentPoints += tempYvalHolder;
            }
            else if (aiOrPlayer == false)
            {
                aiCurrentPoints += tempYvalHolder;
            }
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
                //Reshuffle deck
                if (amountCards <= 15)
                {
                    for (int x = 0; x < amountSuits; x++)
                    {
                        for (int y = 0; y < amountRanks; y++)
                        {
                            shoePlacementHolder[x, y] = false;
                        }
                    }
                }
                //Change aiOrPlayerso AI gets points
                aiOrPlayer = false;
                Console.WriteLine("\n\nComputer draws {0} and now has {1} points", getRndCard(), aiCurrentPoints);
                aiOrPlayer = true;

                while (aiOrPlayer) //Player turn
                {
                    //AiTurnCheck used to keep looping
                    AiTurnCheck = false;
                    Console.WriteLine("\nYour score is {0} points", playerPoints);
                    Console.Write("\nDo you want to draw a card? (y/n): ");
                    char playerSelection = Console.ReadKey().KeyChar;

                    if (amountCards == 0)
                    {
                        Console.WriteLine("\nNo cards remaining, ending game");
                        gameStatus = false;
                        break;
                    }
                    else if (playerSelection == 'n')
                    {
                        Console.Write("\nYou got {0} points, do you want to continue playing? (y/n): ", playerCurrentPoints);
                        char playerNSelection = Console.ReadKey().KeyChar;

                        if (playerNSelection == 'y')
                        {
                            Console.WriteLine();
                        }
                        else if (playerNSelection == 'n')
                        {
                            AiTurnCheck = true;
                        }
                    }
                    else if (playerSelection == 'y')
                    {
                        Console.WriteLine("\nYou got a {0} and your total points are: {1}", getRndCard(), playerCurrentPoints);

                        if (playerCurrentPoints == 21)
                        {
                            Console.WriteLine("\nCongratulations, you've won!!!");
                            playerCurrentPoints = 0;
                            aiCurrentPoints = 0;
                            playerPoints += 3;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                        else if (playerCurrentPoints > 21)
                        {
                            Console.WriteLine("\nYou've bursted, better luck next time");
                            playerCurrentPoints = 0;
                            aiCurrentPoints = 0;
                            playerPoints--;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid entry!");
                    }

                    while (AiTurnCheck) //AI turn
                    {
                        aiOrPlayer = false;
                        Console.WriteLine("\n\nAI draws " + getRndCard());

                        if (aiCurrentPoints == 21)
                        {
                            Console.WriteLine("\n\nAI got 21 and wins!");
                            playerCurrentPoints = 0;
                            aiCurrentPoints = 0;
                            playerPoints--;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                        else if (aiCurrentPoints > 21)
                        {
                            Console.WriteLine("\n\nAI got {0} points and burst!", aiCurrentPoints);
                            playerCurrentPoints = 0;
                            aiCurrentPoints = 0;
                            playerPoints++;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                        else if (aiCurrentPoints == playerCurrentPoints)
                        {
                            Console.WriteLine("\n\nAI got {0} points and won!", aiCurrentPoints);
                            playerCurrentPoints = 0;
                            aiCurrentPoints = 0;
                            playerPoints--;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    }
                }
            }
        }
    }
}
