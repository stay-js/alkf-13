namespace KabelTVLib
{
    public readonly record struct Cabel(int Id, int AreaId, int Year, int Subscriptions)
    {
        public static Cabel FromCSV(string line)
        {
            string[] parts = line.Split(';');
            return new Cabel(int.Parse(parts[0]),
                int.Parse(parts[1]),
                int.Parse(parts[2]),
                int.Parse(parts[3]));
        }
    }
}
