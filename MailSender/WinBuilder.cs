using MailSender.ViewModels;
using MailSender.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    abstract class WinBuilder
    {
        public static void ShowMainWindow()
        {
            var window = new MainWindow();
            var viewModel = new MainWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }
        public static void ShowMailWindow()
        {
            var window = new MailWindow();
            var viewModel = new MailWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }
        public static void ShowMailSenderWindow()
        {
            var window = new MailSenderWindow();
            var viewModel = new MailSenderModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }
    }
}
