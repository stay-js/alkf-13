namespace TanacsadoLib
{
    public partial class Tanacsado
    {
        public int TanacsadoId { get; set; }
        public string Nev { get; set; } = null!;
        public int SzakteruletId { get; set; }
        public int Oradij { get; set; }
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual Szakterulet Szakterulet { get; set; } = null!;
        public virtual ICollection<Talalkozo> Talalkozok { get; set; } = [];

        public int Kereset => Talalkozok.Sum(x => x.Ar);
    }
}
