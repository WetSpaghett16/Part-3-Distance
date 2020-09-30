using System;

namespace Part_3_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double number3;
            double average;

            Console.WriteLine("Press Enter to fill out custom race results in Km");
            Console.ReadLine();

            Console.WriteLine("Declare your first distance: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Declare your second distance: ");
            number2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Declare your third distance: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            
            average =(number1 + number2 + number3) / 3;
           
            Console.WriteLine("Average is: " + average);
            Console.ReadLine();

        }
    }
}
