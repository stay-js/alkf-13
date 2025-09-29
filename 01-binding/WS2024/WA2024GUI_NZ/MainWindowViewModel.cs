using System.ComponentModel;
using System.Runtime.CompilerServices;
using WS2024Lib;

namespace WA2024GUI_NZ
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private It? selectedSkill = null;
        private Result? selectedCompetitor;

        public MainWindowViewModel() => DataStore.Initialize();

        public event PropertyChangedEventHandler? PropertyChanged;

        public static IEnumerable<It>? Skills => DataStore.Instance?.Its;

        public It? SelectedSkill
        {
            get => selectedSkill;
            set
            {
                selectedSkill = value;

                Changed(nameof(IsSkillSelected));
                Changed(nameof(AvailableCompetitors));
            }
        }

        public bool IsSkillSelected => SelectedSkill is not null;

        public IEnumerable<Result>? AvailableCompetitors => DataStore
            .Instance?
            .Results
            .Where(x => x.SkillId == SelectedSkill?.Id);

        public Result? SelectedCompetitor
        {
            get => selectedCompetitor;
            set
            {
                selectedCompetitor = value;

                Changed();
            }
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
