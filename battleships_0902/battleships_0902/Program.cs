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
        //Function for generating random ints
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

            //Fill grids with empty space
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

        //For printing the grid to screen
        static void writeGrid()
        {
            for (int y = 0; y < yMaxVal; y++)
            {
                for (int x = 0; x < xMaxVal; x++)
                {
                    if(gridHit[x,y]) //If a hit has been detected here write a X
                    {
                        Console.Write(" X ");
                    }
                        
                    else
                    {
                         Console.Write(" ~ "); //For the empty space write ~
                    }                     
                }

                Console.WriteLine();
            }
        }

        //For sinking ships
        static void sinkShip()
        {
            //Ask for cords
            Console.Write("\n\nEnter the X coordinate: ");
            int xCord = int.Parse(Console.ReadLine()) - 1;
            Console.Write("\nEnter the Y coordinate: ");
            int yCord = int.Parse(Console.ReadLine()) - 1;
            //Check that xCord is a valid value, else type new value
            if(xCord < 0 || xCord > (xMaxVal - 1))
            {
                Console.Write("\n\nError! Enter the X coordinate (A number between 1-" + yMaxVal + "): ");
                xCord = int.Parse(Console.ReadLine()) - 1;
            }
            //Check that yCord is a valid value, else type new value
            if (yCord < 0 || yCord > (yMaxVal - 1))
            {
                Console.Write("\n\nError! Enter the Y coordinate (A number between 1-" + yMaxVal + "): ");
                yCord = int.Parse(Console.ReadLine()) - 1;
            }
            //Checks for hit
            if (gridAI[xCord, yCord])
            {
                Console.WriteLine("\nHit!\n");
                gridAI[xCord, yCord] = false; //Destroys ship
                gridHit[xCord, yCord] = true; //Saves ships location in new array (for hit detection)

                hitCounter++; //Updates stats

                //Ends game
                if (hitCounter == boatSpawn) //Check so no ships remain
                {
                    gameSwitcher = false;
                    //Writes stats and endgame message
                    Console.WriteLine("You win!\n\nStats:\n" + "Total hits: " + hitCounter +
                    "\nTotal misses: " + missCounter);       
                }
            }
            else
            {
                Console.WriteLine("\nMiss!\n");
                missCounter++; //Stat update
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
        static int boatSpawn = randomNumber(rndNumbMin, rndNumbMax); //Number of boats spawned, varies
        static bool[,] gridAI = new bool[xMaxVal, yMaxVal];  //grid with active boats
        static bool[,] gridHit = new bool[xMaxVal, yMaxVal]; //grid for hit detection
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
