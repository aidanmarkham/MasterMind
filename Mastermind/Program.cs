﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {

        static void Main(string[] args)
        {
            Mastermind mastermind = new Mastermind();
            mastermind.Initialize();

            Random rand = new Random(0);



            int answer;
            int count;
            List<int> guesses = new List<int>();
            while (true)
            {
                answer = 0;
                count = 0;
                while (answer != 5)
                {
                    count += 1;

                    List<int> guess = new List<int>(new int[] { rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8) });
                    answer = mastermind.Grade(guess);
                }
                guesses.Add(count);
                Console.WriteLine(guesses.Average());
            }
            Console.WriteLine("Guesses: " + count);
        }
    }
}
