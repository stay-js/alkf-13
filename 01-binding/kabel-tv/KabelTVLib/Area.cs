namespace KabelTVLib
{
    public record Area(int Id, string Name, int RegionId)
    {
        public static Area FromCSV(string line)
        {
            string[] parts = line.Split(';');
            return new Area(int.Parse(parts[0]), parts[1], int.Parse(parts[2]));
        }

        public IEnumerable<Cabel> Cabels => DataStore
            .Instance!
            .Cabels
            .Where(x => x.AreaId == Id);

        public int Growth(int start, int end)
        {
            int first = Cabels.FirstOrDefault(x => x.Year == start).Subscriptions;
            int last = Cabels.FirstOrDefault(x => x.Year == end).Subscriptions;

            if (first == 0) return 0;

            double growth = ((double)(last - first) / first) * 100;

            return (int)Math.Round(growth);
        }

        public override string ToString() => Name;
    }
}
