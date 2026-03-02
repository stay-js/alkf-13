namespace TanciskolaLib
{
    public partial class Tanc
    {
        public int TancId { get; set; }
        public string TancTipus { get; set; } = null!;

        public virtual ICollection<Orarend> Orarendek { get; set; } = [];
    }
}
