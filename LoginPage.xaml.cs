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

namespace ContractMonthlyClaimSystemPROG6212
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Get the entered username and password
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Dummy check for credentials (you can replace this with actual authentication logic)
            if (username == "lecturer" && password == "password123")
            {
                // If login is successful, navigate to the Main Menu for Lecturer
                MainWindow mainMenu = new MainWindow();
                mainMenu.Show();
                this.Close();
            }
            else
            {
                // Show an error message if the login fails
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
