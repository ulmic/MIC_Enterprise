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
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using EnterpriseMICApplicationDemo.Views.Frames.Main;

namespace EnterpriseMICApplicationDemo.Views.BaseForms.Main
{
    /// <summary>
    /// Логика взаимодействия для BasisMain.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Storyboard stor;
        public Main()
        {
            InitializeComponent();
            stor = (Storyboard)this.FindResource("storyboardMore");
            this.basisFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            UsersListsFrame three = new UsersListsFrame();
            basisFrame.NavigationService.Navigate(three);
        }
    }
}
