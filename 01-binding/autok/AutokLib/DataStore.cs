namespace AutokLib
{
    public class DataStore
    {
        private readonly List<Car> _cars;
        private readonly List<Owner> _owners;
        private readonly List<OwnerData> _ownerData;

        public IEnumerable<Car> Cars => _cars;
        public IEnumerable<Owner> Owners => _owners;
        public IEnumerable<OwnerData> OwnerData => _ownerData;

        private DataStore()
        {
            _cars = File
                .ReadAllLines("input/autok.csv")
                .Skip(1)
                .Select(line => new Car(line))
                .ToList();

            _owners = File
                .ReadAllLines("input/tulajdonosok.csv")
                .Skip(1)
                .Select(line => new Owner(line))
                .ToList();

            _ownerData = File
                .ReadAllLines("input/tulajdonosadatok.csv")
                .Skip(1)
                .Select(line => new OwnerData(line))
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
