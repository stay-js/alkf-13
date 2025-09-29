namespace WS2024Lib
{
    public class DataStore
    {
        private readonly List<Nation> _nations;
        private readonly List<It> _its;
        private readonly List<Result> _results;

        public IEnumerable<Nation> Nations => _nations;
        public IEnumerable<It> Its => _its;
        public IEnumerable<Result> Results => _results;

        private DataStore()
        {
            _nations = File
                .ReadAllLines("input/nation.csv")
                .Skip(1)
                .Select(Nation.FromCSV)
                .ToList();

            _its = File
                .ReadAllLines("input/it.csv")
                .Skip(1)
                .Select(It.FromCSV)
                .ToList();

            _results = File
                .ReadAllLines("input/result.csv")
                .Skip(1)
                .Select(Result.FromCSV)
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
