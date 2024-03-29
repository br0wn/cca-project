﻿using System;
using System.IO;
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

            DBObjectController.InitializeDataBase();
            
            Application.Run(new MainControlPanel());

            if (DBObjectController.ValidateDatabase())
            {
                DBObjectController.SaveChanges();
            }
        }
    }
}
