﻿using System;
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
    /// Логика взаимодействия для MailWindow.xaml
    /// </summary>
    public partial class MailWindow : Window
    {
        public MailWindow()
        {
            InitializeComponent();
            Settings sett = Settings.GetInstance();
            l_Email.Content = "email: " + sett.email;
            l_Name.Content = "фамилия: " + sett.lastName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
