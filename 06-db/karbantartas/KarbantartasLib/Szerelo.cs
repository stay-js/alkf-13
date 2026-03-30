namespace KarbantartasLib
{
    public partial class Szerelo
    {
        public int SzereloId { get; set; }
        public int SzakteruletId { get; set; }
        public string Nev { get; set; } = null!;
        public string Cim { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public int Oradij { get; set; }

        public virtual Szakterulet Szakterulet { get; set; } = null!;

        public virtual ICollection<Karbantartas> Karbantartasok { get; set; } = [];

        public double Kereset => Karbantartasok.Sum(x => x.Ar);
    }
}
