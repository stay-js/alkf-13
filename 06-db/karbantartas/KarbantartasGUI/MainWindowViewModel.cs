using KarbantartasLib;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KarbantartasGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly KarbantartasContext _db;

        private Szakterulet? kivalasztottSzakterulet = null;
        private Szerelo? kivalasztottSzerelo = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Szakterulet> Szakteruletek { get; set; } = [];
        public IEnumerable<Szerelo> ValaszthatoSzerelok { get; set; } = [];

        public Szakterulet? KivalasztottSzakterulet
        {
            get => kivalasztottSzakterulet;
            set
            {
                kivalasztottSzakterulet = value;

                _ = ValaszthatoSzerelokFeltoltese();

                Changed();
                Changed(nameof(VanKivalasztottSzakterulet));
            }
        }

        public bool VanKivalasztottSzakterulet => KivalasztottSzakterulet is not null;

        public Szerelo? KivalasztottSzerelo
        {
            get => kivalasztottSzerelo;
            set
            {
                kivalasztottSzerelo = value;
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

        private async Task ValaszthatoSzerelokFeltoltese()
        {
            if (KivalasztottSzakterulet is null) return;

            ValaszthatoSzerelok = await _db
                .Szerelok
                .Where(x => x.SzakteruletId == KivalasztottSzakterulet.SzakteruletId)
                .ToListAsync();

            Changed(nameof(ValaszthatoSzerelok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
