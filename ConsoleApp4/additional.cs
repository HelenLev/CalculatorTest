using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class additional
    {
        public static double Sum(double value1, double value2)
        { 
            return (value1 + value2); 
        }
        public static double Minus(double value1, double value2)
        {
            return (value1 - value2);
        }
        public static double Multiple(double value1, double value2)
        {
            return (value1 * value2);
        }
        public static double Division(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException("You can't division 0");
            }
            else
            {
                return (value1 / value2);
            }
            
        }
        public static double Square(double value)
            
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value less then 0");
            }
            else
            {
                return Math.Sqrt(value);
            }
            
        }

    }
}
