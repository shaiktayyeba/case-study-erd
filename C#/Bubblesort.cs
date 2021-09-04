//Bubble sort algorithm
    
using System;
namespace Program
{
    class BubbleSort
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[100];
            Console.WriteLine(" Enter Number of elements in array ?");
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the values of Array Elements : ");
            for (int i = 0; i < x; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            //Sorting the array
            for (int j = 0; j <= x - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= x - 2; i++)
                {

                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }

            Console.WriteLine("After Sorting Array :");
            for (int item = 0; item <= x - 1; item++)
            {
                Console.Write(intArray[item] + " ");
            }

        }
    }
}
