namespace TanacsadoLib
{
    public partial class Talalkozo
    {
        public int TalalkozoId { get; set; }
        public int TanacsadoId { get; set; }
        public int UgyfelId { get; set; }
        public DateOnly Datum { get; set; }
        public TimeOnly Idopont { get; set; }
        public int Idotartam { get; set; }

        public virtual Tanacsado Tanacsado { get; set; } = null!;
        public virtual Ugyfel Ugyfel { get; set; } = null!;

        public int Ar => Idotartam * Tanacsado.Oradij;
    }
}
