﻿//Binary search algorithm

using System;


namespace Program

{
    class BinarySearch
    {
        static void Main()
        {
            int[] a = new int[100];
            Console.WriteLine("Enter Number of elements in  array");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter values of elements ");

            for (int i = 0; i < x; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter Search element");
            int x2 = int.Parse(Console.ReadLine());
            int low = 0;
            int high = x - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (x2 < a[mid])
                    high = mid - 1;
                else if (x2 > a[mid])
                    low = mid + 1;
                else if (x2 == a[mid])
                {

                    Console.WriteLine("Search successful");

                    Console.WriteLine("Element {0} found at location {1}\n", x2, mid + 1);
                    return;
                }
            }
            Console.WriteLine("Search unsuccessful");
        }
    }
}
