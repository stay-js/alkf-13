using Microsoft.EntityFrameworkCore;
using TanacsadoLib;

var db = new TanacsadoContext();

#region 5. feladat
int legalabbHaromOrasTalalkozokSzama = await db
    .Talalkozok
    .CountAsync(x => x.Idotartam >= 3);

Console.WriteLine($"5. feladat: {legalabbHaromOrasTalalkozokSzama} " +
    "találkozó tartott legalább 3 órát");
#endregion

#region 6. feladat
Console.Write("6. feladat: A tanácsadó neve: ");

string nev = Console.ReadLine() ?? "";
var tanacsado = await db
    .Tanacsadok
    .Include(x => x.Szakterulet)
    .FirstOrDefaultAsync(x => x.Nev == nev);

if (tanacsado is null)
{
    Console.WriteLine("\tIlyen néven nem található tanácsadó");
}
else
{
    Console.WriteLine($"\tTelefon: {tanacsado.Telefon}" +
        $"\n\tEmail: {tanacsado.Email}" +
        $"\n\tSzakterület: {tanacsado.Szakterulet.Megnevezes}" +
        $"\n\tÓradíj: {tanacsado.Oradij} Ft");
}
#endregion

#region 7. feladat
var osszesTanacsado = await db.Tanacsadok.Include(x => x.Talalkozok).ToListAsync();

var haromLegtobbetKeresoTanacsado = osszesTanacsado
    .OrderByDescending(x => x.Kereset)
    .Take(3);

Console.WriteLine("7. feladat: A 3 legtöbbet kereső tanácsadó:");
foreach (var item in haromLegtobbetKeresoTanacsado)
{
    Console.WriteLine($"\t{item.Nev}: {item.Kereset} Ft");
}
#endregion
