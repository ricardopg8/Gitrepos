﻿using System;

namespace Matrizes_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Matrizes são bidimencionais:

            int M, N;
            int[,] A;

            string[] s1 = Console.ReadLine().Split(' ');
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);
            A = new int[M, N];

            for (int i=0; i<M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.ReadLine();
        }
    }
}
