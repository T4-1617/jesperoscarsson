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
            bool[,] gridPLayer = new bool[7,5];
            bool[,] gridAI = new bool[7, 5];

            int boatSpawn = randomNumber(3, 5);
        }
    }
}
