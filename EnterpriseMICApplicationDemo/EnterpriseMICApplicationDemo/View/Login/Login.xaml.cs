using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EnterpriseMICApplicationDemo.Controllers;

namespace EnterpriseMICApplicationDemo.View.Login
{
    public delegate void ComeOnFrameHandler(string status);
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public class Login : PageFunction<string>
    {
    }
    public partial class LoginPage : Login
    {
        public static event ComeOnFrameHandler ComeOn;

        public LoginPage()
        {
            InitializeComponent();
            this.Loaded += LoginPage_Loaded;
        }

        void LoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (ComeOn != null)
                ComeOn("login_wait");
        }

        private void Button_OnLogin(object sender, RoutedEventArgs e)
        {
            if (ComeOn != null)
                ComeOn("login");
        }

        private void Label_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            if (ComeOn != null)
                ComeOn("forgot");
            this.NavigationService.Navigate(forgot);
        }
    }
}
