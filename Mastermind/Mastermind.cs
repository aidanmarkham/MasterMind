using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Mastermind
    {
        List<int> solution; // list to hold the solution code
        Random rand; // for randomly generating a solution
        List<int> testSolution;
        public Mastermind()
        {
            rand = new Random();
            solution = new List<int>();
        }
        public void Initialize()
        {
            for (int i = 0; i < 5; i++)
            {
                //solution[i] = rand.Next(0, 8);
                solution.Add(i);
            }
        }


        public int Grade(List<int> guess)
        {
            int colorMatch = 0;
            int fullMatch = 0;
            testSolution = new List<int>(solution);
            

            for (int i = 0; i < guess.Count; i++)
            {
                if (guess[i] == solution[i])
                {
                    fullMatch += 1;
                }
            }

            for (int i = 0; i < guess.Count; i++)
            {
                Predicate<int> matches = x => x == guess[i];
                
                if (testSolution.FindAll(matches).Count() > 0)
                {
                    colorMatch += 1;
                    testSolution[testSolution.IndexOf(guess[i])] = 10;
                }
            }

            

            return fullMatch;
        }
    }
}
