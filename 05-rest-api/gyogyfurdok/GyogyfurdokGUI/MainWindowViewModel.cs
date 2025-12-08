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
            var data = new BathData(Id, Name, City, ZipCode, SelectedCounty);

            var validator = new BathDataValidator();
            var result = validator.Validate(data);

            if (!result.IsValid)
            {
                WarningMessageBox
                    .Show("- " + string.Join("\n- ", result.Errors.Select(x => x.ErrorMessage)));

                return;
            }

            var response = await _api.PostAsync<IEnumerable<string>?>("/furdo", data);

            if (response is not null)
            {
                WarningMessageBox.Show("- " + string.Join("\n- ", response));

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
