using CPUThrottler.Forms;
using Microsoft.Win32;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

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
            if (arguments.Contains("-minimized"))
            {
                var form = new FormMain("minimized")
                { Language = Thread.CurrentThread.CurrentCulture.Name };
                Application.Run();
            }
            else
            {
                var form = new FormMain { Language = Thread.CurrentThread.CurrentCulture.Name };
                Application.Run(form);
            }
        }

        private static void ApplyLanguage()
        {
            var language = Convert.ToString(Registry.CurrentUser
                .CreateSubKey(@"SOFTWARE\Just IT Solutions\CPUThrottler\Config")
                ?.GetValue("Language",
                    CultureInfo.InstalledUICulture.Name));
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
        }
    }
}