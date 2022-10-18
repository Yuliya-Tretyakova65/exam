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
            

            const int row = 3;
            const int column = 4;
            int[,] array = new int[row, column]
            {
                        {2,0,7,8},
                        {6,10,4,7},
                        {8,6,2,1}
            };
            int[,] array2 = new int[row, column]
            {
                        {8,4,2,3},
                       {2,4,3,7},
                        {0,2,7,3}
            };
            int[,] newArray = new int[row, column];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    newArray[i, j] = array[i, j] + array2[i, j];
                    Console.Write(newArray[i,j]+"\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();


            
        }



    }








}   




