namespace GyogyfurdokLib
{
    public class BathsStore
    {
        private readonly List<Bath> _baths = File
            .ReadAllLines("Input/gyogyfurdok.csv")
            .Skip(1)
            .Select(Bath.FromCSV)
            .OfType<Bath>()
            .ToList();

        public IEnumerable<Bath> GetAll() => _baths;

        public Bath? GetById(int id) => _baths.FirstOrDefault(x => x.Id == id);
    }
}
