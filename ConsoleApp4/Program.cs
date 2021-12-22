using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string value1_str=Console.ReadLine();
            double value1;
            if (!double.TryParse(value1_str, out value1))
            {
                throw new ArgumentException("You must enter number");
            }
            //value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            //double value2 = Convert.ToDouble(Console.ReadLine());
            string value2_str=Console.ReadLine();
            double value2;
            if (!double.TryParse(value2_str, out value2))
            {
                throw new ArgumentException("You must enter number");
            }


            Console.WriteLine("Choose the ariphmetical sign");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(additional.Sum(value1, value2));
                    break;

                case "-":
                    Console.WriteLine(additional.Minus(value1, value2));
                    break;

                case "*":
                    Console.WriteLine(additional.Multiple(value1, value2));
                    break;

                case "/":
                    
                    Console.WriteLine(additional.Division(value1, value2));
                    break;

                case "^":
                    
                    Console.WriteLine(additional.Square(value1));
                    break;
                    default:
                    throw new Exception("You choose invalid option");

            }



        }
    }
}
