using VedettAllatokCli;
using VedettAllatokLib;

var api = new ApiClient();

#region a. feladat
var allAnimals = await api.GetAsync<IEnumerable<Animal>>("/animals");
// innentől kezdve nem kéne Api request,
// mivel lekértünk minden védett állatot,
// de ebben a feladatban nyilván nem ez a lényeg...
var highestValue = allAnimals
    .GroupBy(x => x.Value)
    .OrderByDescending(x => x.Key)
    .First();

Console.WriteLine($"1. feladat: Legnagyobb eszmei érték: {highestValue.Key:C0}" +
    $"\n{highestValue.Key:C0} eszmei értékű állatok:" +
    string.Concat(highestValue.Select(x => $"\n\t- {x.Name}")));
#endregion

#region b. feladat
Console.Write("2. feladat: Adjon meg egy ID-t: ");
string? id = Console.ReadLine();
try
{
    var animal = await api.GetAsync<Animal>($"/animalsById/{id}");
    Console.WriteLine(animal);
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt: {ex.Message}");
}
#endregion

#region c. feladat
Console.Write("3. feladat: Adjon meg egy évet: ");
string? year = Console.ReadLine();
try
{
    var animals = await api.GetAsync<IEnumerable<Animal>>($"/animalsByYear/{year}");
    Console.WriteLine("A megadott évben védetté nyilvánított állatok:" +
        string.Concat(animals.Select(x => $"\n\t- {x.Name}")));
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt: {ex.Message}");
}
#endregion

#region d-e. feladat
var categories = await api.GetAsync<IEnumerable<string>>("/categories");
Console.WriteLine($"4. feladat: Kategóriák: {string.Join(", ", categories)}");

Console.WriteLine("5. feladat: Védett állatok mennyisége kategóriánként:");
foreach (string category in categories)
{
    var animals = await api.GetAsync<IEnumerable<Animal>>($"/animalsByCategory/{category}");
    Console.WriteLine($"\t- {category}: {animals.Count()} db");
}
#endregion
