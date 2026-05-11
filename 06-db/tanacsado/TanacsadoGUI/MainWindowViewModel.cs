using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TanacsadoLib;

namespace TanacsadoGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly TanacsadoContext _db;

        private Szakterulet? _kivalasztottSzakterulet = null;
        private Tanacsado? _kivalasztottTanacsado = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Szakterulet> Szakteruletek { get; set; } = [];
        public IEnumerable<Tanacsado> ValaszthatoTanacsadok { get; set; } = [];

        public Szakterulet? KivalasztottSzakterulet
        {
            get => _kivalasztottSzakterulet;
            set
            {
                _kivalasztottSzakterulet = value;

                KivalasztottTanacsado = null;
                _ = ValaszthatoTanacsadokFeltoltese();

                Changed();
                Changed(nameof(VanKivalasztottSzakterulet));
            }
        }

        public bool VanKivalasztottSzakterulet => KivalasztottSzakterulet is not null;

        public Tanacsado? KivalasztottTanacsado
        {
            get => _kivalasztottTanacsado;
            set
            {
                _kivalasztottTanacsado = value;
                Changed();
            }
        }

        public MainWindowViewModel()
        {
            _db = new();
            _ = SzakteruletekFeltoltese();
        }

        private async Task SzakteruletekFeltoltese()
        {
            Szakteruletek = await _db.Szakteruletek.ToListAsync();
            Changed(nameof(Szakteruletek));
        }

        private async Task ValaszthatoTanacsadokFeltoltese()
        {
            if (KivalasztottSzakterulet is null) return;

            ValaszthatoTanacsadok = await _db
                .Tanacsadok
                .Include(x => x.Szakterulet)
                .Where(x => x.SzakteruletId == KivalasztottSzakterulet.SzakteruletId)
                .OrderBy(x => x.Nev)
                .ToListAsync();

            Changed(nameof(ValaszthatoTanacsadok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
