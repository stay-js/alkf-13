namespace FCPlayersLib
{
    public readonly record struct PlayerStats
    {
        public readonly int PlayerId { get; init; }
        public readonly int Pace { get; init; }
        public readonly int Shooting { get; init; }
        public readonly int Passing { get; init; }
        public readonly int Dribbling { get; init; }
        public readonly int Defending { get; init; }
        public readonly int Physical { get; init; }

        public PlayerStats(string line)
        {
            string[] parts = line.Split(';');

            PlayerId = int.Parse(parts[0]);
            Pace = int.Parse(parts[1]);
            Shooting = int.Parse(parts[2]);
            Passing = int.Parse(parts[3]);
            Dribbling = int.Parse(parts[4]);
            Defending = int.Parse(parts[5]);
            Physical = int.Parse(parts[6]);
        }
    }
}
