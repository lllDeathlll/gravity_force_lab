using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravity_force_lab
{
    public class GravityForce
    {
        /// <summary>
        /// Calculates the force of gravity using Newton's theory of gravity.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static double calc_gravity_force(double m1, double m2, double r)
        {
            double g = 6.67*Math.Pow(10, -11);

            // Returns gravity force value
            return g*(m1*m2)/Math.Pow(r, 2);
        }
    }
}