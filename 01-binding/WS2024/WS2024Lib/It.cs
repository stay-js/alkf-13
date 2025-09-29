namespace WS2024Lib
{
    public readonly record struct It(int Id, string Skill)
    {
        public static It FromCSV(string line)
        {
            string[] parts = line.Split(';');
            return new It(int.Parse(parts[0]), parts[1]);
        }

        public override string ToString() => Skill;
    }
}
