namespace TanacsadoLib
{
    public partial class Szakterulet
    {
        public int SzakteruletId { get; set; }
        public string Megnevezes { get; set; } = null!;

        public virtual ICollection<Tanacsado> Tanacsadok { get; set; } = [];
    }
}
