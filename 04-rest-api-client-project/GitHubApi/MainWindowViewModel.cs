using GitHubApiLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GitHubApi
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly ApiClient _apiClient;

        private User? user;
        private IEnumerable<Repository>? repositories;
        private string? zenMessage;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            _apiClient = new ApiClient();

            _apiClient.GetAsync<string>("/zen").ContinueWith(task =>
            {
                if (task.Exception is not null)
                {
                    MessageBox.Show($"Error fetching zen message: {task.Exception.Message}");
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

        public string? TopLanguage => Repositories?
            .Where(x => !string.IsNullOrEmpty(x.Language))
            .GroupBy(x => x.Language)
            .OrderByDescending(x => x.Count())
            .FirstOrDefault()?
            .Key;


        public string UserName { get; set; } = string.Empty;

        public async Task LoadUserDataAsync()
        {
            User = null;
            Repositories = null;

            try
            {
                var userTask = _apiClient.GetAsync<User>($"/users/");
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
