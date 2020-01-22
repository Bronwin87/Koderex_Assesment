using System;
using System.Collections.Generic;
using System.Linq;

namespace Koderex_Ass
{
    class Program
    {
        static void Main()
        {
            main();
        }

        static void main()
        {
            //need to add a helper method that checks that the values entered is numerical
            //at this moment
            int denominationcount;
            Console.WriteLine("How many demonimations would you like? Please enter a integer value:");
            denominationcount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please enter each denomination and press enter until you have reached the total amount of denomiations which is : " + denominationcount.ToString());
            List<int> denoms = new List<int>();
            for (int x = 1; x <= denominationcount; x++)
            {
                string input = Console.ReadLine();
                denoms.Add(Convert.ToInt32(input));
            }
            denoms.Sort();
            denoms.Reverse();
            int[] coins = denoms.ToArray();           
            int amount, count, i;
            Console.Write("Enter the amount you want to change : ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================");
            for (i = 0; i < coins.Length; i++)
            {
                count = amount / coins[i];
                if (count != 0)
                    Console.WriteLine("Count of {0} cent(s) :{1}", coins[i], count);
                amount %= coins[i];
            }
            Console.ReadLine();
        }
    }

}
