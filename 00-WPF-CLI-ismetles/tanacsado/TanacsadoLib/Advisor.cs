namespace TanacsadoLib
{
    public class Advisor
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int SpecializationId { get; set; }
        public int HourlyRate { get; set; }
        public string Phone { get; init; }
        public string Email { get; init; }

        public Advisor(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            Name = parts[1];
            SpecializationId = int.Parse(parts[2]);
            HourlyRate = int.Parse(parts[3]);
            Phone = parts[4];
            Email = parts[5];
        }

        public int TotalEarnings => DataStore
            .Instance!
            .Meetings
            .Where(x => x.AdvisorId == Id)
            .Sum(x => x.Price);

        public override string ToString() => Name;
    }
}
