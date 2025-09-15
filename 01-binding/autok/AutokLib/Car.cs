namespace AutokLib
{
    public record Car
    {
        public string Make { get; init; }
        public string Model { get; init; }
        public string Fuel { get; init; }
        public string Color { get; init; }

        public Car(string line)
        {
            string[] parts = line.Split(';');

            Make = parts[0];
            Model = parts[1];
            Fuel = parts[2];
            Color = parts[3];
        }

        public override string ToString() =>
            $"{Make} - {Model} ({Fuel}), {Color}, " +
            DataStore.Instance?.Owners.FirstOrDefault(x => x.Model == Model)?.Name;
    }
}
