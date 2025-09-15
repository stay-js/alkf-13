using FCPlayersLib;

DataStore.Initialize();
if (DataStore.Instance is not DataStore ds) return;

Console.WriteLine("5. feladat: " +
    ds.Players.Count(x => x.PreferedLeg == Leg.Left) +
    " bal lábas játékos található");

Console.Write("6. feladat: A játékos neve: ");
string name = Console.ReadLine() ?? "";
var player = ds
    .Players
    .FirstOrDefault(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

if (player is null)
{
    Console.WriteLine("\tIlyen néven nem található játékos!");
}
else
{
    Console.WriteLine($"\tNév: {player.Name}" +
        $"\n\tPozíció: {player.Position}" +
        $"\n\tOrszág: {player.Country?.Name}" +
        $"\n\tÁtlagos érték: {player.AvgStat}");
}

Console.WriteLine("7. feladat: A 4 legtöbb átlagos értékkel rendelkező játékos:");
var top4Player = ds
    .Players
    .OrderByDescending(x => x.AvgStat)
    .Take(4)
    .Select(x => $"{x.Name} - {x.AvgStat}");
Console.WriteLine($"\t{string.Join("\n\t", top4Player)}");
