using System;
namespace DateAndTime
{
    class Program
    {
        static void Main (string[] args)
        {
            //DateTime dateTime1 = new DateTime (2026,11,2,22,34,33);
           // Console.WriteLine(dateTime1.ToString());

            // Add 
            TimeSpan duration = new TimeSpan(30,0,0,0);
            DateTime dateTime2 = new DateTime(2026,10,27);

            dateTime2 = dateTime2.Add(duration);
            Console.WriteLine(dateTime2.ToString());

            dateTime2 = dateTime2.AddDays(-1);
            Console.WriteLine(dateTime2);

            // Parse
            string dateTimeStr = "2026 2 November ";
            DateTime time = DateTime.Parse(dateTimeStr);
            Console.WriteLine(time.ToString());

            //ToUniversalTime
            DateTime time1 = DateTime.Now;
            Console.WriteLine(time1.ToUniversalTime().ToString());

            // Coordinated UniversalTime
            // LocalTime
            Console.WriteLine("\nCoordinated UniversalTime && LocalTime");

            DateTime saveNow =  DateTime.Now;
            DateTime saveUtcNow = DateTime.UtcNow;

            Console.WriteLine(saveNow.ToString());
            Console.WriteLine(saveUtcNow.ToString());

            DateTime myDate1 = DateTime.SpecifyKind(saveUtcNow,DateTimeKind.Utc);
            Console.WriteLine(myDate1.ToString());


            // DateTime formatting
            Console.WriteLine("\nDateTime formatting");
            DateTime dtFormat = new DateTime(2026,11,2);
            Console.WriteLine(dtFormat.ToString("MM dd, yyy"));

            


        }
    }
}