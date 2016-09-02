using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_0902
{
    class Program
    {
        static int randomNumber(int minVal, int maxVal)
        {
            Random random = new Random();
            int rndNum = random.Next(minVal, maxVal);
            return rndNum;
        }

        static void Main(string[] args)
        {

            int boatSpawn = randomNumber(4, 6);
            
            //BROKEN DO NOT USE!!!
            int[,] boat = new int[boatSpawn, boatSpawn];
            int[] boatX = new int[boatSpawn];
            int[] boatY = new int[boatSpawn];
            Console.WriteLine("X:\tY:");
            for (int i = 0; i < boatSpawn; i++)
            {
                boatX[i] = randomNumber(0, 7);
                System.Threading.Thread.Sleep(1000);
                boatY[i] = randomNumber(0, 5);
                Console.Write(boatX[i] + "\t");
                Console.WriteLine(boatY[i]);
            }

            bool[,] gridPlayer = new bool[7, 5];

            //Fill grid with empty space
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    gridPlayer[x, y] = false;
                }
            }

            //Placera ut några båtar på spelplanen
            for (int j = 0; j < boatSpawn; j++)
            {
                gridPlayer[boatX[j], boatY[j]] = true;
            }

            //Vi testar att skriva ut hela spelplanen
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string p;
                    if (gridPlayer[x, y] == true)
                    {
                        p = " X ";
                    }
                    else
                    {
                        p = " O ";
                    }
                    //Console.Write(GameMap[x, y]); 
                    Console.Write(p);
                }
                Console.WriteLine();
            }












        }
    }
}
