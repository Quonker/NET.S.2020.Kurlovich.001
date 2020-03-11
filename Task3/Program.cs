using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            // ***** QSort *****
            Console.WriteLine("\tQSort tests:");
            Random rand = new Random();
            Console.WriteLine("*int:");
            int[] arrI = new int[10];

            for (int i = 0; i < arrI.Length; ++i)
            {
                arrI[i] = rand.Next(-5, 10);
            }

            SvSort.PrintArray(arrI);
            SvSort.QSort(arrI);
            SvSort.PrintArray(arrI);
            Console.WriteLine("*double");
            double[] arrD = new double[7];

            for (int i = 0; i < arrD.Length; ++i)
            {
                arrD[i] = rand.NextDouble();
                arrD[i] = Math.Round(arrD[i], 4);
            }

            SvSort.PrintArray(arrD);
            SvSort.QSort(arrD);
            SvSort.PrintArray(arrD);

            Console.WriteLine("*char");
            char[] arrC = new char[10];

            for (int i = 0; i < arrC.Length; ++i)
            {
                arrC[i] = Convert.ToChar(rand.Next(Convert.ToInt32('a'), Convert.ToInt32('z') + 1));
            }

            SvSort.PrintArray(arrC);
            SvSort.QSort(arrC);
            SvSort.PrintArray(arrC);

            //***** Merge Sort *****
            Console.WriteLine("\n\tMerge Sort tests:");

            Console.WriteLine("*int:");
            arrI = new int[10];

            for (int i = 0; i < arrI.Length; ++i)
            {
                arrI[i] = rand.Next(-5, 10);
            }

            SvSort.PrintArray(arrI);
            SvSort.MergeSort(arrI);
            SvSort.PrintArray(arrI);
            Console.WriteLine("*double");
            arrD = new double[7];

            for (int i = 0; i < arrD.Length; ++i)
            {
                arrD[i] = rand.NextDouble();
                arrD[i] = Math.Round(arrD[i], 4);
            }

            SvSort.PrintArray(arrD);
            SvSort.MergeSort(arrD);
            SvSort.PrintArray(arrD);

            Console.WriteLine("*char");
            arrC = new char[10];

            for (int i = 0; i < arrC.Length; ++i)
            {
                arrC[i] = Convert.ToChar(rand.Next(Convert.ToInt32('a'), Convert.ToInt32('z') + 1));
            }

            SvSort.PrintArray(arrC);
            SvSort.MergeSort(arrC);
            SvSort.PrintArray(arrC);
        }
    }
}
