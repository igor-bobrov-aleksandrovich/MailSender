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
using System.Windows.Shapes;

namespace MailSender.Views
{
    /// <summary>
    /// Логика взаимодействия для MailSenderWindow.xaml
    /// </summary>
    public partial class MailSenderWindow : Window
    {
        public MailSenderWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmailService service = new EmailService();
            service.SendEmailAsync("igor.bobrov.aleksandrovich@gmail.com", "gmailll", ")))");
        }
    }
}
