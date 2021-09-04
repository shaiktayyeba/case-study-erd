//Write a program to print if the given day is a working day or holiday.  Accept a number representing the day from the user and apply below logic
//a.	The number should be >0 and <=7.  
//b.	If the number is b/n 1 to 5 it is a working day
//c.	If the number is >5 - holiday
//Hint: use enums
//Modify Q2 to so that it returns both the position and also the number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class weekdays2
    {
        enum week { sunday = 0, monday = 1, tuesday = 2, wednesday = 3, thursday = 4, friday = 5, saturday = 6 };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the weekday number:");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 0:
                    string s = Enum.GetName(typeof(week), 0);
                    Console.WriteLine(s + " " + " 0 holiday day");
                    break;
                case 1:
                    string s1 = Enum.GetName(typeof(week), 1);
                    Console.WriteLine(s1 + " " + " 1st Working day");
                    break;
                case 2:
                    string s2 = Enum.GetName(typeof(week), 2);
                    Console.WriteLine(s2 + " " + "2nd Working day");
                    break;
                case 3:
                    string s3 = Enum.GetName(typeof(week), 3);
                    Console.WriteLine(s3 + " " + "3rd Working day");
                    break;
                case 4:
                    string s4 = Enum.GetName(typeof(week), 4);
                    Console.WriteLine(s4 + " " + "4th Working day");
                    break;


                case 5:
                    string s5 = Enum.GetName(typeof(week), 5);
                    Console.WriteLine(s5 + " " + "5th working day");
                    break;
                case 6:
                    string s6 = Enum.GetName(typeof(week), 6);
                    Console.WriteLine(s6 + " " + "6 Holiday");
                    break;
                default:
                    Console.WriteLine("Enter Valid input");
                    break;

            }

        }
    }
}

