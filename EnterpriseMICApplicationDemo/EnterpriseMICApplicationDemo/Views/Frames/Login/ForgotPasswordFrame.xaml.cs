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

namespace EnterpriseMICApplicationDemo.Views.Frames.Login
{
    /// <summary>
    /// Логика взаимодействия для ForgotPasswordFrame.xaml
    /// </summary>
    public partial class ForgotPasswordFrame : Page
    {
        public ForgotPasswordFrame()
        {
            InitializeComponent();
            this.Loaded += ForgotPasswordFrame_Loaded;
        }

        void ForgotPasswordFrame_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)(Window.GetWindow(this).TryFindResource("storyboardForgot"));
            s.Begin();
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
