using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter string");
                string String = Console.ReadLine();
                int Integer;
                if (int.TryParse(String, out Integer))
                {
                    Console.WriteLine("Print the Converted integer\n" + Integer);
                }
                else
                {
                    Console.WriteLine(" Converted failed,Invalid Input");
                }

                Console.WriteLine("Enter string1");
                string String1 = Console.ReadLine();
                double Double = Convert.ToDouble(String1);
                Console.WriteLine("Print the converted Double\n" + Double);

                Console.WriteLine("Enter a String");
                string String2 = Console.ReadLine();
                decimal Decimal = decimal.Parse(String2);
                Console.WriteLine("Print the converted Decimal\n" + Decimal);

                Console.WriteLine("Enter a String");
                string String3 = Console.ReadLine();

                int Integer1;

                if(int.TryParse(String3,out Integer1))
                {
                    Console.WriteLine("Print the converted Integer\n" + Integer1 * 5);
                }
                else
                {
                    Console.WriteLine("Converted failed,Invalid input");
                }


                Console.WriteLine("Enter a String");
                string String4 = Console.ReadLine();
                DateTime dateTime = Convert.ToDateTime(String4);
                dateTime = dateTime.AddMonths(-1);

                Console.WriteLine("Print the converted DateTime\n" + dateTime);

                Console.WriteLine("Enter a String");
                string String5 = Console.ReadLine();
                TimeSpan timeSpan = TimeSpan.Parse(String5);

                TimeSpan T1 = TimeSpan.FromHours(2);
                timeSpan = timeSpan.Add(T1);
                Console.WriteLine("Print the converted TimeSpan\n" + timeSpan);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
