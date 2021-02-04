using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CPUThrottler.Forms;

namespace CPUThrottler
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplyLanguage();
            var arguments = Environment.GetCommandLineArgs();
            if(arguments.Contains("-minimized"))
            {
                var form = new FormMain("minimized")
                    {Language = System.Threading.Thread.CurrentThread.CurrentCulture.Name};
                Application.Run();
            }
            else
            {
                var form = new FormMain {Language = System.Threading.Thread.CurrentThread.CurrentCulture.Name};
                Application.Run(form);
            }
        }

        private static void ApplyLanguage()
        {
            var language = Convert.ToString(Microsoft.Win32.Registry.CurrentUser
                .CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Config")
                ?.GetValue("Language",
                    System.Globalization.CultureInfo.InstalledUICulture.Name));
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(language);
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(language);
        }
    }
}
