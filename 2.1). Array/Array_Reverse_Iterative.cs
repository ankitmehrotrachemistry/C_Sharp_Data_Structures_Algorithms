using System;

namespace Array_Reverse_Iterative
{
    class Program
    {
        static void ReverseArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Original Array is : ");
            printArray(arr, 10);
            ReverseArray(arr, 0, 9);
            Console.WriteLine("Reversed Array is : ");
            printArray(arr, 10);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Original Array is :
1 2 3 4 5 6 7 8 9 10
Reversed Array is :
10 9 8 7 6 5 4 3 2 1
*/
