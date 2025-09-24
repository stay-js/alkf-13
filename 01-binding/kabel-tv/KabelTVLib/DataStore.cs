namespace KabelTVLib
{
    public class DataStore
    {
        private readonly List<Region> _regions;
        private readonly List<Area> _areas;
        private readonly List<Cabel> _cabels;

        public IEnumerable<Region> Regions => _regions;
        public IEnumerable<Area> Areas => _areas;
        public IEnumerable<Cabel> Cabels => _cabels;

        private DataStore()
        {
            _regions = File
                .ReadAllLines("input/regio.csv")
                .Skip(1)
                .Select(Region.FromCSV)
                .ToList();

            _areas = File
                .ReadAllLines("input/terulet.csv")
                .Skip(1)
                .Select(Area.FromCSV)
                .ToList();

            _cabels = File
                .ReadAllLines("input/kabel.csv")
                .Skip(1)
                .Select(Cabel.FromCSV)
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
