using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Generics
{
    public class Generics
    {
        public static void UseGenerics()
        {
            Console.WriteLine(Calculator<int>.AreEqual(10, 10));
            Console.WriteLine(Calculator.AreEqual<string>("Test", "Test"));
        }
    }

    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
