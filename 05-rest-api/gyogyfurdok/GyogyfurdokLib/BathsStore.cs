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

        public bool AddNew(Bath bath, out List<string> errors)
        {
            errors = [];

            if (_baths.Any(x => x.Id == bath.Id))
            {
                errors.Add("Bath with this \"ID\" already exists");
            }

            if (_baths.Any(x => x.Name == bath.Name))
            {
                errors.Add("Bath with this \"Name\" already exists");
            }

            if (errors.Count > 0) return false;

            _baths.Add(bath);
            return true;
        }
    }
}
