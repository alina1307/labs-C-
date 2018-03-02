using System;

namespace Laba4
{
    class ArraySorting
    {
        int[] arr = new int[10];
        int left = -1, right = 9, temp = 0;

        public int[] InputArray()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            Console.Read();
            return arr;
        }

        public int Permutation(int[] arr, int b)
        {
            while (left != right)
            {
                if (arr[left + 1] <= b)
                    left = left + 1;
                else if (arr[right] >= b)
                    right = right - 1;
                else if (arr[left + 1] > b && arr[right] < b)
                {
                    temp = arr[left + 1];
                    arr[left + 1] = arr[right];
                    arr[right] = temp;
                    left = left + 1;
                    right = right - 1;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Read();
            return arr[9];
        }
    }
}
