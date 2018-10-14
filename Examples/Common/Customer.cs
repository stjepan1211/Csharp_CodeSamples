using Examples.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Common
{
    // 0 - Unknown gender
    // 1 - Male
    // 2 - Female
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Gender + " " + (int)this.Gender;
        }

        public override bool Equals(object obj)
        {
           if (obj == null)
            {
                return false;
            }

           if (!(obj is Customer))
            {
                return false;
            }

            return this.Name == ((Customer)obj).Name & this.Gender == ((Customer)obj).Gender;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Gender.GetHashCode();
        }

    }
}
