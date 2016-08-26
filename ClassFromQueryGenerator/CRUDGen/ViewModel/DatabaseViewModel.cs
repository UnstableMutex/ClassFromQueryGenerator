using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDGen.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace CRUDGen.ViewModel
{
    class DatabaseViewModel : ViewModelBase
    {
        private readonly string _cs;
        private string _output;

        public DatabaseViewModel(string cs)
        {
            _cs = cs;
            GenerateCommand = new RelayCommand(Generate);
            Scripts = GetScripts();
            SelectedScript = Scripts.First();
            Tables = GetTables();
            SelectedTable = Tables.FirstOrDefault();
        }

        private List<string> GetTables()
        {
            string q =
                @"SELECT table_schema+'.'+table_name as tn FROM information_schema.tables WHERE TABLE_TYPE='BASE TABLE'";
            var res= new List<string>();
            var db =new SqlDatabase(_cs);
            using (var r = db.ExecuteReader(CommandType.Text, q))
            {
                while (r.Read())
                {
                    res.Add(r.GetString(0));
                }
            }


                return res;
        }

        private List<string> GetScripts()
        {
            var folder = new DirectoryInfo(Sets.ScriptsFolder);
            var scr = folder.GetFiles("*.py");


            return new List<string>(scr.Select(x => Path.GetFileNameWithoutExtension(x.Name)));

        }
        public string SelectedScript { get; set; }

        public List<string> Scripts { get; set; }

        private void Generate()
        {
            var ti = TIG.GetTableInfo(SelectedTable, _cs);
            SPGen g = new SPGen(ti);
            string scriptFN = Path.Combine(Sets.ScriptsFolder, SelectedScript + ".py");

            var generated = g.Generate(scriptFN);
            Output = generated;


        }

        public string Output
        {
            get { return _output; }
            set
            {
                _output = value;
                RaisePropertyChanged(nameof(Output));
            }
        }

        public RelayCommand GenerateCommand { get; private set; }
        public string SelectedTable { get; set; }

        public List<string> Tables { get; set; }
    }
}
