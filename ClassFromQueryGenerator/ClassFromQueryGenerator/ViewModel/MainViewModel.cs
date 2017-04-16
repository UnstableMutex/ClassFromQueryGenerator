using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Input;
using ClassFromQueryGenerator.Command;
using ClassFromQueryGenerator.Generator;
using GalaSoft.MvvmLight;

namespace ClassFromQueryGenerator.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _result;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            GenerateCommand = new SimpleCommand(Generate);
            CS = @"Server=.;Database=AdventureWorks2014;Trusted_Connection=True;";
            Query = @"";
            RememberCSCommand = new SimpleCommand(RememberCS);
        }

        void RememberCS()
        {
            var datapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(datapath, Constants.AppName, "ConnectionStrings.settings");
            var file = new FileInfo(path);
            Directory.CreateDirectory(file.DirectoryName);






        }


        public ICommand RememberCSCommand { get; private set; }

        public string CS { get; set; }
        public string Query { get; set; }
        public ICommand GenerateCommand { get; set; }

        public IEnumerable<string> Macroses
        {
            get { return GetFiles(); }
        }
        public string SelectedMacros { get; set; }

        private IEnumerable<string> GetFiles()
        {
            var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            dir = dir.Parent.Parent.Parent;
            var macrodir = new DirectoryInfo(Path.Combine(dir.FullName, "PyMacros"));
            var fils = Directory.GetFiles(macrodir.FullName, "*.py");
            var res = fils.Select(Path.GetFileNameWithoutExtension);
            return res;
        }

        void Generate()
        {
            FieldTypeConverter c = new FieldTypeConverter();
            ResultInfo ri = new ResultInfo();
            ri.Name = "test";
            using (var conn = new SqlConnection(CS))
            using (var cmd = conn.CreateCommand())
            {
                (cmd.Connection = conn).Open();
                cmd.CommandText = Query;
                using (var r = cmd.ExecuteReader(CommandBehavior.KeyInfo))
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        var name = r.GetName(i);
                        var type = r.GetFieldType(i);
                        var sqlt = r.GetDataTypeName(i);
                        var schema = r.GetSchemaTable();
                        FieldInfo fi = new FieldInfo
                        {
                            Type = c.Convert(type),
                            Name = name
                        };
                        ri.Fields.Add(fi);
                    }
                }
            }
            var a = ri;
            Gen g = new Gen(a);
            Result = g.Generate(SelectedMacros);
        }

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged();
            }
        }
    }
}