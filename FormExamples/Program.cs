using FormExamples.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExamples
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }

        private static Dictionary<string, bool> GetTypesToExecute()
        {
            Dictionary<string, bool> examplesToExecute = new Dictionary<string, bool>();

            try
            {

                string executeMultithreadingCodeValue = ConfigurationManager.AppSettings[Constants.Multithreading];
                string executeAsyncAwaitCodeValue = ConfigurationManager.AppSettings[Constants.AsyncAwait];

                bool executeMultithreadingCode;
                bool executeAsyncAwaitCode;

                bool.TryParse(executeMultithreadingCodeValue, out executeMultithreadingCode);
                bool.TryParse(executeAsyncAwaitCodeValue, out executeAsyncAwaitCode);

                examplesToExecute.Add(Constants.Multithreading, executeMultithreadingCode);
                examplesToExecute.Add(Constants.AsyncAwait, executeAsyncAwaitCode);

                return examplesToExecute;
            }
            catch (Exception ex)
            {
                return examplesToExecute;
            }

        }
    }
}
