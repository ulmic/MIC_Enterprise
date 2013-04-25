using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Shapes;

using EnterpriseMICApplicationDemo.Views.Frames.Login;

namespace EnterpriseMICApplicationDemo.Views.BaseForms.Login
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.mainFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            LoginFrame.ComeOn += logPage_Return;
            LoginFrame logPage = new LoginFrame();
            mainFrame.NavigationService.Navigate(logPage);
        }

        void logPage_Return(string message)
        {
            switch (message)
            {
                case "forgot":            
                    break;
                case "login_wait":
                    break;
                case "login":
                    break;
            }
        }
    }
}
