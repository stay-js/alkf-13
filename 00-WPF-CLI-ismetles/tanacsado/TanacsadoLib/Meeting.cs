namespace TanacsadoLib
{
    public class Meeting
    {
        public int Id { get; init; }
        public int AdvisorId { get; set; }
        public int CustomerId { get; init; }
        public DateOnly Date { get; init; }
        public TimeOnly Time { get; init; }
        public int Duration { get; init; }

        public Meeting(string line)
        {
            string[] parts = line.Split(';');

            Id = int.Parse(parts[0]);
            AdvisorId = int.Parse(parts[1]);
            CustomerId = int.Parse(parts[2]);
            Date = DateOnly.Parse(parts[3]);
            Time = TimeOnly.Parse(parts[4]);
            Duration = int.Parse(parts[5]);
        }

        public int Price => Duration * DataStore
            .Instance!
            .Advisors
            .First(x => x.Id == AdvisorId)
            .HourlyRate;
    }
}
