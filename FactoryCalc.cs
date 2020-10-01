using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInterview
{
    class FactoryCalc
    {
        public static void FactoryCal(string[] args)
        {
            try
            {
                int x, f1Result, f2Result, f3Result, result;
                Console.WriteLine("Please enter a number");
                x = Convert.ToInt32(Console.ReadLine());
                if ((x < -1000) || (x > 1000))
                {
                    Console.WriteLine("Please enter a number between -1000 to 1000");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                //Call factory 1 method
                f1Result = CalCulateFactory1(x);

                //Send output to factory 2 method
                f2Result = CalCulateFactory2(f1Result);

                //Send output to factory 3 method
                f3Result = CalCulateFactory3(f2Result);

                //Send output to factory 2 method
                result = CalCulateFactory2(f3Result);

                //Send output to factory 1 method
                result = CalCulateFactory1(result);

                //Send output to factory 2 method
                result = CalCulateFactory2(result);

                //Send output to factory 3 method
                result = CalCulateFactory3(result);

                Console.WriteLine("OutPut");
                Console.WriteLine("-------");
                Console.WriteLine(result.ToString());
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
            }

        }

        /// <summary>
        /// This method is used to calculate factory 1 - (x^3-4x+17)%1000
        /// </summary>
        /// <param name="x"></param>
        public static int CalCulateFactory1(int x)
        {
            int f1Result;
            f1Result = (((x * x * x) - (4 * x) + 17) % 1000);
            return f1Result;
        }

        /// <summary>
        /// This method is used to calculate factory 2 - (-2x^2+5x-1)%1000
        /// </summary>
        /// <param name="x"></param>
        public static int CalCulateFactory2(int x)
        {
            int f2Result;
            f2Result = ((-2 * (x * x)) + (5 * x) - 1) % 1000;
            return f2Result;
        }

        /// <summary>
        /// This method is used to calculate factory 3 - (3x^2-7x+3)%1000
        /// </summary>
        /// <param name="x"></param>
        public static int CalCulateFactory3(int x)
        {
            int f3Result;
            f3Result = ((3 * (x * x)) - (7 * x) + 3) % 1000;
            return f3Result;
        }
    }
}
