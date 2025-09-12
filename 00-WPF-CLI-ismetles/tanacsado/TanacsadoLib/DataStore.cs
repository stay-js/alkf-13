namespace TanacsadoLib
{
    public class DataStore
    {
        private readonly List<Advisor> _advisors;
        private readonly List<Customer> _customers;
        private readonly List<Meeting> _meetings;
        private readonly List<Specialization> _specializations;

        public IEnumerable<Advisor> Advisors => _advisors;
        public IEnumerable<Customer> Customers => _customers;
        public IEnumerable<Meeting> Meetings => _meetings;
        public IEnumerable<Specialization> Specializations => _specializations;

        private DataStore()
        {
            _advisors = File
                .ReadAllLines("input/tanacsado.csv")
                .Skip(1)
                .Select(line => new Advisor(line))
                .ToList();

            _customers = File
                .ReadAllLines("input/ugyfel.csv")
                .Skip(1)
                .Select(line => new Customer(line))
                .ToList();

            _meetings = File
                .ReadAllLines("input/talalkozo.csv")
                .Skip(1)
                .Select(line => new Meeting(line))
                .ToList();

            _specializations = File
                .ReadAllLines("input/szakterulet.csv")
                .Skip(1)
                .Select(line => new Specialization(line))
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
