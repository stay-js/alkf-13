using System.ComponentModel.DataAnnotations.Schema;

namespace TudomanyosLib
{
    public partial class Eloado
    {
        public int EloadoId { get; set; }
        public string Nev { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Program> ProgramEloadok1Navigations { get; set; } = [];
        public virtual ICollection<Program> ProgramEloadok2Navigations { get; set; } = [];

        [NotMapped]
        public IEnumerable<Program> Programok
        {
            get
            {
                var programok = ProgramEloadok1Navigations.ToList();
                programok.AddRange(ProgramEloadok2Navigations);

                return programok;
            }
        }

        public double Kereset => Programok.Sum(x => x.Bevetel / (x.Eloadok2 is null ? 2.0 : 4.0));
    }
}
