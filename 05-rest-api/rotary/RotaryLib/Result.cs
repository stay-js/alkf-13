namespace RotaryLib
{
    public record Result(int Position,
        int EntryNumber,
        int BirthYear,
        string City,
        string CountryCode,
        int Category,
        int CategoryPosition,
        string Gender,
        int GenderPosition,
        TimeOnly Time)
    {
        public static Result? FromCSV(string line)
        {
            string[] parts = line.Split(';');

            try
            {
                return new Result(int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    int.Parse(parts[2]),
                    parts[3],
                    parts[4],
                    int.Parse(parts[5]),
                    int.Parse(parts[6]),
                    parts[7],
                    int.Parse(parts[8]),
                    TimeOnly.Parse(parts[9]));
            }
            catch
            {
                return null;
            }
        }

        public override string ToString() => $"\tPozíció: {Position}" +
            $"\n\tRajtszám: {EntryNumber}" +
            $"\n\tSzületési év: {BirthYear}" +
            $"\n\tTelepülés: {City}" +
            $"\n\tOrszágkód: {CountryCode}" +
            $"\n\tKategória: {Category}" +
            $"\n\tKategóriában elért helyezés: {CategoryPosition}" +
            $"\n\tNem: {Gender}" +
            $"\n\tNemenkénti helyezés: {GenderPosition}" +
            $"\n\tFutás időtartama: {Time.ToLongTimeString()}";
    }
}
