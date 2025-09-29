namespace WS2024Lib
{
    public record Nation(int Id, string Code, string Region)
    {
        public static Nation FromCSV(string line)
        {
            string[] parts = line.Split(';');
            return new Nation(int.Parse(parts[0]), parts[1], parts[2]);
        }

        public int PointsByMedal => DataStore
            .Instance?
            .Results
            .Where(x => x.NationId == Id)
            .Select(x => x.Medal switch
            {
                "Gold" => 4,
                "Silver" => 3,
                "Bronze" => 2,
                "Medallion for Excellence" => 1,
                _ => 0
            })
            .Sum() ?? 0;
    }
}
