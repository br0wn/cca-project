﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Db4objects.Db4o;
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
            DBObjectController.config = Db4oEmbedded.NewConfiguration();
            //DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Concert)).CascadeOnActivate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Concert)).CascadeOnUpdate(true);
            using (DBObjectController.db = Db4oEmbedded.OpenFile(DBObjectController.config, DBObjectController.YapFileName))
            {
                Application.Run(new MainControlPanel());
            }
            //nekaj


            // vaadssssss
        }
    }
}