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
using System.Windows.Shapes;

using EnterpriseMICApplicationDemo.View.Login;

namespace EnterpriseMICApplicationDemo.Controllers
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
            LoginPage logPage = new LoginPage();
            LoginPage.ComeOn += logPage_Return;
            mainFrame.NavigationService.Navigate(logPage, this);
        }

        private void propertyHeightAnimate(int height, double time)
        {
            DoubleAnimation anim2 = new DoubleAnimation();
            anim2.From = this.Height;
            anim2.To = height;
            anim2.Duration = TimeSpan.FromSeconds(time);
            anim2.FillBehavior = FillBehavior.Stop;
            this.BeginAnimation(Window.HeightProperty, anim2, HandoffBehavior.Compose);
        }

        private void propertyWidthAnimate(int width, double time)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = this.Width;
            anim.To = width;
            anim.Duration = TimeSpan.FromSeconds(time);
            anim.FillBehavior = FillBehavior.Stop;
            this.BeginAnimation(Window.WidthProperty, anim, HandoffBehavior.Compose);
        }
        
        void logPage_Return(string message)
        {
            switch (message)
            {
                case "forgot":
                    propertyWidthAnimate(320, 0.09);
                    propertyHeightAnimate(150, 0.19);
                    break;
                case "login_wait":
                    propertyWidthAnimate(228, 0.09);
                    propertyHeightAnimate(187, 0.19);
                    break;
                case "login":
                    break;
            }
        }
    }
}
