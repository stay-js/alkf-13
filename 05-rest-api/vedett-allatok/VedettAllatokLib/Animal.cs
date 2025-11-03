namespace VedettAllatokLib
{
    public record Animal(int Id, string Name, int Value, int Year, string Category)
    {
        public static Animal FromCSV(string line)
        {
            string[] parts = line.Split(';');

            return new Animal(int.Parse(parts[0]),
                parts[1],
                int.Parse(parts[2]),
                int.Parse(parts[3]),
                parts[4]);
        }

        public static Animal FromAnimalData(int id, AnimalData data) =>
            new(id, data.Name, data.Value, data.Year, data.Category);
    }

    public readonly record struct AnimalData(string Name, int Value, int Year, string Category);
}
