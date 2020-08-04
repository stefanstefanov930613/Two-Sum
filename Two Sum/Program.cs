using System;
using System.Collections.Generic;
using System.Linq;

namespace Two_Sum
{
    class Program
    {
        private static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int keyNum = int.Parse(Console.ReadLine());

            numbers.Sort();

            int lhs = 0, rhs = numbers.Count - 1;

            while (lhs < rhs)
            {
                int sum = numbers[lhs] + numbers[rhs];

                if (sum == keyNum)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (sum < keyNum)
                {
                    lhs++;
                }
                else
                {
                    rhs--;
                }
            }











            //var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            //int keyNum = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    for (int j = i + 1; j < numbers.Count; j++)
            //    {
            //        if (numbers[i] + numbers[j] == keyNum)
            //        {

            //            Console.WriteLine("true");
            //            return;

            //        }


            //    }
            //}

        }

    }
}
