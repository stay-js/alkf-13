using KabelTVLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace KabelGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Region? selectedRegion = null;
        private Area? selectedArea = null;

        public MainWindowViewModel() => DataStore.Initialize();

        public static IEnumerable<Region>? Regions => DataStore.Instance?.Regions;
        public IEnumerable<Area>? AvailableAreas => SelectedRegion?.Areas;

        public bool IsRegionSelected => SelectedRegion is not null;
        public Visibility TableVisibility => SelectedArea is null
            ? Visibility.Hidden
            : Visibility.Visible;

        public Region? SelectedRegion
        {
            get => selectedRegion;
            set
            {
                selectedRegion = value;

                Changed(nameof(IsRegionSelected));
                Changed(nameof(AvailableAreas));
            }
        }

        public Area? SelectedArea
        {
            get => selectedArea;
            set
            {
                selectedArea = value;

                Changed(nameof(TableVisibility));
                Changed(nameof(SubscriptionsByYear));
            }
        }

        public IEnumerable<object>? SubscriptionsByYear => SelectedArea?
            .Cabels
            .OrderBy(x => x.Year)
            .Select(x => new { x.Year, x.Subscriptions });

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
