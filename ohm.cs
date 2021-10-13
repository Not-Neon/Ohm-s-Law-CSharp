using System;


namespace Ohms_Law
{
    class program
    {
        static void PD()
        {
            Console.WriteLine("\nCalculating Potential Difference...");
            Console.WriteLine("\nPlease enter the Current (In ampere) >> ");
            string i_input = Console.ReadLine();
            double i;
            Double.TryParse(i_input, out i);
            Console.Write("Please enter the Resistance (in Ohm) >> ");
            string r_input = Console.ReadLine();
            double r;
            Double.TryParse(r_input, out r);
            double v = i * r;
            Console.WriteLine($"\nVoltage = {v} V - Volt");
        }

        static void Resistance()
        {
            Console.WriteLine("\nCalculating Resistance...");
            Console.Write("\nPlease enter the PD (Voltage across the cell) >> ");
            string v_input = Console.ReadLine();
            double v;
            Double.TryParse(v_input, out v);
            Console.Write("Please enter the Current (in Ampere) >> ");
            string i_input = Console.ReadLine();
            double i;
            Double.TryParse(i_input, out i);
            double r = v / i;
            Console.WriteLine($"\nResistance = {r} Ω - Ohm");
        }
        static void Current()
        {
            Console.WriteLine("\nCalculating Current...");
            Console.Write("\nPlease enter the PD (Voltage across the cell) >> ");
            string v_input = Console.ReadLine();
            double v;
            Double.TryParse(v_input, out v);
            Console.Write("Please enter the Resistance (in Ohm) >> ");
            string r_input = Console.ReadLine();
            double r;
            Double.TryParse(r_input, out r);
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
            Console.Write(">> ");

            string input = Console.ReadLine();
            int input_int;
            Int32.TryParse(input, out input_int);

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