namespace TanciskolaLib
{
    public partial class Szint
    {
        public int SzintId { get; set; }
        public string Kategoria { get; set; } = null!;
        public int Ar { get; set; }

        public virtual ICollection<Orarend> Orarendek { get; set; } = new List<Orarend>();
    }
}
