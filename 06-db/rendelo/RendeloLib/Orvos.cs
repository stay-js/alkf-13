namespace RendeloLib
{
    public partial class Orvos
    {
        public int OrvosId { get; set; }
        public int SzakteruletId { get; set; }
        public string Nev { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public int Oradij { get; set; }

        public virtual ICollection<Kezeles> Kezelesek { get; set; } = [];

        public virtual Szakterulet Szakterulet { get; set; } = null!;

        public int Bevetel => Kezelesek.Sum(x => x.Ar);
    }
}
