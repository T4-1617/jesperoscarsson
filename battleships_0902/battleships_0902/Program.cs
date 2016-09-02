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

        static void Main(string[] args)
        {
            //Decides how many AI boats to spawn
            int boatSpawn = randomNumber(4, 6);
            
            //Holds the X values for the spawned boats
            int[] boatX = new int[boatSpawn];
            //Holds the Y values for the spawned boats
            int[] boatY = new int[boatSpawn];
            //Keep for debug
            //Console.WriteLine("X:\tY:");
            //Loop for assigning random X & Y values
            for (int i = 0; i < boatSpawn; i++)
            {
                boatX[i] = randomNumber(0, 7);
                boatY[i] = randomNumber(0, 5);
                //Keep for debug
                //Console.Write(boatX[i] + "\t");
                //Console.WriteLine(boatY[i]);
            }


            //Grid for player
            bool[,] gridPlayer = new bool[7, 5];

            //Fill grid with empty space
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    gridPlayer[x, y] = false;
                }
            }

            //Places boats
            for (int j = 0; j < boatSpawn; j++)
            {
                gridPlayer[boatX[j], boatY[j]] = true;
            }

            //For writing the grid
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string p; //Used to print

                    if (gridPlayer[x, y] == true)
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
    }
}
