using System;


namespace Ohms_Law
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Calculate Potential Difference (Voltage, Volt)");
            Console.WriteLine("[2] Calculate Resistance (Ohm)");
            Console.WriteLine("[3] Calculate Current (Ampere)");

            string input = Console.ReadLine();
            int input_int;
            Int32.TryParse(input, out input_int);

            if (input_int == 1)
            {
                Console.WriteLine("Calculating Potential Difference...");
                Console.WriteLine("Please enter the Current (In ampere) and the Resistance (in Ohm) in the respective order below.");
                string i_input = Console.ReadLine();
                decimal i;
                Decimal.TryParse(i_input, out i);
                string r_input = Console.ReadLine();
                decimal r;
                Decimal.TryParse(r_input, out r);
                decimal v = i * r;
                Console.WriteLine($"Voltage = {v} V - Volt");
            }
            else if (input_int == 2)
            {
                Console.WriteLine("Calculating Resistance...");
                Console.WriteLine("Please enter the PD (Voltage across the cell) and the Current (in Ampere) in the respective order below.");
                string v_input = Console.ReadLine();
                decimal v;
                Decimal.TryParse(v_input, out v);
                string i_input = Console.ReadLine();
                decimal i;
                Decimal.TryParse(i_input, out i);
                decimal r = v / i;
                Console.WriteLine($"Resistance = {r} Ω - Ohm");
            }
            else if (input_int == 3)
            {
                Console.WriteLine("Calculating Current...");
                Console.WriteLine("Please enter the PD (Voltage across the cell) and the Resistance (in Ohm) in the respective order below.");
                string v_input = Console.ReadLine();
                decimal v;
                Decimal.TryParse(v_input, out v);
                string r_input = Console.ReadLine();
                decimal r;
                Decimal.TryParse(r_input, out r);
                decimal i = v / r;
                Console.WriteLine($"Current = {i} A - Ampere");
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }
        }
    }
}
