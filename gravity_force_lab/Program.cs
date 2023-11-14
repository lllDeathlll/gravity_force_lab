using System;

namespace gravity_force_lab
{
    class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Gravitational Force Calculator");

                // Gets variables and if it is empty gives it null value
                Console.Write("Enter value of m1: ");
                double m1 = get_double();

                Console.Write("Enter value of m2: ");
                double m2 = get_double();

                Console.Write("Enter value of r: ");
                double r = get_double();

                // Calculates gravity force
                double f = GravityForce.calc_gravity_force(m1, m2, r);

                // Prints result
                Console.WriteLine($"Gravity force is equal to: {f}\n");
            }
        }

        /// <summary>
        /// Gets user input and converts it to double. On exception, prints it and returns 0.0.
        /// </summary>
        /// <returns></returns>
        public static double get_double()
        {
            try {
                double variable = Convert.ToDouble(Console.ReadLine());
                return variable;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 0.0;
            }
        }
    }
}