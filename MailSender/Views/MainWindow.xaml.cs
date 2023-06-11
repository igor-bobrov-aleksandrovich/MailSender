using MailSender.UserControls;
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

namespace MailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginControl loginControl;
        RegControl regControl;
        bool logInState = true;

        public MainWindow()
        {           
            InitializeComponent();

            loginControl = new LoginControl();
            regControl = new RegControl();
            MainGrid.Children.Add(loginControl);
            loginControl.SetValue(Grid.RowProperty, 0);
            regControl.SetValue(Grid.RowProperty, 0);

            b_LogIn.Content = "Войти";
            b_Reg.Content = "Зарегестрироваться";
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {   
            b_LogIn.SetValue(Grid.RowProperty, 1);
            if(logInState)
            {
                Binding binding = new Binding();
                binding.Path = new PropertyPath("LogIn"); //Name of the property in Datacontext
                b_LogIn.SetBinding(Button.CommandProperty, binding);
            }
            else
            {
                Binding binding = new Binding();
                binding.Path = new PropertyPath("RegUser"); //Name of the property in Datacontext
                b_LogIn.SetBinding(Button.CommandProperty, binding);
            }
        }

        private void b_Reg_Click(object sender, RoutedEventArgs e)
        {
            if (logInState)
            {
                logInState = false;
                b_LogIn.Content = "Создать аккаунт";
                b_Reg.Content = "Назад";

                MainGrid.Children.Remove(loginControl);
                MainGrid.Children.Add(regControl);
            }
            else
            {
                logInState = true;
                b_LogIn.Content = "Войти";
                b_Reg.Content = "Зарегестрироваться";

                MainGrid.Children.Remove(regControl);
                MainGrid.Children.Add(loginControl);
            }
        }
    }
}
