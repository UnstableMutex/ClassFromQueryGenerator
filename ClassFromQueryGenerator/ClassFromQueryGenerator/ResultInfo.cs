using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFromQueryGenerator
{
   public class ResultInfo
    {
        public ResultInfo()
        {
            Fields = new List<FieldInfo>();
        }
        public string Name { get; set; }
        public List<FieldInfo> Fields { get; set; }
    }
}
