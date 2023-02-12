using CSharpTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2021, 4, 21);
            int count = -5;
            WeekEnd[] weekends = new WeekEnd[1]
            {
                new WeekEnd(new DateTime(2021, 4, 23), new DateTime(2021, 4, 23))
            };

            DateTime result = new WorkDayCalculator().Calculate(startDate, count, weekends);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
