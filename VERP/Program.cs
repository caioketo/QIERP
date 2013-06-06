using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase;

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
            s.ShowDialog();
            s.Close();
            Application.Run(new Form1());
        }
    }
}
