//Write a program to print if the given day is a working day or holiday.  Accept a number representing the day from the user and apply below logic
//a.	The number should be >0 and <=7.  
//b.	If the number is b/n 1 to 5 it is a working day
//c.	If the number is >5 - holiday
//Hint: use enums 


using System;

namespace weekdays.cs
{
    class Program
    {
        static void Main()
        {
            int dayno = int.Parse(Console.ReadLine());
            switch (dayno)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Working day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine($"Holiday");
                    break;
                default:
                    Console.WriteLine($"enter valid day number");
                    break;
            }
        }
    }
}