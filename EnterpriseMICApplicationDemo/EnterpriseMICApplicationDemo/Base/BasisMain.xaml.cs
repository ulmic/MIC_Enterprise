using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EnterpriseMICApplicationDemo.View.Basis;

namespace EnterpriseMICApplicationDemo.Base
{
    /// <summary>
    /// Логика взаимодействия для BasisMain.xaml
    /// </summary>
    public partial class BasisMain : Window
    {
        public BasisMain()
        {
            InitializeComponent();
            this.basisFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            ThreeLists three = new ThreeLists();
            basisFrame.NavigationService.Navigate(three);
        }
    }
}
