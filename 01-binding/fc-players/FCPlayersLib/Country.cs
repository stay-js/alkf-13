namespace FCPlayersLib
{
    public readonly record struct Country
    {
        public readonly int Id { get; init; }
        public readonly string Name { get; init; }

        public Country(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
        }

        public override string ToString() => Name;
    }
}
