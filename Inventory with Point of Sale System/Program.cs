using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_with_Point_of_Sale_System
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
            Application.Run(new frmLogIn());
        }
    }
}
