using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _22PMbootcamp
{
    class BirthDayOfWeek
    {
        public static void DayBorn()
        {
            Console.WriteLine("Enter the year you were born");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("You entered {0}", year);
            }
            Console.WriteLine("Enter the number of the month you were born");
            if (!int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("You entered {0}", month);
            }
            Console.WriteLine("Enter the day of the month you were born");
            if (!int.TryParse(Console.ReadLine(), out int day))
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("You entered {0}", day);
            }
            DateTime birthday = new DateTime(year, month, day);
            Console.WriteLine("You were born on a {0}", birthday.DayOfWeek);
        }
    }
}
