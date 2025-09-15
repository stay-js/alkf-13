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

        public IEnumerable<string>? AvailableModells => DataStore
            .Instance?
            .Cars
            .Where(x => x.Make == SelectedMake)
            .Select(x => x.Modell);

        private string? selectedMake = null;
        private string? selectedModell = null;

        public bool IsMakeSelected => selectedMake is not null;

        public string? SelectedMake
        {
            get => selectedMake;
            set
            {
                selectedMake = value;

                Changed(nameof(IsMakeSelected));
                Changed(nameof(AvailableModells));
            }
        }

        public string? SelectedModell
        {
            get => selectedModell;
            set
            {
                selectedModell = value;

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
                    .FirstOrDefault(x => x.Modell == SelectedModell);

                return car is null
                    ? string.Empty
                    : $"{car.Make[0]}{car.Modell[0]}{car.Fuel[0]}-{Random.Shared.Next(100, 999)}";
            }
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
