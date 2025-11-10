namespace RotaryLib
{
    public class ResultsStore
    {
        private readonly List<Result> _results = File
            .ReadAllLines("Input/eredmenyek.csv")
            .Skip(1)
            .Select(Result.FromCSV)
            .OfType<Result>()
            .ToList();

        public IEnumerable<Result> GetAll() => _results;

        public Result? GetByEntryNumber(int entryNumber) => _results
            .FirstOrDefault(x => x.EntryNumber == entryNumber);

        public bool AddNew(Result result)
        {
            if (_results.Any(x => x.EntryNumber == result.EntryNumber)) return false;

            _results.Add(result);
            return true;
        }
    }
}
