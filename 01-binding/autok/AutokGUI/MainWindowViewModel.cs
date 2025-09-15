using AutokLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AutokGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel() => DataStore.Initialize();

        public event PropertyChangedEventHandler? PropertyChanged;

        public static IEnumerable<string>? Makes => DataStore
            .Instance?
            .Cars
            .Select(x => x.Make)
            .Distinct();

        public IEnumerable<string>? AvailableModels => DataStore
            .Instance?
            .Cars
            .Where(x => x.Make == SelectedMake)
            .Select(x => x.Model);

        private string? selectedMake = null;
        private string? selectedModel = null;

        public bool IsMakeSelected => selectedMake is not null;

        public string? SelectedMake
        {
            get => selectedMake;
            set
            {
                selectedMake = value;

                Changed(nameof(IsMakeSelected));
                Changed(nameof(AvailableModels));
            }
        }

        public string? SelectedModel
        {
            get => selectedModel;
            set
            {
                selectedModel = value;

                Changed(nameof(GeneratedLicencePlate));
            }
        }

        public string GeneratedLicencePlate
        {
            get
            {
                var car = DataStore
                    .Instance?
                    .Cars?
                    .FirstOrDefault(x => x.Model == SelectedModel);

                return car is null
                    ? string.Empty
                    : $"{car.Make[0]}{car.Model[0]}{car.Fuel[0]}-{Random.Shared.Next(100, 999)}";
            }
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
