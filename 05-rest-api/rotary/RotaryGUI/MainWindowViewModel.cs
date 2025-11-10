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

        public RelayCommand SubmitCommand { get; }

        public IEnumerable<int>? Categories { get; set; }
        public IEnumerable<string>? CountryCodes { get; set; }

        public string? SelectedCategory
        {
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                Changed();
            }
        }

        public string? SelectedCountryCode
        {
            get => selectedCountryCode;
            set
            {
                selectedCountryCode = value;
                Changed();
            }
        }

        public string SelectedGender
        {
            get => selectedGender;
            set
            {
                selectedGender = value;
                Changed();
            }
        }

        public string? EntryNumber
        {
            get => entryNumber;
            set
            {
                entryNumber = value;
                Changed();
            }
        }

        public string? Position
        {
            get => position;
            set
            {
                position = value;
                Changed();
            }
        }

        public string? BirthYear 
        { 
            get => birthYear;
            set
            {
                birthYear = value;
                Changed();
            }
        }

        public string? City 
        {
            get => city;
            set
            {
                city = value;
                Changed();
            }
        }

        public string? CategoryPosition
        {
            get => categoryPosition;
            set
            {
                categoryPosition = value;
                Changed();
            }
        }

        public string? GenderPosition 
        { 
            get => genderPosition;
            set
            {
                genderPosition = value;
                Changed();
            }
        }

        public string? Time 
        {
            get => time;
            set
            {
                time = value;
                Changed();
            }
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

            if (string.IsNullOrWhiteSpace(SelectedCategory)
                || string.IsNullOrWhiteSpace(SelectedCountryCode)
                || string.IsNullOrWhiteSpace(SelectedGender)
                || string.IsNullOrWhiteSpace(EntryNumber)
                || string.IsNullOrWhiteSpace(Position)
                || string.IsNullOrWhiteSpace(BirthYear)
                || string.IsNullOrWhiteSpace(City)
                || string.IsNullOrWhiteSpace(CategoryPosition)
                || string.IsNullOrWhiteSpace(GenderPosition)
                || string.IsNullOrWhiteSpace(Time))
            {
                errors.Add("Kérem töltsön ki minden mezőt!");
            }

            if (!int.TryParse(EntryNumber, out _))
            {
                errors.Add("A rajtszám csak szám lehet!");
            }


            if (!int.TryParse(Position, out _))
            {
                errors.Add("A pozíció csak szám lehet!");
            }

            if (!int.TryParse(BirthYear, out _))
            {
                errors.Add("A születési év csak szám lehet!");
            }

            if (!int.TryParse(CategoryPosition, out _))
            {
                errors.Add("A kategóriánkénti pozíció csak szám lehet!");
            }

            if (!int.TryParse(GenderPosition, out _))
            {
                errors.Add("A nemenkénti pozíció csak szám lehet!");
            }

            if (!TimeOnly.TryParse(Time, out _))
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
                Time = TimeOnly.Parse(Time!),
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

        private void Changed([CallerMemberName] string propertyName = "") =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
