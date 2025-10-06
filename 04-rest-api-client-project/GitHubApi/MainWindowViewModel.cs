using GitHubApiLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GitHubApi
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _apiClient;

        private string? zenMessage;
        private User? user;
        private IEnumerable<Repository>? repositories;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            _apiClient = new ApiClient();

            ApiClient.GetStringAsync("/zen").ContinueWith(task =>
            {
                if (task.Exception is not null)
                {
                    MessageBox.Show($"Error fetching Zen Message: {task.Exception.Message}");
                    return;
                }

                ZenMessage = task.Result;
            });
        }

        public Visibility UserDataVisibility => User is not null
            ? Visibility.Visible
            : Visibility.Hidden;

        public Visibility RepositoriesVisibility => Repositories is not null
            ? Visibility.Visible
            : Visibility.Hidden;

        public string TopLanguage => Repositories?
            .Where(x => !string.IsNullOrEmpty(x.Language))
            .GroupBy(x => x.Language)
            .OrderByDescending(x => x.Count())
            .FirstOrDefault()?
            .Key ?? "No top language.";

        public string UserName { get; set; } = string.Empty;

        public string? ZenMessage
        {
            get => zenMessage;
            set
            {
                zenMessage = value;
                Changed();
            }
        }

        public User? User
        {
            get => user;
            set
            {
                user = value;
                Changed();
                Changed(nameof(UserDataVisibility));
            }
        }

        public IEnumerable<Repository>? Repositories
        {
            get => repositories;
            set
            {
                repositories = value;
                Changed();
                Changed(nameof(RepositoriesVisibility));
                Changed(nameof(TopLanguage));
            }
        }

        public async Task LoadUserDataAsync()
        {
            User = null;
            Repositories = null;

            try
            {
                var userTask = _apiClient.GetAsync<User>($"/users/{UserName}");
                var reposTask = _apiClient.GetAsync<List<Repository>>($"/users/{UserName}/repos");

                await Task.WhenAll(userTask, reposTask);

                User = userTask.Result;
                Repositories = reposTask.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user: {ex.Message}");
            }
        }

        private void Changed([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
