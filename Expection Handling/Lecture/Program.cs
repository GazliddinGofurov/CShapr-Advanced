using System;

namespace _ExeptionHandlingLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a =  new double[10];

            double x,s = 0;
            Console.Write("x=");
            try{
            x =  double.Parse(Console.ReadLine()); for(int i = 0; i<=10; i++)
            {
                a[i] = double.Parse(Console.ReadLine()); if (x + i != 0) { s += a[i] / (x + i); } else throw new DivideByZeroException();
            }
            Console.WriteLine("s="+s);
            }
            catch (DivideByZeroException) 
            { 
                Console.WriteLine("Ifodani hisoblashda 0 ga bo'lish uchradi"); 
            } 
            catch (IndexOutOfRangeException) 
            { 
                Console.WriteLine("Massivning indeksi chegaradan tashqariga chiqdi"); 
            } 
            catch (SystemException ex) 
            { 
                Console.WriteLine("Xatolik:" + ex.Message +" yuz berdi"); 
            } 
            finally 
            { 
                Console.WriteLine("Dastur tugadi"); 
            } 
            Console.ReadLine(); 

           
        }
    }
}