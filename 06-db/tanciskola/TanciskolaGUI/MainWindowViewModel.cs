using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TanciskolaLib;

namespace TanciskolaGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly TanciskolaContext _db;
        private Tanc? kivalaszottTanc = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Tanc> Tancok { get; set; }
        public IEnumerable<Tanar> Tanarok { get; set; } = [];

        public Tanc? KivalaszottTanc
        {
            get => kivalaszottTanc;
            set
            {
                kivalaszottTanc = value;
                _ = TanarokFeltoltese();
                Changed(nameof(VanKivalaszottTanc));
            }
        }

        public bool VanKivalaszottTanc => KivalaszottTanc != null;

        public Tanar? KivalszottTanar { get; set; } = null;

        public MainWindowViewModel()
        {
            _db = new();
            Tancok = _db.Tancok.OrderBy(x => x.TancTipus).ToList();
        }

        private async Task TanarokFeltoltese()
        {
            if (KivalaszottTanc is null) return;

            var osszesTanar = await _db
                .Tanarok
                .Include(t => t.OrarendTanar1Navigations)
                .Include(t => t.OrarendTanar2Navigations)
                .ToListAsync();

            Tanarok = osszesTanar
                .Where(x => x.OrarendTanar1Navigations.Any(x => x.Tanc == KivalaszottTanc.TancId)
                    || x.OrarendTanar2Navigations.Any(x => x.Tanc == KivalaszottTanc.TancId))
                .Distinct()
                .OrderBy(x => x.Nev);

            Changed(nameof(Tanarok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
