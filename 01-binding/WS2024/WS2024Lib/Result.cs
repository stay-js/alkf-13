namespace WS2024Lib
{
    public record Result(int Id,
        int SkillId,
        string Name,
        int NationId,
        int Score,
        string Award)
    {
        public static Result FromCSV(string line)
        {
            string[] parts = line.Split(';');

            return new Result(int.Parse(parts[0]),
                int.Parse(parts[1]),
                parts[2],
                int.Parse(parts[3]),
                int.Parse(parts[4]),
                parts[5]);
        }

        public bool GotExcellenceAward => Score >= 700
            && !new string[] { "Gold", "Silver", "Bronze" }.Contains(Award);

        public string Medal
        {
            get
            {
                string medal = "No Award";

                if (Award != string.Empty) medal = Award;
                if (GotExcellenceAward) medal = "Medallion for Excellence";
                
                return medal;
            }
        }

        public Nation? Nation => DataStore
            .Instance?
            .Nations
            .FirstOrDefault(x => x.Id == NationId);

        public It? It => DataStore
            .Instance?
            .Its
            .FirstOrDefault(x => x.Id == SkillId);

        public override string ToString() => Name;
    }
}
