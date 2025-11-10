using System.ComponentModel;
using System.Runtime.CompilerServices;
using RotaryLib;

namespace RotaryGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _api;
        
        private string? _selectedCategory;
        private string? _selectedCountryCode;
        private string _selectedGender = "Férfi";

        public event PropertyChangedEventHandler? PropertyChanged;
        public IEnumerable<int>? Categories { get; set; }
        public IEnumerable<string>? CountryCodes { get; set; }

        public string? SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                _selectedCategory = value;
                Changed();
            }
        }

        public string? SelectedCountryCode
        {
            get => _selectedCountryCode;
            set
            {
                _selectedCountryCode = value;
                Changed();
            }
        }

        public string SelectedGender
        {
            get => _selectedGender;
            set
            {
                _selectedGender = value;
                Changed();
            }
        }

        public MainWindowViewModel()
        {
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

        private void Changed([CallerMemberName] string propertyName = "") =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
