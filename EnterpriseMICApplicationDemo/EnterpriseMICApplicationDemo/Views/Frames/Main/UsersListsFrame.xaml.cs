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
   


    public partial class UsersListsFrame : Page
    {
        private List<Organization> organizations;
        public UsersListsFrame()
        {
            InitializeComponent();            
            UsersListsModel um = new UsersListsModel();
            organizations = um.getOrganizations();
            listOrganizations.DataContext = organizations;
            //listHumans.DataContext = Rows.GetOrganizations();
            //listingDataView = (CollectionViewSource)(this.Resources["listingDataView"]);
            //tList = new ObservableCollection<string>(d.listDB);
        }

        private void OrgsItem_Click(object sender, MouseButtonEventArgs e) {
            listHumans.DataContext = ((Organization)listOrganizations.SelectedItem).getMembers(); 
        }

        private void HumItem_Click(object sender, MouseButtonEventArgs e) {
            listHumanInfo.DataContext = listHumans.SelectedItem; 
        }  
    }
}
