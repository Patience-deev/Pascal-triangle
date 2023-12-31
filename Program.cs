﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[8, 8];
            Console.WriteLine("Pascal Triangle : ");
            for (int i = 0; i < 6; i++)
            {
                for (int k = 6; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.ReadLine();
            }

        }
    }
}