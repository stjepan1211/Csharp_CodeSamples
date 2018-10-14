using Examples.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Delegates
{
    /// <summary>
    /// Delegate is type safe function pointer
    /// access right + delegate + function signature + delegatename + (parameters)
    /// Example: public delegate void HelloFunctionDelegate(string Message);
    /// </summary>

    public class Delegates
    {
        public delegate void HelloFunctionDelegate(string Message);
        public delegate bool IsPromotable(Employee empl);
        public delegate void SampleDelegate();

        public static void UseDelegates()
        {
            #region Basic example
            HelloFunctionDelegate myDelegate = new HelloFunctionDelegate(Hello);
            myDelegate("Helo from delegate");
            #endregion

            #region Example with delegate in for each loop
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(empList, isPromotable);
            Employee.PromoteEmployee(empList, x => x.Experience >= 5);
            #endregion

            #region Multicast delegates
            //delegates which points on more than one function
            SampleDelegate del1, del2, del3, del4;

            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3 - del2;
            del4();
            #endregion

            #region Multicast delegates example 2
            //delegates which points on more than one function
            SampleDelegate del = new SampleDelegate(SampleMethodOne);

            del += SampleMethodTwo;
            del += SampleMethodThree;
            del += SampleMethodFour;
            del();
            #endregion

        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("{0} invoked", System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("{0} invoked", System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("{0} invoked", System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public static void SampleMethodFour()
        {
            Console.WriteLine("{0} invoked", System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
