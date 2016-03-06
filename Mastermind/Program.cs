using System;
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

            Random rand = new Random();



            int answer = 0;
            int count = 0;

            while (answer != 5)
            {
                count += 1;
                answer = mastermind.Grade(new List<int>(new int[] { rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8), rand.Next(0, 8) }));
            }

            Console.WriteLine("Guesses: " + count);
        }
    }
}
