namespace RotaryLib
{
    public static class MapErrorToHungarian
    {
        private static readonly Dictionary<string, string> _errorMap = new()
        {
            { "Record with this entry number already exists", "Már létezik rekord ezzel a rajtszámmal" },
            { "Record with this position already exists", "Már létezik rekord ezzel a pozícióval" },
            { "Record with this category position already exists", "Már létezik rekord ezzel a kategóriánkénti pozícióval" },
            { "Record with this gender position already exists", "Már létezik rekord ezzel a nemenkénti pozícióval" }
        };

        public static string Map(string english)
        {
            if (string.IsNullOrWhiteSpace(english)) return english;

            return _errorMap.TryGetValue(english, out var hungarian)
                ? hungarian
                : english;
        }

        public static IEnumerable<string> MapAll(IEnumerable<string> english)
        {
            foreach (var message in english)
            {
                yield return Map(message);
            }
        }
    }
}
