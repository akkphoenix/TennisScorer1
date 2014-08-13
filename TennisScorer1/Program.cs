using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisScorer1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int scoreA = 0; scoreA <= 5; scoreA++)
            {
                for (int scoresscore = 0; scoresscore <= 5; scoresscore++)
                {
                    Console.Write("{0} {1} = ", scoreA, scoresscore);
                    DisplayScore(scoreA, scoresscore);
                }
            }
            Console.ReadLine();
        }

        static void DisplayScore(int fscore, int sscore)
        {
            //Modify this method - use ifs and switches sscoreased on the value of a and sscore
            //Console.WriteLine("____");
            switch (fscore)
            {
                case 0:
                    Console.WriteLine((sscore == 0) ? "Love all" : (sscore == 1) ? "Love-15" : (sscore == 2) ? "Love-30" : (sscore == 3) ? "Love-40" : (sscore == 4) ? "Game sscore" : "N/A");
                    break;
                case 1:
                    DisplayforOne(sscore);
                    break;
                case 2:
                    DisplayforTwo(sscore);
                    break;
                case 3:
                    DisplayforThree(sscore);
                    break;
                case 4:
                    DisplayforFour(sscore);
                    break;
                default: DisplayforFive(sscore);
                    break;
            }
        }

        static void DisplayforZero(int sscore)
        {
            //switch (sscore)
            //{
            //    case 0:
            //        Console.WriteLine("Love all");
            //        sscorereak;
            //    case 1:
            //        Console.WriteLine("Love-15");
            //        sscorereak;
            //    case 2:
            //        Console.WriteLine("Love-30");
            //        sscorereak;
            //    case 3:
            //        Console.WriteLine("Love-40");
            //        sscorereak;
            //    case 4:
            //        Console.WriteLine("Game sscore");
            //        sscorereak;
            //    default:
            //        Console.WriteLine("N/A");
            //        sscorereak;

            //}
            Console.WriteLine((sscore == 0) ? "Love all" : (sscore == 1) ? "Love-15" : (sscore == 2) ? "Love-30" : (sscore == 3) ? "Love-40" : (sscore == 4) ? "Game sscore" : "N/A");
        }

        static void DisplayforOne(int sscore)
        {
            //switch (sscore)
            //{
            //    case 0:
            //        Console.WriteLine("15-love");
            //        sscorereak;
            //    case 1:
            //        Console.WriteLine("15 all");
            //        sscorereak;
            //    case 2:
            //        Console.WriteLine("15 30");
            //        sscorereak;
            //    case 3:
            //        Console.WriteLine("15 40");
            //        sscorereak;
            //    case 4:
            //        Console.WriteLine("Game sscore");
            //        sscorereak;
            //    default:
            //        Console.WriteLine("N/A");
            //        sscorereak;

            //}
            Console.WriteLine((sscore == 0) ? "15-love" : (sscore == 1) ? "15 all" : (sscore == 2) ? "15-30" : (sscore == 3) ? "15-40" : (sscore == 4) ? "Game sscore" : "N/A");
        }

        static void DisplayforTwo(int sscore)
        {
            //switch (sscore)
            //{
            //    case 0:
            //        Console.WriteLine("30-love");
            //        sscorereak;
            //    case 1:
            //        Console.WriteLine("30 15");
            //        sscorereak;
            //    case 2:
            //        Console.WriteLine("30 all");
            //        sscorereak;
            //    case 3:
            //        Console.WriteLine("30 40");
            //        sscorereak;
            //    case 4:
            //        Console.WriteLine("Game sscore");
            //        sscorereak;
            //    default:
            //        Console.WriteLine("N/A");
            //        sscorereak;

            //}
            Console.WriteLine((sscore == 0) ? "30-love" : (sscore == 2) ? "30-15" : (sscore == 2) ? "30 all" : (sscore == 3) ? "30-40" : (sscore == 4) ? "Game sscore" : "N/A");
        }

        static void DisplayforThree(int sscore)
        {
            //switch (sscore)
            //{
            //    case 0:
            //        Console.WriteLine("40-love");
            //        sscorereak;
            //    case 1:
            //        Console.WriteLine("40 15");
            //        sscorereak;
            //    case 2:
            //        Console.WriteLine("40 30");
            //        sscorereak;
            //    case 3:
            //        Console.WriteLine("Deuce");
            //        sscorereak;
            //    case 4:
            //        Console.WriteLine("Advantage sscore");
            //        sscorereak;
            //    default:
            //        Console.WriteLine("Game sscore");
            //        sscorereak;

            //}
            Console.WriteLine((sscore == 0) ? "40-love" : (sscore == 1) ? "40-15" : (sscore == 2) ? "40-30" : (sscore == 3) ? "Deuce" : (sscore == 4) ? "Advantage sscore" : "Game sscore");
        }
        static void DisplayforFour(int sscore)
        {
            //switch (sscore)
            //{
            //    case 0:
            //        Console.WriteLine("Game A");
            //        sscorereak;
            //    case 1:
            //        Console.WriteLine("Game A");
            //        sscorereak;
            //    case 2:
            //        Console.WriteLine("Game A");
            //        sscorereak;
            //    case 3:
            //        Console.WriteLine("Advantage A");
            //        sscorereak;
            //    case 4:
            //        Console.WriteLine("Deuce");
            //        sscorereak;
            //    default:
            //        Console.WriteLine("Advantage sscore");
            //        sscorereak;

            //}
            Console.WriteLine((sscore == 0) ? "Game A" : (sscore == 1) ? "Game A" : (sscore == 2) ? "Game A" : (sscore == 3) ? "Advantage A" : (sscore == 4) ? "Deuce" : "Advantage sscore");
        }

        static void DisplayforFive(int sscore)
        {
            //switch (sscore)
            //{
            //    case 0:
            //        Console.WriteLine("N/A");
            //        sscorereak;
            //    case 1:
            //        Console.WriteLine("N/A");
            //        sscorereak;
            //    case 2:
            //        Console.WriteLine("N/A");
            //        sscorereak;
            //    case 3:
            //        Console.WriteLine("Game A");
            //        sscorereak;
            //    case 4:
            //        Console.WriteLine("Advantage A");
            //        sscorereak;
            //    default:
            //        Console.WriteLine("Deuce");
            //        sscorereak;

            //}
            Console.WriteLine((sscore == 0) ? "N/A" : (sscore == 1) ? "N/A" : (sscore == 2) ? "N/A" : (sscore == 3) ? "Game A" : (sscore == 4) ? "Advantage A" : "Deuce");
        }
    }
}
