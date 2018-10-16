using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Delegates
{
    //Func always has a return type
    public class Funcs
    {
        public static void UseFuncs()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            var secondNumer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select one: add, subtract, multiply");
            var operation = Console.ReadLine();

            Func<int, int, int> calculation = null;

            switch (operation)
            {
                case "add":
                    calculation = (x, y) => x + y;
                    break;
                case "subtract":
                    calculation = (x, y) => x - y;
                    break;
                case "multiply":
                    calculation = (x, y) => x * y;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            ProcessData(firstNumber, secondNumer, calculation);
        }

        public static void ProcessData(int x, int y, Func<int, int, int> func)
        {
            var result = func(x, y);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
