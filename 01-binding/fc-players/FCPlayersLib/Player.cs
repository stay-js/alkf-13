namespace FCPlayersLib
{
    public record Player
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int CountryId { get; init; }
        public string Position { get; init; }
        public Leg PreferedLeg { get; init; }

        public Player(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
            CountryId = int.Parse(parts[2]);
            Position = parts[3];
            PreferedLeg = parts[4] == "Jobb" ? Leg.Right : Leg.Left;
        }

        public PlayerStats? Stats => DataStore
            .Instance?
            .PlayerStats
            .FirstOrDefault(x => x.PlayerId == Id);

        public Country? Country => DataStore
            .Instance?
            .Countries
            .FirstOrDefault(x => x.Id == CountryId);

        public int AvgStat => (int)Math.Round(Stats?
            .GetType()
            .GetProperties()
            .Where(x => x.PropertyType == typeof(int) && x.Name != "PlayerId")
            .Select(x => Convert.ToInt32(x.GetValue(Stats)))
            .Average() ?? 0, MidpointRounding.AwayFromZero);

        public static string FormattedStatsHeading => "PAC SHO PAS DRI DEF PHY";
        public string FormattedStats =>
            $"\n{Stats?.Pace}" +
            $"    {Stats?.Shooting}" +
            $"    {Stats?.Passing}" +
            $"    {Stats?.Dribbling}" +
            $"    {Stats?.Defending}" +
            $"    {Stats?.Physical}";

        public override string ToString() => Name;
    }
}
