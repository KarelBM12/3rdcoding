using System.Collections;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace C__assign._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert:");
            Console.WriteLine("1 for seconds to minutes");
            Console.WriteLine("2 for minutes to hours");
            Console.WriteLine("3 for hours to days");
            Console.WriteLine("4 for days to months");

            string mode = Console.ReadLine();

            double value;
            double result;


            if (mode == "1")
            {
                Console.Write("Enter number of seconds: ");
                value = Convert.ToInt32(Console.ReadLine());
                result = value / 6;
                double minutes = value / 60;
                Console.WriteLine("= " + minutes + " minutes");
            }
            else if (mode == "2")
            {
                Console.Write("Enter number of minutes ");
                value = Convert.ToInt32(Console.ReadLine());
                result = value / 60;
                double hours = value / 60;
                Console.WriteLine("= " + hours + " hours");
            }
            else if (mode == "3")
            {
                Console.Write("Enter number of hours ");
                value = Convert.ToInt32(Console.ReadLine());
                result = value / 24;
                double days = value / 24;
                Console.WriteLine("= " + days + " days");
            }
            else if (mode == "4")
            {
                Console.Write("Enter number of days ");
                value = Convert.ToInt32(Console.ReadLine());
                result = value / 30;
                double months = value / 30;
                Console.WriteLine("= " + months + " months");
            }

            Console.ReadKey();
        }
    }
}

       




























