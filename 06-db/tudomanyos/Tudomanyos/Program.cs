using Microsoft.EntityFrameworkCore;
using TudomanyosLib;

var db = new TudomanyosContext();

#region 5. feladat
int ketEloadosEloadasokSzama = await db
    .Programok
    .CountAsync(x => x.Eloadok2 != null);

Console.WriteLine($"5. feladat: {ketEloadosEloadasokSzama} előadást tart 2 előadó");
#endregion

#region 6. feladat
Console.Write("6. feladat: Az előadó neve: ");

string nev = Console.ReadLine() ?? "";
var eloado = await db.Eloadok.FirstOrDefaultAsync(x => x.Nev == nev);

if (eloado is null)
{
    Console.WriteLine("\tIlyen néven nem található előadó");
}
else
{
    Console.WriteLine($"\tEmail: {eloado.Email}");
}
#endregion

#region 7. feladat
var osszesEloado = await db
    .Eloadok
    .Include(x => x.ProgramEloadok1Navigations)
        .ThenInclude(x => x.SzekcioNavigation)
    .Include(x => x.ProgramEloadok2Navigations)
        .ThenInclude(x => x.SzekcioNavigation)
    .ToListAsync();

var haromLegtobbetKeresoEloado = osszesEloado
    .OrderByDescending(x => x.Kereset)
    .Take(3);

/**
 * Hibás a minta, mert csak azokat az előadásokat veszi figyelembe,
 * ahol az előadó, előadó1-ként szerepel, ahol előadó2-ként azokat nem.
 **/

Console.WriteLine("7. feladat: A 3 legtöbbet kereső előadó:");
foreach (var item in haromLegtobbetKeresoEloado)
{
    Console.WriteLine($"\t{item.Nev} - {item.Kereset} Ft");
}
#endregion
