using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TudomanyosLib;

namespace TudomanyosGUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly TudomanyosContext _db;

        private Szekcio? _kivalasztottKategoria = null;
        private Eloado? _kivalasztottEloado = null;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IEnumerable<Szekcio> Kategoriak { get; set; } = [];
        public IEnumerable<Eloado> ValaszthatoEloadok { get; set; } = [];

        public Szekcio? KivalasztottKategoria
        {
            get => _kivalasztottKategoria;
            set
            {
                _kivalasztottKategoria = value;
                KivalasztottEloado = null;

                ValaszthatoEloadokFeltoltese();

                Changed();
                Changed(nameof(VanKivalasztottKategoria));
            }
        }

        public bool VanKivalasztottKategoria => KivalasztottKategoria is not null;

        public Eloado? KivalasztottEloado
        {
            get => _kivalasztottEloado;
            set
            {
                _kivalasztottEloado = value;
                Changed();
            }
        }

        public MainWindowViewModel()
        {
            _db = new();
            _ = KategoriakFeltoltese();
        }

        private async Task KategoriakFeltoltese()
        {
            Kategoriak = await _db
                .Szekciok
                .OrderBy(x => x.Kategoria)
                .Include(x => x.Programok)
                    .ThenInclude(x => x.Eloadok1Navigation)
                .Include(x => x.Programok)
                    .ThenInclude(x => x.Eloadok2Navigation)
                .ToListAsync();

            Changed(nameof(Kategoriak));
        }

        private void ValaszthatoEloadokFeltoltese()
        {
            if (KivalasztottKategoria is null) return;

            HashSet<Eloado> eloadok = [];

            foreach (var program in KivalasztottKategoria.Programok)
            {
                eloadok.Add(program.Eloadok1Navigation);

                if (program.Eloadok2Navigation is not null)
                {
                    eloadok.Add(program.Eloadok2Navigation);
                }
            }

            ValaszthatoEloadok = eloadok;

            Changed(nameof(ValaszthatoEloadok));
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
