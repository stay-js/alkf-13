namespace TanciskolaLib
{
    public partial class Tanar
    {
        public int TanarId { get; set; }
        public string Nev { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Orarend> OrarendTanar1Navigations { get; set; } = new List<Orarend>();
        public virtual ICollection<Orarend> OrarendTanar2Navigations { get; set; } = new List<Orarend>();

        public double Kereset()
        {
            double kereset = 0;

            foreach (var orarend in OrarendTanar1Navigations)
            {
                if (orarend.Tanar2 != null) kereset += orarend.Bevetel / 4;
                else kereset += orarend.Bevetel / 2;
            }

            foreach (var orarend in OrarendTanar2Navigations)
            {
                kereset += orarend.Bevetel / 4;
            }

            return kereset;
        }
    }
}
