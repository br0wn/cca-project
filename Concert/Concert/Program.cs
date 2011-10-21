using System;
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
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Concert)).CascadeOnActivate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Concert)).CascadeOnUpdate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Album)).CascadeOnUpdate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Album)).CascadeOnActivate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Album)).CascadeOnDelete(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Artist)).CascadeOnUpdate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Artist)).CascadeOnActivate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Artist)).CascadeOnDelete(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Band)).CascadeOnUpdate(true);
            DBObjectController.config.Common.ObjectClass(typeof(DBObjectDefinition.Band)).CascadeOnActivate(true);

            using (DBObjectController.db = Db4oEmbedded.OpenFile(DBObjectController.config, DBObjectController.YapFileName))
            {
                Application.Run(new MainControlPanel());
            }
        }
    }
}
