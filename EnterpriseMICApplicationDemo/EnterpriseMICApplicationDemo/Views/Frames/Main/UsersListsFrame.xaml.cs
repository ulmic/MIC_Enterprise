using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using EnterpriseMICApplicationDemo.Models.Main.UsersLists;

namespace EnterpriseMICApplicationDemo.Views.Frames.Main
{
    /// <summary>
    /// Логика взаимодействия для ThreeLists.xaml
    /// </summary>
    /// 
    public class Row
    {
        public List<string> cells { get; set; }
        public string cell2 { get; set; }
        public string val { get; set; }

        public override string ToString()
        {
            return val;
        }
    }

    public static class Rows
    {
        public static IEnumerable<Row> GetRows()
        {
            List<Row> Rows = new List<Row>();
            Rows.Add(new Row { cells = new List<string> {"70", "32"}, cell2 = "172", val = "Austria" });
            Rows.Add(new Row { cells = new List<string> { "701", "23" }, cell2 = "145", val = "USA" });
            Rows.Add(new Row { cells = new List<string> { "702", "23" }, cell2 = "123", val = "Ukraine" });
            Rows.Add(new Row { cells = new List<string> { "703", "23" }, cell2 = "785", val = "Italy" });
            Rows.Add(new Row { cells = new List<string> { "704", "23" }, cell2 = "241", val = "Japan" });

            return Rows;
        }
    }

    public partial class UsersListsFrame : Page
    {
        public List<Row> TList = new List<Row>();
        //CollectionViewSource listingDataView;
        public UsersListsFrame()
        {
            InitializeComponent();
            
            listOrganizations.DataContext = Rows.GetRows();
            listHumans.DataContext = Rows.GetRows();
            //listingDataView = (CollectionViewSource)(this.Resources["listingDataView"]);
            //tList = new ObservableCollection<string>(d.listDB);


        }

    }
}
