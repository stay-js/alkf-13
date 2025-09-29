using WS2024Lib;

DataStore.Initialize();
if (DataStore.Instance is not DataStore ds) return;

Console.WriteLine($"5. feladat: Kínához tartozó régiók száma: " +
    ds.Nations.Count(x => x.Region.Contains("China")));

Console.Write("6. fealdat: Versenyző neve: ");
string name = Console.ReadLine() ?? string.Empty;

var result = ds
    .Results
    .FirstOrDefault(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase));

if (result is null)
{
    Console.WriteLine("\tIlyen néven nem található versenyző");
}
else
{
    Console.WriteLine($"\tOrszág: {result.Nation?.Region}" +
        $"\n\tSzakma: {result.It?.Skill}" +
        $"\n\tPontszám: {result.Score}" +
        $"\n\tÉrem: {result.Medal}");
}

Console.WriteLine("7. feladat: A 7 legtöbb pontot szerző ország az érmek alapján:");
var topSevenCountries = ds
    .Nations
    .OrderByDescending(x => x.PointsByMedal)
    .Take(7)
    .Select(x => $"{x.Region}: {x.PointsByMedal} pont");
Console.WriteLine("\t" + string.Join("\n\t", topSevenCountries));
