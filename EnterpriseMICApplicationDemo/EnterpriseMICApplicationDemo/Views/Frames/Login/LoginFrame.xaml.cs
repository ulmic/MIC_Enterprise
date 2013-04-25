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
using EnterpriseMICApplicationDemo.Views.BaseForms.Main;

namespace EnterpriseMICApplicationDemo.Views.Frames.Login
{
    public delegate void ComeOnFrameHandler(string status);
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class LoginFrame : Page
    {
        public static event ComeOnFrameHandler ComeOn;

        public LoginFrame()
        {
            InitializeComponent();
            this.Loaded += LoginFrame_Loaded;            
        }

        void LoginFrame_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)((Window.GetWindow(this)).TryFindResource("storyboardLogin"));
            s.Begin();
        }
        
        private void Button_OnLogin(object sender, RoutedEventArgs e)
        {
            (new Views.BaseForms.Main.Main()).Show();
            Window.GetWindow(this).Close();
            if (ComeOn != null)
                ComeOn("login");
        }

        private void Label_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            ForgotPasswordFrame forgot = new ForgotPasswordFrame();
            this.NavigationService.Navigate(forgot);
        }
    }
}
