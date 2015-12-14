using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFromQueryGenerator.Generator
{
    class Gen
    {
        private readonly ResultInfo _resultInfo;
        private readonly string _cs;
        private readonly string _tableName;
        private readonly string _classMacro;
        private readonly string _propMacro;
        public Gen(ResultInfo resultInfo)
        {
            _resultInfo = resultInfo;
        }

        public string Generate(string shortFN)
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();
            scope.SetVariable("Model", _resultInfo);
            var pyf =Path.Combine(Constants.MacroPath,shortFN+".py");

            var res = engine.ExecuteFile(pyf, scope);
            var result = res.GetVariable("result").ToString();
            return result;

        }
        public string Test { get; set; }
    }
}
