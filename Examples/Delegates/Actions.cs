using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Delegates
{
    //Action doesn't have a return type
    public class Actions
    {
        public static void UseActions()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            var secondNumer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select one: add, subtract, multiply");
            var operation = Console.ReadLine();

            Action<int, int> calculation = null;

            switch (operation)
            {
                case "add":
                    calculation = (x, y) => Console.WriteLine(x + y);
                    break;
                case "subtract":
                    calculation = (x, y) => Console.WriteLine(x - y);
                    break;
                case "multiply":
                    calculation = (x, y) => Console.WriteLine(x * y);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            ProcessData(firstNumber, secondNumer, calculation);
        }

        public static void ProcessData(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed!");
            Console.ReadLine();
        }
    }
}
