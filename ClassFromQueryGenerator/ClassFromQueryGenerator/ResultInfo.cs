using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFromQueryGenerator
{
    class ResultInfo
    {
        public string Name { get; set; }
        public IEnumerable<FieldInfo> Fields { get; set; }
    }
}
