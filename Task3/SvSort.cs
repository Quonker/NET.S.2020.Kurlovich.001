using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class SvSort
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach (var a in array)
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T t = b;
            b = a;
            a = t;
        }

        // ***** QSORT *****

        ///<summary>
        ///In the method, the last element is selected as a reference,
        ///and traversal is carried out from the beginning of the array.
        ///</summary>
        ///<param name="array">array for sort </param>
        ///<param name="minIndex">start index</param>
        ///<param name="maxIndex">end of block of array</param>
        ///<returns>returns the index of the reference element,
        ///which divides the array into elements smaller than the reference on the left,
        ///and elements larger than the reference on the right.</returns>

        static int Partition<T>(T[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if ((dynamic)array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        ///<summary>the method divides arrays into 2 blocks until the block size != 1
        ///</summary>
        ///<param name="array">array for sort </param>
        ///<param name="minIndex">start index</param>
        ///<param name="maxIndex">end of block of array</param>
        ///<returns>sort array</returns>

        static T[] QSort<T>(T[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivotIndex = Partition(array, minIndex, maxIndex);
            QSort(array, minIndex, pivotIndex - 1);
            QSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public static T[] QSort<T>(T[] array)
        {
            return QSort(array, 0, array.Length - 1);
        }

        // ***** Merge Sort *****

        ///<summary> Each of the blocks is sorted separately,
        ///repeated breaking is performed until block size != 1.
        ///</summary>
        ///<param name="array">array for sort </param>
        ///<param name="lowIndex">start index</param>
        ///<param name="middleIndex">element in the middle of the block</param>
        ///<param name="highIndex">end of block of array</param>
        static void Merge<T>(T[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int left = lowIndex;
            int right = middleIndex + 1;
            var tempArray = new T[highIndex - lowIndex + 1];
            int index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if ((dynamic)array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
        ///<summary> The input array is split into two parts of the same size.
        ///</summary>
        ///<param name="array">array for sort </param>
        ///<param name="lowIndex">start index</param>
        ///<param name="highIndex">end of block of array</param>

        static T[] MergeSort<T>(T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
            return array;
        }

        public static T[] MergeSort<T>(T[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }
    }
}
