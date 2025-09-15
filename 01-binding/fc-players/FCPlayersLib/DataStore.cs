namespace FCPlayersLib
{
    public class DataStore
    {
        private readonly List<Country> _countries;
        private readonly List<Player> _players;
        private readonly List<PlayerStats> _playerStats;

        public IEnumerable<Country> Countries => _countries;
        public IEnumerable<Player> Players => _players;
        public IEnumerable<PlayerStats> PlayerStats => _playerStats;

        private DataStore()
        {
            _countries = File
                .ReadAllLines("input/orszag.csv")
                .Skip(1)
                .Select(line => new Country(line))
                .ToList();

            _players = File
                .ReadAllLines("input/jatekosok.csv")
                .Skip(1)
                .Select(line => new Player(line))
                .ToList();

            _playerStats = File
                .ReadAllLines("input/jatekosadatok.csv")
                .Skip(1)
                .Select(line => new PlayerStats(line))
                .ToList();
        }

        public static DataStore? Instance { get; private set; }

        public static void Initialize()
        {
            if (Instance is not null)
                throw new InvalidOperationException("DataStore is already initialized.");

            Instance = new DataStore();
        }
    }
}
