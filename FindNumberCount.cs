using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForInterview
{
    class FindNumberCount
    {
        public static void FindNum(string[] args)
        {
            try
            {

                int n;
                int countOfNum;
                Console.WriteLine("To Calculate Number 7 occurrency");
                Console.WriteLine("--------------------------------\n");
                Console.WriteLine("Please enter a N Number");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 100)
                {
                    Console.WriteLine("Please enter number within 100");
                    countOfNum = FindNumOccurrence(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {
                    countOfNum = FindNumOccurrence(n);
                }
                Console.WriteLine("Total number");
                Console.WriteLine("------------");
                Console.WriteLine(countOfNum.ToString());
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
            }

        }

        /// <summary>
        /// This method is used to find occurrence of 7 from the N numbers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FindNumOccurrence(int n)
        {
            int[] numList = new int[100];
            int numOccurs = 0;
            for (int i = 0; i < n; i++)
            {
                numList[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var i in numList)
            {
                if (i == 7)
                {
                    numOccurs++;
                }

            }
            return numOccurs;
        }

    }
}
