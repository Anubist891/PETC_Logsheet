using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETC_Logsheet
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

            string ps_localversion = GetLocalVersion();
            while (true)
            {
                frmLogIn splash = new frmLogIn();
                DialogResult result= splash.ShowDialog();
                if (result == DialogResult.OK)
                { 
                    frmMainMenu ftmMain = new frmMainMenu();
                    Application.Run(ftmMain);
                    break;
                }
                if (result == DialogResult.Cancel)
                {
                    break;
                }
            }
        }
        #region Get Local Version
        public static string GetLocalVersion()
        {
            string localVersion = "";
            try
            {
                //string assemblylocation = Assembly.GetExecutingAssembly().CodeBase;
                //assemblylocation = assemblylocation.Substring(assemblylocation.LastIndexOf("/") + 1);
                //string applicationName = assemblylocation;
                AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
                localVersion = assemblyName.Version.ToString();
            }
            catch
            {
            }
            return localVersion;
        }
        #endregion Get Local Version
    }

}
