namespace RendeloLib
{
    public partial class Szakterulet
    {
        public int SzakteruletId { get; set; }
        public string Nev { get; set; } = null!;

        public virtual ICollection<Orvos> Orvosok { get; set; } = [];
    }
}
