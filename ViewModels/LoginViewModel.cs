using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input; // Used for Commands (Buttons)
using System.Windows.Input;

namespace PrositeCM.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _errorMessage;

        // The toolkit also simplifies commands (button clicks)
        // This generates a "LoginCommand" that you can bind to in XAML
        [RelayCommand]
        private void Login()
        {
            if (Username == "admin" && Password == "password")
            {
                // Success logic
            }
            else
            {
                ErrorMessage = "Invalid credentials";
            }
        }
    }
}