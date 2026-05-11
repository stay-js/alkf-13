namespace TanacsadoLib
{
    public partial class Ugyfel
    {
        public int UgyfelId { get; set; }
        public string Nev { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Talalkozo> Talalkozok { get; set; } = [];
    }
}
