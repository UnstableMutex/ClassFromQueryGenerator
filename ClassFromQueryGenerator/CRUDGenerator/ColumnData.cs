﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDGenerator
{
   public class ColumnData
    {
        public string Name { get; set; }
        public string SQLType { get; set; }
    }

   public class TableInfo
    {
        public IReadOnlyList<ColumnData> Columns { get; set; }  
        public IReadOnlyList<ColumnData> UsualColumns { get; set; } 
        public ColumnData PK { get; set; }
        public string TableName { get; set; }
    }
}
