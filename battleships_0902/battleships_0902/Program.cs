using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_0902
{
    class Program
    {

        static Random random = new Random();

        static int randomNumber(int minVal, int maxVal)
        {
            int rndNum = random.Next(minVal, maxVal);
            return rndNum;
        }
        
        //Function for setting AI boats
        static void setAIBoats(int boatSpawn, int[] boatX, int[] boatY, bool[,] gridAI)
        {
            //Loop for assigning random X & Y values
            for (int i = 0; i < boatSpawn; i++)
            {
                boatX[i] = randomNumber(0, 7);
                boatY[i] = randomNumber(0, 5);
            }

            //Fill grid with empty space
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    gridAI[x, y] = false;
                }
            }

            //Places boats
            for (int j = 0; j < boatSpawn; j++)
            {
                gridAI[boatX[j], boatY[j]] = true;
            }
        }
        
        //For writing the grid
        static void writeGrid(bool[,] gridAI)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string p; //Used to print

                    if (gridAI[x, y] == true)
                    {
                        p = " O ";
                    }
                    else
                    {
                        p = " ~ ";
                    }

                    Console.Write(p);
                }

                Console.WriteLine();
            }
        }

        //For sinking ships
        static void sinkShip(bool[,] gridAI, int hitCounter, int missCounter)
        {
            Console.Write("\n\nEnter the X coordinate: ");
            int xCord = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Y coordinate: ");
            int yCord = int.Parse(Console.ReadLine());

            if (gridAI[xCord, yCord] == true)
            {
                Console.WriteLine("\nHit!");
                gridAI[xCord, yCord] = false;
                hitCounter++;
            }

            else
            {
                Console.WriteLine("\nMiss!");
                missCounter++;
            }
        }

        static void Main(string[] args)
        {
            //START Vars
            //Vars for stats
            int missCounter = 0;
            int hitCounter = 0;

            //Decides how many AI boats to spawn
            int boatSpawn = randomNumber(4, 6);
            
            //Holds the X values for the spawned boats
            int[] boatX = new int[boatSpawn];
            //Holds the Y values for the spawned boats
            int[] boatY = new int[boatSpawn];

            //Grid for AI
            bool[,] gridAI = new bool[7, 5];
            //END Vars

            setAIBoats(boatSpawn, boatX, boatY, gridAI);
            writeGrid(gridAI);
            sinkShip(gridAI, hitCounter, missCounter);
        }
    }
}
