using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TanciskolaLib;

namespace TanciskolaGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly TanciskolaContext _db;

        private Tanc? kivalasztottTanc = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Tanc> Tancok { get; set; }
        public IEnumerable<Tanar> Tanarok { get; set; } = [];

        public Tanc? KivalasztottTanc
        {
            get => kivalasztottTanc;
            set
            {
                kivalasztottTanc = value;
                _ = TanarokFeltoltese();
                Changed(nameof(VanKivalasztottTanc));
            }
        }

        public bool VanKivalasztottTanc => KivalasztottTanc != null;

        public Tanar? KivalasztottTanar { get; set; }

        public MainWindowViewModel()
        {
            _db = new();
            Tancok = _db.Tancok.OrderBy(x => x.TancTipus).ToList();
        }

        private async Task TanarokFeltoltese()
        {
            if (KivalasztottTanc is null) return;

            var osszesTanar = await _db
                .Tanarok
                .Include(x => x.OrarendTanar1Navigations)
                .Include(x => x.OrarendTanar2Navigations)
                .ToListAsync();

            Tanarok = osszesTanar
                .Where(x => x.Orak.Any(y => y.Tanc == KivalasztottTanc.TancId))
                .Distinct()
                .OrderBy(x => x.Nev);

            Changed(nameof(Tanarok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
