using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQuestions
{
    internal class GreedyAlgo
    {
        void Main(string[] args)
        {
            int[] stockPrice = [10, 7, 5, 8, 11, 9];
            // Brute Force
            //int max = 0;
            //for (int i = 0; i < stockPrice.Length; i++)
            //{
            //    for(int j = i + 1; j < stockPrice.Length; j++)
            //    {
            //        if (stockPrice[i] < stockPrice[j])
            //        {
            //            max = Math.Max(max, stockPrice[j] - stockPrice[i]);
            //        }
            //    }
            //}
            //Console.WriteLine(max);

            // Greedy Method
            if (stockPrice.Length < 2)
            {
                Console.WriteLine("invalid input");
                return;
            }

            int minPrice = stockPrice[0], maxProfit = stockPrice[1] - stockPrice[0];
            for (int i = 1; i < stockPrice.Length; i++)
            {
                var currentPrice = stockPrice[i];
                maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
                minPrice = Math.Min(minPrice, currentPrice);
            }
            Console.WriteLine(maxProfit);
            return;
        }
    }
}
