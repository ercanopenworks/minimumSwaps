using System;

namespace MinimumSwaps2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

        }

        static int minimumSwaps(int[] arr)
        {

            //O(n + n)
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                while (arr[i] != i + 1)
                {
                    var temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                    count++;
                }
            }

            return count;
        }
    }
}
