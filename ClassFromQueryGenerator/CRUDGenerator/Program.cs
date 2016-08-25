using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace CRUDGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"Server=sam-cld-43089-2\DEV;Database=test;Trusted_Connection=True;";
            string tableName = "t";
            string querycols = @"select column_name as Name,data_type as SQLType from information_schema.columns
 where table_name = '"+tableName+"' order by ordinal_position";
            string queryPK = @"SELECT column_name as primarykeycolumn
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC
INNER JOIN
INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KU
ON TC.CONSTRAINT_TYPE = 'PRIMARY KEY' AND
TC.CONSTRAINT_NAME = KU.CONSTRAINT_NAME
and ku.table_name='"+tableName+"'";

            var db = new SqlDatabase(cs);
            var cols = db.ExecuteSqlStringAccessor<ColumnData>(querycols).ToList();

         var ti = new TableInfo();
            ti.Columns = new List<ColumnData>(cols);
           

            var pkName = db.ExecuteScalar( CommandType.Text,  queryPK);

            var pkNames = pkName.ToString();

            ti.PKName = pkNames;


            SPGen g=new SPGen(ti);
          var result=  g.Generate("test");
            Console.WriteLine(result);
            Console.ReadKey();












        }
    }
    class SPGen
    {
        private readonly TableInfo _tableInfo;

        private readonly string _cs;
        private readonly string _tableName;
        private readonly string _classMacro;
        private readonly string _propMacro;
        public SPGen(TableInfo tableInfo)
        {
            _tableInfo = tableInfo;
        }

        public string Generate(string shortFN)
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();
            scope.SetVariable("Model", _tableInfo);
            var pyf =  shortFN + ".py";

            var res = engine.ExecuteFile(pyf, scope);
            var result = res.GetVariable("result").ToString();
            return result;

        }
        public string Test { get; set; }
    }
}
