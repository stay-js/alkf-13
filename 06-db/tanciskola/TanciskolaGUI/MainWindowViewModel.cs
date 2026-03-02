using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TanciskolaLib;

namespace TanciskolaGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly TanciskolaContext _db;

        private Tanc? _kivalasztottTanc = null;
        private Tanar? _kivalasztottTanar;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Tanc> Tancok { get; set; }
        public IEnumerable<Tanar> Tanarok { get; set; } = [];

        public Tanc? KivalasztottTanc
        {
            get => _kivalasztottTanc;
            set
            {
                _kivalasztottTanc = value;
                KivalasztottTanar = null;
                _ = TanarokFeltoltese();
                Changed(nameof(VanKivalasztottTanc));
            }
        }

        public bool VanKivalasztottTanc => KivalasztottTanc != null;

        public Tanar? KivalasztottTanar
        {
            get => _kivalasztottTanar;
            set
            {
                _kivalasztottTanar = value;
                Changed();
            }
        }

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
                    .ThenInclude(x => x.SzintNavigation)
                .Include(x => x.OrarendTanar2Navigations)
                    .ThenInclude(x => x.SzintNavigation)
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
