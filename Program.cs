using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of scores
            List<int> scores = new List<int>();
            scores.Add(4400);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);

            //Sort the scores lowest to highest
            scores.Sort();
            foreach (int number in scores)
            {
                Console.WriteLine(number);
            }

            //Sort the scores hightest to lowest
            scores.Reverse();
            foreach (int number in scores)
            {
                Console.WriteLine(number);
            }

            //Add a new score to the list
            scores.Add(2400);

            //Remove 4400 from the list
            scores.Remove(4400);
        }
    }
}
