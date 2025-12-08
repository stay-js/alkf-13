using System.Windows;

namespace GyogyfurdokGUI.Utils
{
    public static class WarningMessageBox
    {
        public static void Show(string message) =>
            MessageBox.Show(message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
}
