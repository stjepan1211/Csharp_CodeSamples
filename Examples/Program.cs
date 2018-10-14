using Examples.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Delegates;
using Examples.Enums;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> examplesToExecute = new Dictionary<string, bool>();

            examplesToExecute = GetTypesToExecute();

            if(examplesToExecute.Keys.Contains(Constants.Delegates) && (examplesToExecute[Constants.Delegates] == true))
            {
               Delegates.Delegates.UseDelegates();
            }

            if (examplesToExecute.Keys.Contains(Constants.Enums) && (examplesToExecute[Constants.Enums] == true))
            {
                Enums.Enums.UseEnums();
            }

            if (examplesToExecute.Keys.Contains(Constants.Generics) && (examplesToExecute[Constants.Generics] == true))
            {
                Generics.Generics.UseGenerics();
            }

            Console.ReadLine();
            //eventovi - observe and subscribe
        }

        private static Dictionary<string, bool> GetTypesToExecute()
        {
            Dictionary<string, bool> examplesToExecute = new Dictionary<string, bool>();

            try
            {

                string execudeDelegatesCodeValue = ConfigurationManager.AppSettings[Constants.Delegates];
                string execudeEnumsCodeValue = ConfigurationManager.AppSettings[Constants.Enums];
                string execudeGenericsCodeValue = ConfigurationManager.AppSettings[Constants.Generics];

                bool execudeDelegatesCode;
                bool execudeEnumsCode;
                bool execudeGenericsCode;

                bool.TryParse(execudeDelegatesCodeValue, out execudeDelegatesCode);
                bool.TryParse(execudeEnumsCodeValue, out execudeEnumsCode);
                bool.TryParse(execudeGenericsCodeValue, out execudeGenericsCode);

                examplesToExecute.Add(Constants.Delegates, execudeDelegatesCode);
                examplesToExecute.Add(Constants.Enums, execudeEnumsCode);
                examplesToExecute.Add(Constants.Generics, execudeGenericsCode);

                return examplesToExecute;
            }
            catch (Exception ex)
            {
                return examplesToExecute;
            }
            
        }
    }
}
