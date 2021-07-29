using System;
using System.Collections.Generic;
using System.Text;

namespace LTI_Assignment_1
{
    class innings
    {
        internal void stats()
        {
            Random random = new Random();
            int totalRun5inn = 0;
            int zeros = 0, ones = 0, twos = 0, threes = 0, fours = 0, sixs = 0, fives = 0;
            for (int j = 0; j < 5; j++)
            {
                int totalRuns = 0;
                
                for (int i = 0; i < 30; i++)
                {
                    int run = random.Next(0, 7);
                    totalRuns = totalRuns + run;
                    if (run == 0)
                    {
                        zeros++;
                    }
                    else if (run == 1)
                    {
                        ones++;
                    }
                    else if (run == 2)
                    {
                        twos++;
                    }
                    else if (run == 3)
                    {
                        threes++;
                    }
                    else if (run == 4)
                    {
                        fours++;
                    }
                    else if (run == 6)
                    {
                        sixs++;
                    }
                    else
                    {
                        fives++;
                    }

                }
                totalRun5inn = totalRun5inn + totalRuns;
            }
            Console.WriteLine("Average score: {0}", (totalRun5inn / 5));
            Console.WriteLine("Total Runs Scored by Batsmen: {0}", totalRun5inn);

            Console.WriteLine("Number of 0's: {0} | Number of 1's: {1} | Number of 2's: {2} | Number of 3's: {3} |" +
                "Number of 4's: {4} | Number of 6's: {5}", zeros,ones,twos,threes,fours,sixs);
            Console.WriteLine("Strike Rate of the Batsmen: {0}", ((totalRun5inn / (30*5))*100));
        }
    }

    class question2
    {
        static void Main()
        {
            innings innings = new innings();
            innings.stats();
        }
    }
}
