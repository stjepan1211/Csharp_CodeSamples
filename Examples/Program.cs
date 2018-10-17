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

            if (examplesToExecute.Keys.Contains(Constants.Events) && (examplesToExecute[Constants.Events] == true))
            {
                Events.Events.UseEvents();   
            }

            if (examplesToExecute.Keys.Contains(Constants.Actions) && (examplesToExecute[Constants.Actions] == true))
            {
                Delegates.Actions.UseActions();
            }

            if (examplesToExecute.Keys.Contains(Constants.Funcs) && (examplesToExecute[Constants.Funcs] == true))
            {

            }

            Console.ReadLine();
            //multithreading
        }

        private static Dictionary<string, bool> GetTypesToExecute()
        {
            Dictionary<string, bool> examplesToExecute = new Dictionary<string, bool>();

            try
            {

                string executeDelegatesCodeValue = ConfigurationManager.AppSettings[Constants.Delegates];
                string executeEnumsCodeValue = ConfigurationManager.AppSettings[Constants.Enums];
                string executeGenericsCodeValue = ConfigurationManager.AppSettings[Constants.Generics];
                string executeEventsCodeValue = ConfigurationManager.AppSettings[Constants.Events];
                string executeActionsCodeValue = ConfigurationManager.AppSettings[Constants.Actions];
                string executeFuncsCodeValue = ConfigurationManager.AppSettings[Constants.Funcs];

                bool executeDelegatesCode;
                bool executeEnumsCode;
                bool executeGenericsCode;
                bool executeEventsCode;
                bool executeActionsCode;
                bool executeFuncsCode;

                bool.TryParse(executeDelegatesCodeValue, out executeDelegatesCode);
                bool.TryParse(executeEnumsCodeValue, out executeEnumsCode);
                bool.TryParse(executeGenericsCodeValue, out executeGenericsCode);
                bool.TryParse(executeEventsCodeValue, out executeEventsCode);
                bool.TryParse(executeActionsCodeValue, out executeActionsCode);
                bool.TryParse(executeFuncsCodeValue, out executeFuncsCode);

                examplesToExecute.Add(Constants.Delegates, executeDelegatesCode);
                examplesToExecute.Add(Constants.Enums, executeEnumsCode);
                examplesToExecute.Add(Constants.Generics, executeGenericsCode);
                examplesToExecute.Add(Constants.Events, executeEventsCode);
                examplesToExecute.Add(Constants.Actions, executeActionsCode);
                examplesToExecute.Add(Constants.Funcs, executeFuncsCode);

                return examplesToExecute;
            }
            catch (Exception ex)
            {
                return examplesToExecute;
            }
            
        }
    }
}
