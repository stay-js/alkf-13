using RotaryGUI.Utils;
using RotaryLib;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;

namespace RotaryGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _api;
        private readonly CultureInfo _cultureInfo = new("hu-HU");

        private string? selectedCategory;
        private string? selectedCountryCode;
        private string selectedGender = "Férfi";
        private string? entryNumber;
        private string? position;
        private string? birthYear;
        private string? city;
        private string? categoryPosition;
        private string? genderPosition;
        private string? time;

        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand SubmitCommand { get; init; }

        public IEnumerable<int>? Categories { get; set; }
        public IEnumerable<string>? CountryCodes { get; set; }

        public string? SelectedCategory
        {
            get => selectedCategory;
            set => SetProperty(ref selectedCategory, value);
        }

        public string? SelectedCountryCode
        {
            get => selectedCountryCode;
            set => SetProperty(ref selectedCountryCode, value);
        }

        public string SelectedGender
        {
            get => selectedGender;
            set => SetProperty(ref selectedGender, value);
        }

        public string? EntryNumber
        {
            get => entryNumber;
            set => SetProperty(ref entryNumber, value);
        }

        public string? Position
        {
            get => position;
            set => SetProperty(ref position, value);
        }

        public string? BirthYear
        {
            get => birthYear;
            set => SetProperty(ref birthYear, value);
        }

        public string? City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        public string? CategoryPosition
        {
            get => categoryPosition;
            set => SetProperty(ref categoryPosition, value);
        }

        public string? GenderPosition
        {
            get => genderPosition;
            set => SetProperty(ref genderPosition, value);
        }

        public string? Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }

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

        public void ResetForm()
        {
            SelectedCategory = null;
            SelectedCountryCode = null;
            SelectedGender = "Férfi";
            EntryNumber = null;
            Position = null;
            BirthYear = null;
            City = null;
            CategoryPosition = null;
            GenderPosition = null;
            Time = null;
        }

        private async void OnSubmit(object? obj)
        {
            var errors = new List<string>();

            string?[] requiredFields = [
                SelectedCategory,
                SelectedCountryCode,
                SelectedGender,
                EntryNumber,
                Position,
                BirthYear,
                City,
                CategoryPosition,
                GenderPosition,
                Time,
            ];

            if (requiredFields.Any(string.IsNullOrWhiteSpace))
            {
                errors.Add("Kérem töltsön ki minden mezőt!");
            }

            ValidateInt(EntryNumber, "rajtszám", errors);
            ValidateInt(Position, "pozíció", errors);
            ValidateInt(BirthYear, "születési év", errors);
            ValidateInt(CategoryPosition, "kategóriánkénti pozíció", errors);
            ValidateInt(GenderPosition, "nemenkénti pozíció", errors);

            if (!TimeOnly.TryParse(Time, _cultureInfo, out _))
            {
                errors.Add("A futási időt a következő formátumban adja meg (hh:mm:ss)!");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors),
                    "Hiba",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            var result = await _api.PostAsync<IEnumerable<string>?>("/results", new
            {
                Position = int.Parse(Position!),
                EntryNumber = int.Parse(EntryNumber!),
                BirthYear = int.Parse(BirthYear!),
                City,
                CountryCode = SelectedCountryCode,
                Category = SelectedCategory,
                CategoryPosition = int.Parse(CategoryPosition!),
                Gender = SelectedGender,
                GenderPosition = int.Parse(GenderPosition!),
                Time = TimeOnly.Parse(Time!, _cultureInfo),
            });

            if (result is not null)
            {
                MessageBox.Show(string.Join("\n", MapErrorToHungarian.MapAll(result)),
                    "Hiba",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            ResetForm();
        }

        private static void ValidateInt(string? value, string fieldName, List<string> errors)
        {
            if (string.IsNullOrWhiteSpace(value) || !int.TryParse(value, out _))
            {
                errors.Add($"A(z) {fieldName} csak szám lehet!");
            }
        }

        private bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            Changed(propertyName);

            return true;
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
