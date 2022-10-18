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
            
            // Двухмерные массивы
            // 
            //Задача 1

            int[,] array = new int[3, 4]
            {
                {2,0,7,8},
                {6,10,4,7},
                {8,6,2,1}
            };
            int maximum = array[0, 0], minimum = array[0, 0];
            int indexMaxI = 0, indexMaxJ = 0;
            int indexMinI = 0, indexMinJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
               for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maximum)
                 {
                        maximum = array[i, j];
                        indexMaxI = i;
                        indexMaxJ = j;
                    }
                    if (array[i, j] < minimum)
                    {
                        minimum = array[i, j];
                        indexMinI = i;
                        indexMinJ = j;
                    }
                }
            }
            Console.WriteLine($"Елемент з рядком  {indexMaxI} та стовпцем {indexMaxJ} є максимальним");
            Console.WriteLine($"Елемент з рядком  {indexMinI} та стовпцем {indexMinJ} є мiнiмальним");
            Console.ReadKey();
        }
    }
}
