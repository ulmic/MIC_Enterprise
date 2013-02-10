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

using EnterpriseMICApplicationDemo.View.Login;

namespace EnterpriseMICApplicationDemo.Base
{
    /// <summary>
    /// Логика взаимодействия для LoginMain.xaml
    /// </summary>
    public partial class LoginMain : Window
    {
        public LoginMain()
        {
            InitializeComponent();
            this.mainFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            Login.ComeOn += logPage_Return;
            Login logPage = new Login();
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
