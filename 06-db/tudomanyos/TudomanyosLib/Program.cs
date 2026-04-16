namespace TudomanyosLib
{
    public partial class Program
    {
        public int ProgramId { get; set; }
        public string Datum { get; set; } = null!;
        public string KezdoIdopont { get; set; } = null!;
        public int Hossz { get; set; }
        public int Tema { get; set; }
        public int Szekcio { get; set; }
        public int Eloadok1 { get; set; }
        public int? Eloadok2 { get; set; }
        public int Terem { get; set; }
        public int Letszam { get; set; }

        public virtual Eloadok Eloadok1Navigation { get; set; } = null!;
        public virtual Eloadok? Eloadok2Navigation { get; set; }
        public virtual Szekciok SzekcioNavigation { get; set; } = null!;
        public virtual Temak TemaNavigation { get; set; } = null!;

        public double Bevetel => Letszam * (Hossz / 60.0) * SzekcioNavigation.Ar;
    }
}
