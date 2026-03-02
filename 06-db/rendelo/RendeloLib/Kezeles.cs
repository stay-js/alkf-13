namespace RendeloLib
{
    public partial class Kezeles
    {
        public int KezelesId { get; set; }
        public int PaciensId { get; set; }
        public int OrvosId { get; set; }
        public DateOnly Datum { get; set; }
        public int Kezdesido { get; set; }
        public int Idotartam { get; set; }
        public string Megjegyzes { get; set; } = null!;

        public virtual Orvos Orvos { get; set; } = null!;
        public virtual Paciens Paciens { get; set; } = null!;

        public int Ar => Orvos.Oradij * Idotartam;
    }
}
