namespace KabelTVLib
{
    public record Region(int Id, string Name)
    {
        public static Region FromCSV(string line)
        {
            string[] parts = line.Split(';');
            return new Region(int.Parse(parts[0]), parts[1]);
        }

        public IEnumerable<Area> Areas => DataStore
            .Instance!
            .Areas
            .Where(x => x.RegionId == Id);

        public int TotalSubscriptions(int year) => Areas
            .SelectMany(x => x.Cabels)
            .Where(x => x.Year == year)
            .Sum(x => x.Subscriptions);

        public override string ToString() => Name;
    }
}
