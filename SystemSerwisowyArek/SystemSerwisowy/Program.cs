using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace SystemSerwisowy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //bool firstRun;
            try
            {
                //using (Mutex mutex = new Mutex(true, "Example", out firstRun))
                //{
                //    if (firstRun)
                //    {
                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                {
                    MessageBox.Show("Program jest już uruchomiony ");
                    return;
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Glowna());
                }
                //    }
                //    else
                //    {
                //        mutex.ReleaseMutex();
                //    }
                //}
            }
            catch (ApplicationException ee)
            {
                MessageBox.Show("Program jest już uruchomiony " +ee.Message);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
