namespace TudomanyosLib
{
    public partial class Szekciok
    {
        public int SzekcioId { get; set; }
        public string Kategoria { get; set; } = null!;
        public int Ar { get; set; }

        public virtual ICollection<Program> Programok { get; set; } = [];
    }
}
