namespace KarbantartasLib
{
    public partial class Szakterulet
    {
        public int SzakteruletId { get; set; }
        public string Megnevezes { get; set; } = null!;

        public virtual ICollection<Szerelo> Szerelok { get; set; } = [];
    }
}
