using RotaryLib;

var api = new ApiClient();

var allResults = await api.GetAsync<IEnumerable<Result>>("/results");

var categories = allResults
    .GroupBy(x => x.Category)
    .ToDictionary(g => g.Key, g => g.Count());

#region 3.a
Console.WriteLine("3.a feladat: " +
    (allResults.Any(x => x.CountryCode != "HU") ? "Van" : "Nincs") +
    " külföldi versenyző az adatok között.");
#endregion

#region 3.b
Console.Write("3.b feladat: Adjon meg egy ID-t: ");
string? id = Console.ReadLine();

try
{
    var result = await api.GetAsync<Result>($"/results/{id}");
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt: {ex.Message}");
}
#endregion

#region 3.c
var firstWomen = allResults
    .Where(x => x.Gender == "Nő")
    .MinBy(x => x.GenderPosition);
Console.WriteLine($"3.c feladat: Első női versenyző:\n{firstWomen}");
#endregion

#region 3.d
Console.WriteLine("3.d feladat:");

foreach (var category in categories)
{
    var winner = allResults
        .Where(x => x.Category == category.Key)
        .MinBy(x => x.CategoryPosition);

    Console.WriteLine($"{category.Key}. kategória győztese:\n{winner}");
}
#endregion

#region 3.e
Console.WriteLine("3.e feladat:");

foreach (var category in categories)
{
    Console.WriteLine($"\t{category.Key}. kategória: {category.Value} versenyző");
}
#endregion
