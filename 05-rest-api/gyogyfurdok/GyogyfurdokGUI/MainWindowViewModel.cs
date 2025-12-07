using GyogyfurdokGUI.Utils;
using GyogyfurdokLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GyogyfurdokGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _api;

        private string? id;
        private string? selectedCounty;
        private string? name;
        private string? city;
        private string? zipCode;

        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand SubmitCommand { get; init; }

        public IEnumerable<string>? Counties { get; set; }

        public string? Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string? Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string? City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        public string? ZipCode
        {
            get => zipCode;
            set => SetProperty(ref zipCode, value);
        }

        public string? SelectedCounty
        {
            get => selectedCounty;
            set => SetProperty(ref selectedCounty, value);
        }

        public MainWindowViewModel()
        {
            _api = new ApiClient();
            SubmitCommand = new RelayCommand(OnSubmit);

            _ = FetchCounties();
        }

        public async Task FetchCounties()
        {
            Counties = await _api.GetAsync<IEnumerable<string>>("/megye");
            Changed(nameof(Counties));
        }

        public void ResetForm()
        {
            Id = null;
            Name = null;
            City = null;
            ZipCode = null;
            SelectedCounty = null;
        }

        private async void OnSubmit(object? obj)
        {
            var errors = new List<string>();


            string?[] requiredFields = [Id, Name, City, ZipCode, SelectedCounty];

            if (requiredFields.Any(string.IsNullOrWhiteSpace))
            {
                errors.Add("Kérem töltsön ki minden mezőt!");
            }

            if (!int.TryParse(Id, out _))
            {
                errors.Add($"Az azonosító csak szám lehet!");
            }

            if (string.IsNullOrWhiteSpace(Name) || !char.IsUpper(Name[0]))
            {
                errors.Add($"A fürdő neve csak nagybetűvel kezdődhet!");
            }

            if (string.IsNullOrWhiteSpace(Name) || Name.Length < 5)
            {
                errors.Add($"A fürdő nevének minimum 5 karakterből kell állnia!");
            }

            if (string.IsNullOrWhiteSpace(City) || !char.IsUpper(City[0]))
            {
                errors.Add($"A település neve csak nagybetűvel kezdődhet!");
            }

            if (string.IsNullOrWhiteSpace(City) || City.Length < 2)
            {
                errors.Add($"A település nevének minimum 2 karakterből kell állnia!");
            }

            if (!int.TryParse(ZipCode, out int val) || val < 1000 || val > 9999)
            {
                errors.Add($"Az irányítószám csak négyjegyű szám lehet!");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors),
                    "Hiba",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            var result = await _api.PostAsync<IEnumerable<string>?>("/furdo", new
            {
                Id = int.Parse(Id!),
                Name,
                City,
                ZipCode = int.Parse(ZipCode!),
                County = SelectedCounty
            });

            if (result is not null)
            {
                MessageBox.Show(string.Join("\n", result),
                    "Hiba",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            ResetForm();

            MessageBox.Show("Fürdő sikeresen létrehozva",
                "Sikeres létrehozás",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
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
