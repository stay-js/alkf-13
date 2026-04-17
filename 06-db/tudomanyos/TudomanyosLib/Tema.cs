namespace TudomanyosLib
{
    public partial class Tema
    {
        public int TemaId { get; set; }
        public string TemaNev { get; set; } = null!;

        public virtual ICollection<Program> Programok { get; set; } = [];
    }
}
