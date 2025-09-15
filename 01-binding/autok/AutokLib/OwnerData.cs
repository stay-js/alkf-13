namespace AutokLib
{
    public readonly record struct OwnerData
    {
        public readonly int OwnerId { get; init; }
        public readonly int BirthYear { get; init; }
        public readonly string Sex { get; init; }

        public OwnerData(string line)
        {
            string[] parts = line.Split(';');

            OwnerId = int.Parse(parts[0]);
            BirthYear = int.Parse(parts[1]);
            Sex = parts[2];
        }
    }
}
