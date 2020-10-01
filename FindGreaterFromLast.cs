using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInterview
{
    class FindGreaterFromLast
    {
        public static void GreaterNo(string[] args)
        {
            try
            {

                int n;
                List<int> greaterNoList;
                Console.WriteLine("Find greater numbers from last input");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Please enter a N Number");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 100)
                {
                    Console.WriteLine("Please enter number within 100");
                    greaterNoList = FindGreaterNumber(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {
                    greaterNoList = FindGreaterNumber(n);
                }
                Console.WriteLine("Greater numbers from last input");
                Console.WriteLine("-------------------------------");
                foreach (var bigNum in greaterNoList)
                {
                    Console.WriteLine(bigNum.ToString() + "\n");
                }

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
            }

        }
        /// <summary>
        /// This function is used to find the greatest numbers from the last input numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> FindGreaterNumber(int n)
        {
            List<int> greaterNoList = new List<int>();
            List<int> numList = new List<int>();
            int lastNum;
            for (int i = 0; i < n; i++)
            {
                numList.Add(Convert.ToInt32(Console.ReadLine()));

            }
            foreach (var i in numList)
            {
                lastNum = numList[n - 1];
                if (i > lastNum)
                {
                    greaterNoList.Add(i);
                }
            }
            return greaterNoList;

        }
    }
}
