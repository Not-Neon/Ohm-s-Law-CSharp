using System;
using System.Linq;


namespace Ohms_Law
{
    class program
    {
        static void PD()
        {
            Console.WriteLine("\nCalculating Potential Difference...");
            Console.WriteLine("\nPlease enter the Current (In ampere) >> ");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the Resistance (in Ohm) >> ");
            double r = Convert.ToDouble(Console.ReadLine());
            double v = i * r;
            Console.WriteLine($"\nVoltage = {v} V - Volt");
        }

        static void Resistance()
        {
            Console.WriteLine("\nCalculating Resistance...");
            Console.Write("\nPlease enter the PD (Voltage across the cell) >> ");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the Current (in Ampere) >> ");
            double i = Convert.ToDouble(Console.ReadLine());
            double r = v / i;
            Console.WriteLine($"\nResistance = {r} Ω - Ohm");
        }
        static void Current()
        {
            Console.WriteLine("\nCalculating Current...");
            Console.Write("\nPlease enter the PD (Voltage across the cell) >> ");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the Resistance (in Ohm) >> ");
            double r = Convert.ToDouble(Console.ReadLine());
            double i = v / r;
            Console.WriteLine($"\nCurrent = {i} A - Ampere");
        }
        static void Main(string[] args)
        {
            Console.Title = "C# Ohm's Law";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("[1] Calculate Potential Difference (Voltage, Volt)");
            Console.WriteLine("[2] Calculate Resistance (Ohm)");
            Console.WriteLine("[3] Calculate Current (Ampere)");
            Console.Write(">>> ");

            int input_int = Convert.ToInt32(Console.ReadLine());

            if (input_int == 1)
            {
                PD();
            }
            else if (input_int == 2)
            {
                Resistance();
            }
            else if (input_int == 3)
            {
                Current();
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }
        }
    }
}