using System.Windows;
using System.Windows.Controls;
using TanacsadoLib;

namespace TanacsadoGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataStore.Initialize();
            InitializeComponent();

            SpecializationComboBox.ItemsSource = DataStore.Instance?.Specializations;
        }

        public void ResetGUI()
        {
            AdvisorComboBox.ItemsSource = null;
            PhoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            HourlyRateTextBox.Text = string.Empty;
        }

        private void SpecializationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetGUI();

            if (SpecializationComboBox.SelectedItem is not Specialization selectedSpecialization)
                return;

            AdvisorComboBox.ItemsSource = DataStore
                .Instance?
                .Advisors
                .Where(x => x.SpecializationId == selectedSpecialization.Id);

            AdvisorComboBox.IsEnabled = true;
            AdvisorLabel.IsEnabled = true;
        }

        private void AdvisorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AdvisorComboBox.SelectedItem is not Advisor selectedAdvisor)
                return;

            PhoneTextBox.Text = selectedAdvisor.Phone;
            EmailTextBox.Text = selectedAdvisor.Email;
            HourlyRateTextBox.Text = selectedAdvisor.HourlyRate.ToString();
        }
    }
}
