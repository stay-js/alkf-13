using Microsoft.EntityFrameworkCore;
using RendeloLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RendeloGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly RendeloContext _db;

        private Szakterulet? _kivalasztottSzakterulet = null;
        private Orvos? _kivalasztottOrvos = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Szakterulet> Szakteruletek { get; set; } = [];
        public IEnumerable<Orvos> ValaszthatoOrvosok { get; set; } = [];

        public Szakterulet? KivalasztottSzakterulet
        {
            get => _kivalasztottSzakterulet;
            set
            {
                _kivalasztottSzakterulet = value;
                KivalasztottOrvos = null;

                _ = ValaszthatoOrvosokFeltoltese();

                Changed();
                Changed(nameof(VanKivalasztottSzakterulet));
            }
        }

        public bool VanKivalasztottSzakterulet => KivalasztottSzakterulet is not null;

        public Orvos? KivalasztottOrvos
        {
            get => _kivalasztottOrvos;
            set
            {
                _kivalasztottOrvos = value;
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

        private async Task ValaszthatoOrvosokFeltoltese()
        {
            if (KivalasztottSzakterulet is null) return;

            ValaszthatoOrvosok = await _db
                .Orvosok
                .Where(x => x.SzakteruletId == KivalasztottSzakterulet.SzakteruletId)
                .ToListAsync();

            Changed(nameof(ValaszthatoOrvosok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
