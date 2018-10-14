using Examples.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Enums
{
    public class Enums
    {
        public static void UseEnums()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach(var customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender Name = {1} - Gender Number = {2}", customer.Name, customer.Gender, (short)customer.Gender);
            }
        }
    }

    public enum Gender : short
    {
        Unknown = 1,
        Male = 2,
        Female = 3
    }
}
