using Microsoft.EntityFrameworkCore;
using TanciskolaLib;

var db = new TanciskolaContext();

#region 5. feladat
int ketTanarosOrakSzama = await db.Orarendek.CountAsync(x => x.Tanar2 != null);
Console.WriteLine($"5. feladat: {ketTanarosOrakSzama} órát tart 2 tánctanár");
#endregion

#region 6. feladat
Console.Write("6. feladat: A tánctanár neve: ");
string nev = Console.ReadLine() ?? "";

var tanar = await db.Tanarok.FirstOrDefaultAsync(x => x.Nev == nev);
if (tanar is null)
{
    Console.WriteLine("\tIlyen néven nem található tánctanár");
}
else
{
    Console.WriteLine($"\tEmail: {tanar.Email}");
}
#endregion

#region 7. feladat
var tanarok = await db
    .Tanarok
    .Include(t => t.OrarendTanar1Navigations)
        .ThenInclude(o => o.SzintNavigation)
    .Include(t => t.OrarendTanar2Navigations)
        .ThenInclude(o => o.SzintNavigation)
    .ToListAsync();

var haromLegtobbetKereso = tanarok.OrderByDescending(x => x.Kereset()).Take(3);

Console.WriteLine("7. feladat: A 3 legtöbbet kereső tánctanár:");
foreach (var item in haromLegtobbetKereso)
{
    Console.WriteLine($"\t{item.Nev}: {item.Kereset()} Ft");
}
#endregion
