using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDGen
{
    class Sets
    {
        public static string ScriptsFolder { get { return "..\\..\\..\\CRUDPyMacros"; } }
        public static string LiteDBFN
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Gen",
                    "LiteDB.database");
            }
        }
    }
}
