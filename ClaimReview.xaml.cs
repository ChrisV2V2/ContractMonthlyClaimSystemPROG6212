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
    public partial class ClaimReview : Window
    {
        
        public List<Claim> ClaimsList { get; set; }

        public ClaimReview()
        {
            InitializeComponent();
            LoadClaims();
        }

        
        private void LoadClaims()
        {
            ClaimsList = new List<Claim>
            {
                new Claim { ClaimID = 1, LecturerName = "John Doe", HoursWorked = 10, Amount = 500, Status = "Pending", Notes = "Claimed for extra hours worked on project X." },
                new Claim { ClaimID = 2, LecturerName = "Jane Smith", HoursWorked = 8, Amount = 400, Status = "Pending", Notes = "Claimed for consultation hours." }
            };

            ClaimsDataGrid.ItemsSource = ClaimsList;
        }

        // Approve the selected claim
        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            Claim selectedClaim = (Claim)ClaimsDataGrid.SelectedItem;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Approved";
                ClaimsDataGrid.Items.Refresh(); // Refresh DataGrid to show updated status
                MessageBox.Show("Claim Approved", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Reject the selected claim
        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            Claim selectedClaim = (Claim)ClaimsDataGrid.SelectedItem;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Rejected";
                ClaimsDataGrid.Items.Refresh(); // Refresh DataGrid to show updated status
                MessageBox.Show("Claim Rejected", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a claim to reject.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // View the supporting notes of the selected claim
        private void ViewNotes_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string notes = btn.Tag.ToString();
            MessageBox.Show(notes, "Claim Notes", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    // Class representing a claim (this would typically come from a database)
    public class Claim
    {
        public int ClaimID { get; set; }
        public string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }  // New property for supporting notes
    }
}
