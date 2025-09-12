using TanacsadoLib;

DataStore.Initialize();
if (DataStore.Instance is null) return;

Console.WriteLine("5. feladat: " +
    DataStore.Instance.Meetings.Count(x => x.Duration >= 3) +
    " találkozó tartott legalább 3 órát");


Console.Write("6. feladat: A tanácsadó neve: ");

string name = Console.ReadLine() ?? "";
var advisor = DataStore
    .Instance
    .Advisors
    .FirstOrDefault(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase));

if (advisor is null)
{
    Console.WriteLine("\tIlyen néven nem található tanácsadó");
}
else
{
    Console.WriteLine($"\tTelefon: {advisor.Phone}" +
        $"\n\tEmail: {advisor.Email}" +
        $"\n\tSzakterület: " +
        DataStore.Instance.Specializations.First(x => x.Id == advisor.SpecializationId).Name +
        $"\n\tÓradíj: {advisor.HourlyRate} Ft");
}

Console.WriteLine("7. feladat: A 3 legtöbbet kereső tanácsadó:");
var topThreeEarningAdvisor = DataStore
    .Instance
    .Advisors
    .OrderByDescending(x => x.TotalEarnings)
    .Take(3)
    .Select(x => $"{x.Name}: {x.TotalEarnings} Ft");
Console.WriteLine("\t" + string.Join("\n\t", topThreeEarningAdvisor));
