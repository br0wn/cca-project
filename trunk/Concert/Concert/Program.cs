using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Concert.DataAccessLayer;
using Concert.PresentationLayer;

namespace Concert
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
            DBObjectController.context = new ConcertEntities();
            Application.Run(new MainControlPanel());
        }
    }
}
