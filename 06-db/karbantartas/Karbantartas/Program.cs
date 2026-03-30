using KarbantartasLib;
using Microsoft.EntityFrameworkCore;

var db = new KarbantartasContext();

#region 5. feladat
int tobbMint4OrsaKarbantartasokSzama = await db
    .Karbantartasok
    .CountAsync(x => x.Javido >= 4);

Console.WriteLine($"5. feladat: {tobbMint4OrsaKarbantartasokSzama} " +
    "karbantartás tartott legalább 4 órát");
#endregion

#region 6. feladat
Console.Write("6. feladat: A szerelő neve: ");
string nev = Console.ReadLine() ?? "";

var szerelo = await db
    .Szerelok
    .Include(x => x.Szakterulet)
    .FirstOrDefaultAsync(x => x.Nev == nev);

if (szerelo is null)
{
    Console.WriteLine("\tIlyen néven nem található szerelő");
}
else
{
    Console.WriteLine($"\tTelefon: {szerelo.Telefon}" +
        $"\n\tCím: {szerelo.Cim}" +
        $"\n\tSzakterület: {szerelo.Szakterulet.Megnevezes}" +
        $"\n\tÓradíj: {szerelo.Oradij} Ft");
}
#endregion

#region 7. feladat
var szerelok = await db
    .Szerelok
    .Include(x => x.Karbantartasok)
        .ThenInclude(x => x.Megrendelo)
    .ToListAsync();

var haromLegtobbetKeresoSzerelo = szerelok
    .OrderByDescending(x => x.Kereset)
    .Take(3);

Console.WriteLine("7. feladat: A 3 legtöbbet kereső szerelő:");
foreach (var item in haromLegtobbetKeresoSzerelo)
{
    Console.WriteLine($"\t{item.Nev}: {item.Kereset} Ft");
}
#endregion
