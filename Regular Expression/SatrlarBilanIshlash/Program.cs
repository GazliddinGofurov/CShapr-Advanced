using System;
using System.Text.RegularExpressions;
namespace _SatrlarBilanIshlash
{
    class Program
    {
        static void Main (string[] args)
        {
            // string [] names  =  {" Abdulloh","abdulloh","Abdulloh2","Fazliddin","Fazliddin`1"};
            
            // foreach (string name in names)
            // {
            //     if (IsValidName(name))
            //     {
            //         Console.WriteLine($"{name} is Valid Name");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"{name} is not Valid Name");
            //     }
            // }

            string [] phoneNumbers =
            {
                    "+998901234567",
                    "998971234567",
                    "901234567",
                    "+998 (90) 123-45-67",
                    "+998 99 987 65 43",
                    "1234567",          // Xato: raqam kam
                    "+998123456789",    // Xato: mavjud bo'lmagan operator kodi (12)
                    "+9989012345678"    // Xato: raqam ko'p
            };
            foreach(string phNumber in phoneNumbers)
            {
                if (isValidNumber(phNumber))
                {
                    Console.WriteLine("Valid number - "+phNumber);
                }
                else
                {
                    Console.WriteLine("Invalid number - "+phNumber);
                }
            }

            
            
        }

        static bool IsValidName (string name)
        {
            string pattern = @"^[A-Z]{1}[a-z]+$";
            name =  name.Trim();

            return Regex.IsMatch(name,pattern);
        }

        static bool isValidNumber(string phNumber)
        {
            string pattern = @"^([0-9]{9}|([0-9]{2}-[0-9]{3}-[0-9]{4})|([0-9]{2}\s[0-9]{3}\s[0-9]{2}\s[0-9]{2}))$";
            string flexiblePattern = @"^(\+?998)?[\s\-]?\(?(20|33|50|55|71|77|78|88|90|91|93|94|95|97|98|99)\)?[\s\-]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}$";
                  

            Regex regex =  new Regex(flexiblePattern);
            Match  match = regex.Match(phNumber);

            return match.Success;
        }
    }
}