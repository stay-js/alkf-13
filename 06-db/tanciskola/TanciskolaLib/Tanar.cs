using System.ComponentModel.DataAnnotations.Schema;

namespace TanciskolaLib
{
    public partial class Tanar
    {
        public int TanarId { get; set; }
        public string Nev { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Orarend> OrarendTanar1Navigations { get; set; } = [];
        public virtual ICollection<Orarend> OrarendTanar2Navigations { get; set; } = [];

        [NotMapped]
        public IEnumerable<Orarend> Orak
        {
            get
            {
                var orak = OrarendTanar1Navigations.ToList();
                orak.AddRange(OrarendTanar2Navigations);

                return orak;
            }
        }

        public double Kereset => Orak.Sum(x => x.Bevetel / (x.Tanar2 is null ? 2.0 : 4.0));
    }
}
