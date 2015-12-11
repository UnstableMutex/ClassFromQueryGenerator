using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFromQueryGenerator.Generator
{
    class Gen
    {
        private readonly string _cs;
        private readonly string _tableName;
        private readonly string _classMacro;
        private readonly string _propMacro;

        public Gen(string cs, string tableName)
        {
            _cs = cs;
            _tableName = tableName;

            _propMacro =
                @"C:\Users\ShevyakovDY\Source\Repos\ClassFromQueryGenerator\ClassFromQueryGenerator\ClassFromQueryGenerator\bin\Debug\Macros\Property\sample.txt";

            _classMacro=@"C:\Users\ShevyakovDY\Source\Repos\ClassFromQueryGenerator\ClassFromQueryGenerator\ClassFromQueryGenerator\bin\Debug\Macros\Class\sample.txt";
       
        }

        public void Generate()
        {


            
        }
    }
}
