﻿using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arrayInteiros = new int [3];
            arrayInteiros [0] = 10;
            arrayInteiros [1] = 20;
            arrayInteiros [2] = 30;
            System.Console.WriteLine ("Percorrendo o array pelo for");
            for (int i = 0; i < arrayInteiros.Length; i++) 
            {

                     System.Console.WriteLine(arrayInteiros[i]);
            }       
        }
    }
}
