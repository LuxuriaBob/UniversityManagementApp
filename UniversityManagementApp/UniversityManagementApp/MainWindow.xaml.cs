using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace UniversityManagementApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string userName = "admin";
        private string password = "password";
        string user;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            checkCredentials();
        }
        private void checkCredentials()
        {
            string pass = passwordBox.Password;
            string user = userName_textBox.Text;

            if (user == userName && pass == password)
            {
                Console.WriteLine("login successfull");
            }
        }
    }
}
