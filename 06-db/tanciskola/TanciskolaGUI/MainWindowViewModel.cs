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
        private Tanar? _kivalasztottTanar = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Tanc> Tancok { get; set; } = [];
        public IEnumerable<Tanar> ValaszthatoTanarok { get; set; } = [];

        public Tanc? KivalasztottTanc
        {
            get => _kivalasztottTanc;
            set
            {
                _kivalasztottTanc = value;
                KivalasztottTanar = null;

                _ = TanarokFeltoltese();

                Changed();
                Changed(nameof(VanKivalasztottTanc));
            }
        }

        public bool VanKivalasztottTanc => KivalasztottTanc is not null;

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
            _ = TancokFeltoltese();
        }

        private async Task TancokFeltoltese()
        {
            Tancok = await _db.Tancok.OrderBy(x => x.TancTipus).ToListAsync();
            Changed(nameof(Tancok));
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

            ValaszthatoTanarok = osszesTanar
                .Where(x => x.Orak.Any(y => y.Tanc == KivalasztottTanc.TancId))
                .Distinct()
                .OrderBy(x => x.Nev);

            Changed(nameof(ValaszthatoTanarok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
