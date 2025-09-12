namespace TanacsadoLib
{
    public class Specialization
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public Specialization(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
        }

        public override string ToString() => Name;
    }
}
