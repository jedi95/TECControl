using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECControl
{
    static class Program
    {
        static System.Threading.Mutex mutex = new System.Threading.Mutex(true, "{553BD62A-051C-43F7-B6A3-1F2018A02379}");
        [STAThread]
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
                mutex.ReleaseMutex();
            }
            else
            {
                // send our Win32 message to make the currently running instance
                // jump on top of all the other windows
                NativeMethods.PostMessage(
                    (IntPtr)NativeMethods.HWND_BROADCAST,
                    NativeMethods.WM_SHOWME,
                    IntPtr.Zero,
                    IntPtr.Zero);
                Application.Exit();
            }
        }
    }
}
