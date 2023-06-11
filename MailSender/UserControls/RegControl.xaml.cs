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

namespace MailSender.UserControls
{
    /// <summary>
    /// Логика взаимодействия для RegControl.xaml
    /// </summary>
    public partial class RegControl : UserControl
    {
        public RegControl()
        {
            InitializeComponent();
            cb_MailType.Items.Add("@mail.ru");
            cb_MailType.Items.Add("@inbox.ru");
            cb_MailType.Items.Add("@gmail.com");
            cb_MailType.SelectedIndex = 0;
        }

        private void DatePicker_CalendarOpened(object sender, RoutedEventArgs e)
        {

        }
    }
}
