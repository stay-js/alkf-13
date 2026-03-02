namespace RendeloLib
{
    public partial class Paciens
    {
        public int PaciensId { get; set; }
        public string Nev { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public DateOnly Szuletett { get; set; }

        public virtual ICollection<Kezeles> Kezelesek { get; set; } = [];
    }
}
