using AutokLib;

DataStore.Initialize();
if (DataStore.Instance is null) return;

Console.WriteLine("5. feladat: " +
    DataStore.Instance.Owners.Count(x => x.HasDriversLicense) +
    " jogosítvánnyal rendelkező tulajdonos található");

Console.WriteLine("6. feladat: Összes dízeles autó adatai");
var dieselCars = DataStore.Instance.Cars.Where(x => x.Fuel == "Dízel");
Console.WriteLine("\t" + string.Join("\n\t", dieselCars));

Console.Write("7. feladat: A tulajdonos neve: ");
string name = Console.ReadLine() ?? string.Empty;
var owner = DataStore
    .Instance
    .Owners
    .FirstOrDefault(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase));

if (owner is null)
{
    Console.WriteLine("\tIlyen néven nem található tulajdonos!");
}
else
{
    Console.WriteLine($"\tSzületési Év: {owner.OwnerData?.BirthYear}" +
        $"\n\tNév: {owner.Name}" +
        $"\n\tMárka: {owner.Car?.Make}" +
        $"\n\tModell: {owner.Model}" +
        $"\n\tJogosítvány: {(owner.HasDriversLicense ? "Van" : "Nincs")}");
}

Console.WriteLine("8. feladat: A 2 legidősebb dízel autó tulajdonos adatai");
var twoOldestDieselOwner = DataStore
    .Instance
    .Owners
    .Where(x => x.Car?.Fuel == "Dízel")
    .OrderBy(x => x.OwnerData?.BirthYear)
    .Take(2);
Console.WriteLine("\t" + string.Join("\n\t", twoOldestDieselOwner));
