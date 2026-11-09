using System;
namespace _SanaVaqt
{
    class Program
    {
        static void Main (string[] args)
        {   
            //Creating DateTime Objects
            var someDate =  new DateTime(2027,09,21);
            Console.WriteLine("someDate "+someDate);


            // Current Date and UTC time
            var currentTime =  DateTime.Now;
            var currentUtcTime =  DateTime.UtcNow;

            Console.WriteLine("\nCurrent Time "+currentTime);
            Console.WriteLine("Current UTC time " +currentUtcTime);
            
            // Time Zone Conversion
            var convertedTime = TimeZoneInfo.ConvertTimeToUtc(currentTime);
            Console.WriteLine("\nConvertedTimeToUTC "+convertedTime);

            // Formatting Dates
            var currentTimeString = DateTime.Now.ToString("\ndd-MM-yyyy");
            Console.WriteLine(currentTimeString);
            currentTimeString = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            Console.WriteLine(currentTimeString);

            // Comparing Dates
            var compareDateTimeEarly = DateTime.Compare(currentTime,convertedTime);
            Console.WriteLine("\nCompareEarly "+compareDateTimeEarly);

            var compareDateTimeLater = DateTime.Compare(convertedTime,currentTime);
            Console.WriteLine("CompareLater "+compareDateTimeLater);

            //Adding and Subtracting time
            var threeYearsFromNow = currentTime.AddYears(3);
            Console.WriteLine("\nThree Years from now "+threeYearsFromNow);
            var threeYearsAgo = currentTime.AddYears(-3);
            Console.WriteLine("Three Years ago "+threeYearsAgo);

            //Parsing strings to dates
            var dateStringWithSlashes = "11/09/2026";
            var dateTimeStringWithSlashes = "11/09/2026 12:13:34";
            var fullDateTimeString = "Monday , 9 November 2026 09:53:21";

            var parsedDateStringWithSlashes = DateTime.Parse(dateStringWithSlashes);
            Console.WriteLine("\nParsed1 - "+parsedDateStringWithSlashes);
            var parsedDateTimeStringWithSlashes = DateTime.Parse(dateTimeStringWithSlashes);
            Console.WriteLine("Parsed2 - "+parsedDateTimeStringWithSlashes);
            var parsedFullDateTimeString = DateTime.Parse(fullDateTimeString);
            Console.WriteLine("Parsed3 -  "+parsedFullDateTimeString);

            // TryParsing

            var DateTimeResult = new DateTime();
            var dateStringWithSlash = "11/9mm/2000";
            var result = DateTime.TryParse(dateStringWithSlash, out DateTimeResult);

            if (result)
            {
                Console.WriteLine(DateTimeResult);

            }
            else
            {
                Console.WriteLine("String xato");
            }

        }


    }
}