using GyogyfurdokLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GyogyfurdokGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _api;

        public event PropertyChangedEventHandler? PropertyChanged;

        private string? selectedCounty;

        public IEnumerable<string>? Counties { get; set; }

        public string? SelectedCounty
        {
            get => selectedCounty;
            set => SetProperty(ref selectedCounty, value);
        }

        public MainWindowViewModel()
        {
            _api = new ApiClient();

            _ = FetchCounties();
        }

        public async Task FetchCounties()
        {
            Counties = await _api.GetAsync<IEnumerable<string>>("/megye");
            Changed(nameof(Counties));
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
