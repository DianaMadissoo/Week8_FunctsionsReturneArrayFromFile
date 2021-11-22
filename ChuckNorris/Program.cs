﻿using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;
            randomJoke = GetRandomFromFile("chuck.txt");
            Console.WriteLine(randomJoke);
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\diana\Desktop\Programmeerimise alused\Samples\chuck.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElemet = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElemet;
        }
    }
}
