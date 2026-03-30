namespace KarbantartasLib
{
    public partial class Karbantartas
    {
        public int KarbantartasId { get; set; }
        public int SzereloId { get; set; }
        public int MegrendeloId { get; set; }
        public DateOnly Datum { get; set; }
        public int Javido { get; set; }

        public virtual Szerelo Szerelo { get; set; } = null!;
        public virtual Megrendelo Megrendelo { get; set; } = null!;

        public double Ar => Javido * Szerelo.Oradij * (1 - (Megrendelo.Kedvezmeny / 100.0));
    }
}
