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
        static void setAIBoats()
        {
            //Loop for assigning random X & Y values
            for (int i = 0; i < boatSpawn; i++)
            {
                boatX[i] = randomNumber(0, xMaxVal);
                boatY[i] = randomNumber(0, yMaxVal);
            }

            //Fill grid with empty space
            for (int y = 0; y < yMaxVal; y++)
            {
                for (int x = 0; x < xMaxVal; x++)
                {
                    gridAI[x, y] = false;
                    gridHit[x, y] = false;
                }
            }

            //Places boats
            for (int j = 0; j < boatSpawn; j++)
            {
                gridAI[boatX[j], boatY[j]] = true;
            }
        }

        //For writing the grid
        static void writeGrid()
        {
            for (int y = 0; y < yMaxVal; y++)
            {
                for (int x = 0; x < xMaxVal; x++)
                {
                    if(gridHit[x,y])
                    {
                        Console.Write(" X ");
                    }
                        
                    else
                    {
                         Console.Write(" ~ ");
                    }                     
                }

                Console.WriteLine();
            }
        }

        //For sinking ships
        static void sinkShip()
        {
            Console.Write("\n\nEnter the X coordinate: ");
            int xCord = int.Parse(Console.ReadLine())-1;
            Console.Write("\nEnter the Y coordinate: ");
            int yCord = int.Parse(Console.ReadLine())-1;
            //Check that xCord is a valid value
            if(xCord < 0 || xCord > (xMaxVal-1))
            {
                Console.Write("\n\nError! Enter the X coordinate (A number between 1-" + yMaxVal + "): ");
                xCord = int.Parse(Console.ReadLine())-1;
            }
            //Check that yCord is a valid value
            if (yCord < 0 || yCord > (yMaxVal-1))
            {
                Console.Write("\n\nError! Enter the Y coordinate (A number between 1-" + yMaxVal + "): ");
                yCord = int.Parse(Console.ReadLine())-1;
            }

            if (gridAI[xCord, yCord] == true)
            {
                Console.WriteLine("\nHit!\n");
                gridAI[xCord, yCord] = false;
                gridHit[xCord, yCord] = true;

                hitCounter++;

                if (hitCounter == boatSpawn)
                {
                    gameSwitcher = false;
                    Console.WriteLine("You win!\n\nStats:\n" + "Total hits: " + hitCounter +
                    "\nTotal misses: " + missCounter);       
                }
            }
            else
            {
                Console.WriteLine("\nMiss!\n");
                missCounter++;
            }

        }

        //START Vars
        //Consts
        const int xMaxVal = 7;
        const int yMaxVal = 5;
        const int rndNumbMax = 6;
        const int rndNumbMin = 4;
        //End consts
        static bool gameSwitcher = true;
        static int hitCounter = 0;
        static int missCounter = 0;
        static int boatSpawn = randomNumber(rndNumbMin, rndNumbMax);
        static bool[,] gridAI = new bool[xMaxVal, yMaxVal];
        static bool[,] gridHit = new bool[xMaxVal, yMaxVal];
        //END Vars

        //Holds the X values for the spawned boats
        static int[] boatX = new int[boatSpawn];
        //Holds the Y values for the spawned boats
        static int[] boatY = new int[boatSpawn];

        static void Main(string[] args)
        {
            setAIBoats();

            //Game logic
            while (gameSwitcher == true)
            {
                writeGrid();
                sinkShip();
            }
        }
    }
}
