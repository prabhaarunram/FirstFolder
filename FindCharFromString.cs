using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace ForInterview
{
    class FindCharFromString
    {
        public static void FindChar(string[] args)
        {
            try
            {
                char findChar;
                int n, totNoOccurs;
                List<string> strList = new List<string>();
                Console.WriteLine("Find Character Occurrency");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please enter a Character");
                findChar = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Please enter a Number of string as number");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a strings");
                for (int i = 0; i < n; i++)
                {
                    strList.Add(Console.ReadLine());
                }
                totNoOccurs = FindTotNoOccurrency(strList, findChar);
                Console.WriteLine("\nOutPut");
                Console.WriteLine("---------");
                Console.WriteLine(totNoOccurs.ToString());
                Console.ReadLine();
            }
            catch (Exception )
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
            }
          
        }

        /// <summary>
        /// This method is used to count the total number of character occurred from  the string list
        /// </summary>
        /// <param name="strList"></param>
        /// <param name="findChar"></param>
        /// <returns></returns>
        public static int FindTotNoOccurrency(List<string> strList,char findChar)
        {
            int numOccurs=0;
            foreach(var str in strList)
            {
                if (str.ToLower().Contains(findChar.ToString().ToLower()))
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].ToString().ToLower() == findChar.ToString().ToLower())
                            numOccurs++;
                    }
                }
            }
            return numOccurs;
        }
    }
}
