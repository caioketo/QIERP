using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase;
using System.ComponentModel;
using System.Threading;
using VERP.Properties;
using VERP.Utils;

namespace VERP
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
            Splash s = new Splash();
            s.Show();
            Thread loadDB = new Thread(new ThreadStart(LoadDB));
            loadDB.Start();
            while (!loadDB.IsAlive) ;
            while (loadDB.IsAlive)
            {
                s.Refresh();
            }
            s.Close();
            Application.Run(new Form1());
        }

        public static void LoadDB()
        {
            if (Settings.Default.FirstRun)
            {
                using (FConfiguracao config = new FConfiguracao())
                {
                    config.ShowDialog();
                }
                Settings.Default.FirstRun = false;
                Settings.Default.Save();
            }
            DB.GetInstance(GetConn()).context.LoadAll();
        }

        public static string GetConn()
        {
            return Settings.Default.ConnectionStr;
        }
    }
}
