using KabelTVLib;

DataStore.Initialize();
if (DataStore.Instance is not DataStore ds) return;

Console.WriteLine("5. feladat");
var pestCounty = ds.Areas.FirstOrDefault(x => x.Name == "Pest");
int? firstYear = pestCounty?
    .Cabels
    .OrderBy(x => x.Year)
    .First(x => x.Subscriptions >= 300_000)
    .Year;
Console.WriteLine($"\tPest megyében az előfizetők száma meghaladta a 300 ezret: {firstYear}");

Console.Write("6. feladat: A keresett év: ");
int year = int.Parse(Console.ReadLine() ?? string.Empty);
int total = ds
    .Regions
    .First(x => x.Name == "Közép-Dunántúl")
    .TotalSubscriptions(year);

Console.WriteLine(total == 0
    ? "\tEbből az évből nincs adatunk"
    : $"\tKözép-Dunántúlon a {year}. évben {total} lakásban volt kábeltévé.");

Console.WriteLine("7. feladat: A legnagyobb arányú kábeltévé előfizetés növekedés:");
var maxGrowthArea = ds
    .Areas
    .OrderByDescending(x => x.Growth(2003, 2019))
    .First();
Console.WriteLine($"\t{maxGrowthArea.Name} vármegye: {maxGrowthArea.Growth(2003, 2019)}%");

Console.WriteLine("8. feladat: A legtöbb előfizetővel rendelkező régiók (2019):");
var topThreeRegions = ds
    .Regions
    .OrderByDescending(x => x.TotalSubscriptions(2019))
    .Take(3)
    .Select(x => $"{x.Name}: {x.TotalSubscriptions(2019)}");
Console.WriteLine($"\t{string.Join("\n\t", topThreeRegions)}");
