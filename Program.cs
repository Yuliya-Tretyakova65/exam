using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // задача 3
            const int row = 3;
            const int column = 3;
            int[,] array = new int[row, column]
            {
                        {2,0,7},
                        {6,10,4},
                        {8,6,2}
            };
            int[,] array2 = new int[row, column]
            {
                        {8,4,2},
                        {2,4,3},
                        {0,2,7}
            };
            int[,] newArray = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        newArray[i, j] += array[i, k] * array2[k, j];
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(newArray[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

            
        }



    }








}   




