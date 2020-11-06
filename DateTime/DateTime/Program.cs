using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DateTimeX
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d = DateTime.Now;
            //Console.WriteLine(d);

            // Create a DateTime (year, month, day, hour, minute, second).
            //DateTime aDateTime = new DateTime(2008, 11, 22, 12, 1, 10);
            //Console.WriteLine(aDateTime.Day);
            //Console.WriteLine(aDateTime.DayOfWeek);
            //Console.WriteLine(aDateTime.DayOfYear);

            // Enum {Monday, Tuesday,... Sunday}
            //DayOfWeek dayOfWeek = aDateTime.DayOfWeek;


            //Console.WriteLine("Day of Week:{0}", aDateTime.DayOfWeek);


            //Console.WriteLine("Day of Year: {0}", aDateTime.DayOfYear);


            //// Convert to Ticks (1 second= 10.000.000 Ticks)
            //Console.WriteLine("Tick:{0}", aDateTime.Ticks);

            //DateTime aDateTime = DateTime.Now;

            //Console.WriteLine("Now is " + aDateTime);

            // An Interval.
            // 1 hour + 1 minute
            //TimeSpan aInterval = new System.TimeSpan(0, 1, 1, 0, 0);

            //// Add an interval.
            //DateTime newTime = aDateTime.Add(aInterval);


            //Console.WriteLine("After add 1 hour, 1 minute: " + newTime);

            //// Subtract an interval.
            //newTime = aDateTime.Subtract(aInterval);

            //Console.WriteLine("After subtract 1 hour, 1 minute: " + newTime);


            //DateTime aDateTime = DateTime.Now;

            //Console.WriteLine("Now is " + aDateTime);

            //// Add one year.
            //DateTime newTime = aDateTime.AddYears(2);


            //Console.WriteLine("After add 1 year: " + newTime);

            //// Subtract 1 hour
            //newTime = aDateTime.AddHours(-1);

            //Console.WriteLine("After add -1 hour: " + newTime);

            DateTime aDateTime = new DateTime(2015, 12, 20, 11, 30, 50);

            // Date-time supported formats.
            string[] formattedStrings = aDateTime.GetDateTimeFormats();

            foreach (string format in formattedStrings)
            {
                Console.WriteLine(format);
            }
 
        }
    }
}
