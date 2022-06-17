using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    public static class Array
    {
        public static void ArraysDemo()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a4 = { 1, 3, -2, 5, 10 };


            //for (int i = 0; i < a3.Length; i++)
            for (int i = 0; i <= a3.Length - 1; i++)
            {
                Console.WriteLine($"{a3[i]}");
            }
            Console.WriteLine();
            foreach (var item in a4)
            {
                Console.WriteLine($"{item}");
            }


            System.Array myArray = new int[5];
            Console.WriteLine();
        }

        public static void MultiDimArrays()
        {
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.WriteLine($"{r2[i, j]}");
                }
            }
        }
        public static void JaggedArraysDemo()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];
            Console.WriteLine("Enter the numbers for a jagged array");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                }
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    Console.Write("\0");
                }
                Console.WriteLine("");

            }
        }
    }
}
