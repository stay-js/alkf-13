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

        public IEnumerable<int> GetCategories() => _results
            .Select(x => x.Category)
            .Distinct()
            .Order();

        public IEnumerable<string> GetCountryCodes() => _results
            .Select(x => x.CountryCode)
            .Distinct()
            .Order();

        public bool AddNew(Result result, out List<string> errors)
        {
            errors = [];

            if (_results.Any(x => x.EntryNumber == result.EntryNumber))
            {
                errors.Add("Record with this entry number already exists");
            }

            if (_results.Any(x => x.Position == result.Position))
            {
                errors.Add("Record with this position already exists");
            }

            if (_results.Any(x => x.Category == result.Category
                && x.CategoryPosition == result.CategoryPosition))
            {
                errors.Add("Record with this category position already exists");
            }

            if (_results.Any(x => x.Gender == result.Gender
            && x.GenderPosition == result.GenderPosition))
            {
                errors.Add("Record with this gender position already exists");
            }

            if (errors.Count > 0) return false;

            _results.Add(result);
            return true;
        }
    }
}
