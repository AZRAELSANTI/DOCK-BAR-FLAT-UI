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
using System.Diagnostics;

namespace FLAT_UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Word_open_Click(object sender, RoutedEventArgs e)
        {
           
            string applicationPath = @"C:\Users\racco\AppData\Local\JetBrains\PyCharm Community Edition 2023.3.2\bin\pycharm64.exe";

         
            Process.Start(applicationPath);
        }
        private void VSCODE_Click(object sender, RoutedEventArgs e)
        {

            string applicationPath = @"C:\Users\racco\AppData\Local\Programs\Microsoft VS Code\Code.exe";


            Process.Start(applicationPath);
        }
        private void Discord_Click(object sender, RoutedEventArgs e)
        {

            string applicationPath = @"C:\Users\racco\AppData\Local\Discord\app-1.0.9147\Discord.exe";


            Process.Start(applicationPath);
        }
        private void Youtube_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.youtube.com");
        }
        private void Google_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.google.ru");
        }
        private void GMAIL_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://mail.google.com/");
        }
        private void Explorer_Click(object sender, RoutedEventArgs e)
        {

            string applicationPath = @"C:\Windows\explorer.exe";
        

            Process.Start(applicationPath);
        }
        private void Trash_Click(object sender, RoutedEventArgs e)
        {

            string applicationPath = @"C:\$RECYCLE.BIN";
            Process.Start(applicationPath);
        }
    }
}
