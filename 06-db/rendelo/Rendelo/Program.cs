using Microsoft.EntityFrameworkCore;
using RendeloLib;

var db = new RendeloContext();

#region 5. feladat
int aprilisiKezelesekSzama = await db.Kezelesek.CountAsync(x => x.Datum.Month == 4);
Console.WriteLine($"5. feladat: {aprilisiKezelesekSzama} kezelés esett áprilisra.");
#endregion

#region 6. feladat
Console.Write("6. feladat: A páciens neve: ");
string nev = Console.ReadLine() ?? "";

var paciens = await db.Paciensek.FirstOrDefaultAsync(x => x.Nev == nev);
if (paciens is null)
{
    Console.WriteLine("\tIlyen néven nem található páciens");
}
else
{
    Console.WriteLine($"\tSzületési idő: {paciens.Szuletett}" +
        $"\n\tTelefon: {paciens.Telefon}");
}
#endregion

#region 7. feladat
var orvosok = await db
    .Orvosok
    .Include(x => x.Kezelesek)
    .Include(x => x.Szakterulet)
    .ToListAsync();

var otLegmagasabbBeveteluOrvos = orvosok
    .OrderByDescending(x => x.Bevetel)
    .ThenBy(x => x.Nev)
    .Take(5);

Console.WriteLine("7. feladat: Az 5 legmagasabb bevételű orvos:");
foreach (var orvos in otLegmagasabbBeveteluOrvos)
{
    Console.WriteLine($"\t{orvos.Nev} ({orvos.Szakterulet.Nev}): {orvos.Bevetel} Ft");
}
#endregion
