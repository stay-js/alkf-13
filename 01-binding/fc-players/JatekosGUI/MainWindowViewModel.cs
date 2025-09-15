using FCPlayersLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace JatekosGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel() => DataStore.Initialize();

        public event PropertyChangedEventHandler? PropertyChanged;

        public static IEnumerable<Country>? Countries => DataStore.Instance?.Countries;
        public IEnumerable<Player>? AvailablePlayers =>
            SelectedCountry is null
            ? null
            : DataStore.Instance?.Players.Where(x => x.CountryId == SelectedCountry?.Id);

        private Country? selectedCountry;
        private Player? selectedPlayer;

        public bool IsCountrySelected => SelectedCountry is not null;
        public Visibility CardVisibility => SelectedPlayer is not null
            ? Visibility.Visible
            : Visibility.Hidden;
        public string SelectedPlayerPhotoPath => $"images/players/{SelectedPlayer?.Name}.png";
        public string SelectedCountryFlagPath => $"images/flags/{SelectedCountry?.Name}.png";

        public Country? SelectedCountry
        {
            get => selectedCountry;
            set
            {
                selectedCountry = value;

                Changed(nameof(IsCountrySelected));
                Changed(nameof(AvailablePlayers));
                Changed(nameof(SelectedCountryFlagPath));
            }
        }

        public Player? SelectedPlayer
        {
            get => selectedPlayer;
            set
            {
                selectedPlayer = value;

                Changed();
                Changed(nameof(CardVisibility));
                Changed(nameof(SelectedPlayerPhotoPath));
            }
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
