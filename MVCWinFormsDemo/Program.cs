#region System's manespaces

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

#region User's manespaces

using ModelLibrary;

#endregion

namespace MVCWinFormsDemo
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

            Model m = new Model();    // BL

            Controller c = new Controller(m);

            Application.Run(new MainViewForm(c));
        }
    }
}
