namespace GyogyfurdokLib
{
    public record Bath(int Id, string Name, string City, int ZipCode, string County)
    {
        public static Bath? FromCSV(string line)
        {
            string[] parts = line.Split(';');

            try
            {
                return new Bath(int.Parse(parts[0]),
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    parts[4]);
            }
            catch
            {
                return null;
            }
        }
    }
}
