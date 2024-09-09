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
    /// Interaction logic for SubmitClaim.xaml
    /// </summary>
    public partial class SubmitClaim : Window
    {
        public SubmitClaim()
        {
            InitializeComponent();
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {

            DateTime? selectedDate = ClaimDatePicker.SelectedDate;
            string hoursWorked = HoursWorkedTextBox.Text;
            string comments = CommentsTextBox.Text;

            if (selectedDate == null || string.IsNullOrEmpty(hoursWorked))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            MessageBox.Show("Claim submitted successfully!");
        }
    }
}
