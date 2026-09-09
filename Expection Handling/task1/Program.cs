using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace _task1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.Write("Satir Kriting -");
            string str = null;
            //Console.ReadLine();
            try
            {
              
              Console.WriteLine($"Satir Uzunligi - {GetLengthOfString(str)} ");  
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            */

            Console.Write("Parol Kriting: ");
            string pin =  Console.ReadLine();
            try
            {
                if (ValidatePin(pin))
                {
                    Console.WriteLine("Parol To'gri Kritildi");
                }
                else
                {
                    Console.WriteLine("Qayta Urinib koring");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.ReadLine();
        }

        static bool ValidatePin(string pin)
        {
            if (string.IsNullOrWhiteSpace(pin))
            {
                throw new ArgumentException("Pin Kod Bo'sh Bolmasligi kerak!");
            }
            else if (pin.Length!=4)
            {
                throw new ArgumentException("PIN-kod uzunligi 4 ta belgidan iborat bo’lishi kerak!");
            }
            else if (!int.TryParse(pin ,out _))
            {
                throw new FormatException("PIN-kod faqat raqamlardan iborat bo’lishi kerak!");
            }

            return true;
        }

        static int GetLengthOfString(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("Kritilgan matn bosh bolmasligi kerak!");
            }

            return str.Length;
        }

        
    }
}