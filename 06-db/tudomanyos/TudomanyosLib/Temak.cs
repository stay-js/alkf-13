namespace TudomanyosLib
{
    public partial class Temak
    {
        public int TemaId { get; set; }
        public string TemaNev { get; set; } = null!;

        public virtual ICollection<Program> Programok { get; set; } = [];
    }
}
