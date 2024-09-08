using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContractMonthlyClaimSystemPROG6212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the claim submission page
            ClaimSubmissionPage claimSubmissionPage = new ClaimSubmissionPage();
            claimSubmissionPage.Show();
            this.Close();
        }

        private void ClaimStatus_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the claim status page
            ClaimStatusPage claimStatusPage = new ClaimStatusPage();
            claimStatusPage.Show();
            this.Close();
        }

        private void UploadDocuments_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the claim status page
            UploadDocuments uploadDocumentsPage = new UploadDocuments();
            uploadDocumentsPage.Show();
            this.Close();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            // Log the user out and navigate back to the login page
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}