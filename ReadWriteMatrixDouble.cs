using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForInterview
{
    class ReadWriteMatrixDouble
    {

        public static void Main(string[] args)
        {
            try
            {

                int m, n;
                Console.Write("Enter Number Of Rows And Columns Of Matrix : \n");
                m = Convert.ToInt32(Console.ReadLine());
                if ((m < 0) || (m > 30))
                {
                    Console.WriteLine("Please enter a Row number between 1 to 30 ");
                    m = Convert.ToInt16(Console.ReadLine());
                }
                n = Convert.ToInt16(Console.ReadLine());
                if ((n < 0) || (n > 30))
                {
                    Console.WriteLine("Please enter a column number between 1 to 30 ");
                    n = Convert.ToInt16(Console.ReadLine());
                }
                ReadAndPrintMatrix(m, n);
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
            }

        }
        public static void ReadAndPrintMatrix(int rowNum, int columNum)
        {
            int[,] matrix = new int[30, 40];
            int i, j;
            Console.Write("\nEnter the Matrix : \n");

            for (i = 0; i < rowNum; i++)
            {
                for (j = 0; j < columNum; j++)
                {
                    matrix[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("\nPrint The Matrix : ");
            for (i = 0; i < rowNum; i++)
            {
                for (j = 0; j < columNum; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                for (j = 0; j < columNum; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
