using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurent_Managment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CashierOrder (null));
            //Application.Run(new Inventory(null));
            Application.Run(new LogIn(null));
            //Application.Run(new StaffInfo(null));
        }
    }
}
