using Microsoft.Win32;
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

    public partial class UploadDocument : Window
    {
        public UploadDocument()
        {
            InitializeComponent();
        }


        private void BrowseID_Click(object sender, RoutedEventArgs e)
        {             OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                IDPathTextBlock.Text = openFileDialog.FileName;
            }
        }

        private void BrowseAcademicCert_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                AcademicCertPathTextBlock.Text = openFileDialog.FileName;
            }
        }

        
        private void BrowseSARS_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                SARSPathTextBlock.Text = openFileDialog.FileName;
            }
        }

       
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AcademicCertPathTextBlock.Text) && !AcademicCertPathTextBlock.Text.Equals("No file selected.") &&
                !string.IsNullOrEmpty(SARSPathTextBlock.Text) && !SARSPathTextBlock.Text.Equals("No file selected."))
            {
                MessageBox.Show("Documents uploaded successfully.");
            }
            else
            {
                MessageBox.Show("Please select both Academic Certificate and Income Tax Document (SARS).");
            }
        }
    }
}
