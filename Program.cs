using System;


//Найти количество високосных лет на отрезке [a, b] не используя циклы.
namespace LeapYearBetweenXY
{
    class Program
    {
        // В России, например, григорианский календарь ввели только в 1918 году.
        // Год является високосным в двух случаях: либо он кратен 4, но при этом не кратен 100, либо кратен 400.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first year");
            var s = Console.ReadLine();
            var y1 = int.Parse(s);
            Console.WriteLine("Enter last year");
            s = Console.ReadLine();
            var y2 = int.Parse(s);
            var c = CountLeapYears(y1, y2);
            Console.WriteLine("Count leap years = {0}", c);

        }

        static int CountLeapYears(int y1, int y2)
        {
            //var leepYears = Enumerable.Range(startYear, endYear - startYear + 1)
            //                .Count(x => DateTime.IsLeapYear(x));
            System.Diagnostics.Debug.Assert(y1 < y2);
            var dt1 = new DateTime(y1, 1, 1);
            var dt2 = new DateTime(y2 + 1, 1, 1);
            var nonLeapDays = 365 * (dt2.Year - dt1.Year);
            var leapDays = (dt2 - dt1).Days - nonLeapDays;
            return leapDays;
        }
    }
}
