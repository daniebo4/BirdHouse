using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace BirdHouse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static Excel.Application? xlApp;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // before starting application , we check if Microsoft Excel is installed
            // if not, the application can't start
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            else
            {
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);

                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm(new UsersExcel()));
            }




        }
    }
}