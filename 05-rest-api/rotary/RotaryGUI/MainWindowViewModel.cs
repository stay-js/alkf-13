using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using RotaryLib;
using RotaryGUI.Utils;

namespace RotaryGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _api;

        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand SubmitCommand { get; }

        public IEnumerable<int>? Categories { get; set; }
        public IEnumerable<string>? CountryCodes { get; set; }

        public string? SelectedCategory { get; set; }
        public string? SelectedCountryCode { get; set; }
        public string SelectedGender { get; set; } = "Férfi";
        public string? EntryNumber { get; set; }
        public string? Position { get; set; }
        public string? BirthYear { get; set; }
        public string? City { get; set; }
        public string? CategoryPosition { get; set; }
        public string? GenderPosition { get; set; }
        public string? Time { get; set; }

        public MainWindowViewModel()
        {
            SubmitCommand = new RelayCommand(OnSubmit);
            _api = new ApiClient();

            _ = FetchInitialData();
        }

        public async Task FetchInitialData()
        {
            Categories = await _api.GetAsync<IEnumerable<int>>("/categories");
            Changed(nameof(Categories));

            CountryCodes = await _api.GetAsync<IEnumerable<string>>("/country-codes");
            Changed(nameof(CountryCodes));
        }

        private void OnSubmit(object? obj)
        {
            MessageBox.Show("submit");
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
