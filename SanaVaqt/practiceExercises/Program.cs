using System;
using System.Net.Http.Headers;
namespace practiceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1 
            DateTime currentTime =  DateTime.Now;
            Console.WriteLine(currentTime.ToString("MMMM dd, yyyy"));
            Console.WriteLine(currentTime.ToString("hh:mm:ss"));

            // task2
            Console.Write("Vaqt kiriting(hh:mm:ss)");
            string input = Console.ReadLine();


            string result = FindDiffirence(input);

            Console.WriteLine($"Siz kiritgan vaqt bilan hozirgi vaqt farqi {result}");
        
        }

        static string FindDiffirence (string userGivenTime)
        {
            if(!TimeSpan.TryParse(userGivenTime, out TimeSpan time))
            {
                return "Notogri Format";
            }

            TimeSpan now  = DateTime.Now.TimeOfDay;
            TimeSpan diff = (time - now).Duration();
            return diff.ToString(@"hh\:mm\:ss");

            
        }
    }
}