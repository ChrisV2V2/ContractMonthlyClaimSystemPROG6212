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
    /// Interaction logic for AdminMainMenu.xaml
    /// </summary>
    public partial class AdminMainMenu : Window
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void ClaimReview_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Claim Review page (replace with actual navigation)
            ClaimReview claimReview = new ClaimReview();
            claimReview.Show();
            this.Close();
        }

        // Click event for Log Out
        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            // Close the admin menu and return to the login page
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
