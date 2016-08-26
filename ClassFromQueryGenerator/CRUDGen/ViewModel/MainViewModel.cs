using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CRUDGen.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Data.ConnectionUI;
using Microsoft.Scripting.Utils;

namespace CRUDGen.ViewModel
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
        private ConnString _selected;
        private object _content;

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
            AddConnectionCommand = new RelayCommand(AddConnection);
            Connections = InitConnections();
            if (Connections.Any())
            {
                Selected = Connections.First();
            }


        }

        private ObservableCollection<ConnString> InitConnections()
        {
            var res = new ObservableCollection<ConnString>();
            if (File.Exists(Sets.LiteDBFN))
            {
                using (var ldb = new LiteDB.LiteDatabase(Sets.LiteDBFN))
                {
                    var coll = ldb.GetCollection<ConnString>(nameof(ConnString));
                    res.AddRange(coll.FindAll());
                }
            }


            return res;
        }

        private void AddConnection()
        {
            DataConnectionDialog dlg = new DataConnectionDialog();
            DataSource.AddStandardDataSources(dlg);
            var dr = DataConnectionDialog.Show(dlg);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            var cs = dlg.ConnectionString;
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder(cs);
            ConnString s = new ConnString(b.DataSource, b.ConnectionString);
            var dbfn = new FileInfo(Sets.LiteDBFN);
            dbfn.Directory.Create();
            using (var ldb = new LiteDB.LiteDatabase(Sets.LiteDBFN))
            {
                var coll = ldb.GetCollection<ConnString>(nameof(ConnString));
                coll.Insert(s);
            }




            Connections.Add(s);
            Selected = s;



        }

        public ObservableCollection<ConnString> Connections { get; private set; }

        public ConnString Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                RaiseSelectedChanged();

            }
        }

        private void RaiseSelectedChanged()
        {
            RaisePropertyChanged(nameof(Selected));
            Content = new DatabaseViewModel(Selected.CS);

        }

        public object Content
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChanged(nameof(Content));
            }
        }

        public RelayCommand AddConnectionCommand { get; private set; }
    }
}