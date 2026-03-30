namespace KarbantartasLib
{
    public partial class Megrendelo
    {
        public int MegrendeloId { get; set; }
        public string Nev { get; set; } = null!;
        public string Cim { get; set; } = null!;
        public int Kedvezmeny { get; set; }
        public string Telefon { get; set; } = null!;

        public virtual ICollection<Karbantartas> Karbantartasok { get; set; } = [];
    }
}
