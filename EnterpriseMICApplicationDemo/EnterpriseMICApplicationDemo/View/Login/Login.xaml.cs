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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EnterpriseMICApplicationDemo.Base;

namespace EnterpriseMICApplicationDemo.View.Login
{
    public delegate void ComeOnFrameHandler(string status);
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public static event ComeOnFrameHandler ComeOn;

        public Login()
        {
            InitializeComponent();
            this.Loaded += Login_Loaded;            
        }

        void Login_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)((Window.GetWindow(this)).TryFindResource("storyboardLogin"));
            s.Begin();
        }
        
        private void Button_OnLogin(object sender, RoutedEventArgs e)
        {
            (new BasisMain()).Show();
            Window.GetWindow(this).Close();
            if (ComeOn != null)
                ComeOn("login");
        }

        private void Label_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            this.NavigationService.Navigate(forgot);
        }
    }
}
