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
            CS =@"Data Source=SSMRDB2\GENESISINSTANCE;Initial Catalog=Genesis;Persist Security Info=True;User ID=GenesisUser;Password=qW12Ltakz;MultipleActiveResultSets=True";
            Query = "select top 1 * from contractbases";
        }
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
            var fils = Directory.GetFiles(Constants.MacroPath, "*.py");
          var res=  fils.Select(Path.GetFileNameWithoutExtension);
            return res;
        }

        void Generate()
        {
            FieldTypeConverter c=new FieldTypeConverter();
            ResultInfo ri=new ResultInfo();
            ri.Name = "test";
            using (var conn=new SqlConnection(CS))
            using (var cmd=conn.CreateCommand())
            {
                (cmd.Connection=conn).Open();
                cmd.CommandText = Query;
                using (var r=cmd.ExecuteReader(CommandBehavior.KeyInfo))
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        var name = r.GetName(i);
                        var type = r.GetFieldType(i);
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
            Gen g=new Gen(a);
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