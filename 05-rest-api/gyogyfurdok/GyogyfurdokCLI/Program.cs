using GyogyfurdokLib;

var api = new ApiClient();

var allBaths = await api.GetAsync<IEnumerable<Bath>>("/furdo");

#region 3.a
Console.WriteLine("3.a feladat: Összesen " +
    allBaths.Count(x => x.City == "Budapest") +
    " gyógyfürdő található Budapesten.");
#endregion

#region 3.b
Console.Write("3.b feladat: Adjon meg egy ID-t: ");
string? id = Console.ReadLine();

try
{
    var result = await api.GetAsync<Bath>($"/furdo/{id}");
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt: {ex.Message}");
}
#endregion

#region 3.c
Console.WriteLine("3.c feladat: Legalább 2 fürdővel rendelkező települések: ");

var bathsByCityHavingAtLeast2Baths = allBaths
    .GroupBy(x => x.City)
    .ToDictionary(g => g.Key, g => g.Count())
    .Where(x => x.Value >= 2)
    .OrderBy(x => x.Key);

foreach (var city in bathsByCityHavingAtLeast2Baths)
{
    Console.WriteLine($"\t{city.Key}: {city.Value} fürdő");
}
#endregion
