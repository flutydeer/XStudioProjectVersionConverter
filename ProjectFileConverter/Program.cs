using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectFileConverter
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(LoadAppSettings()));
        }

        private static AppSettings LoadAppSettings()
        {
            string path = Environment.CurrentDirectory + "\\appSettings.json";
            if (File.Exists(path))
            {
                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(reader.ReadToEnd());
                stream.Close();
                reader.Close();
                return appSettings;
            }
            else
            {
                return new AppSettings();
            }
        }
    }
}
