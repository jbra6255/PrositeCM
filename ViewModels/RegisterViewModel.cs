using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace PrositeCM.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        // Private backing fields
        private string _email = string.Empty;
        private string _password = string.Empty;
        private string _company = string.Empty;
        private string _position = string.Empty;
        private string _errorMessage = string.Empty;

        // Public properties
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string Company
        {
            get => _company;
            set => SetProperty(ref _company, value);
        }

        public string Position
        {
            get => _position;
            set => SetProperty(ref _position, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        // Events to handle navigation in code-behind
        public event EventHandler? RegistrationSuccessful;
        public event EventHandler? NavigateBackRequested;

        [RelayCommand]
        private void Register()
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(Company) || string.IsNullOrWhiteSpace(Position))
            {
                ErrorMessage = "All fields are required.";
                return;
            }

            // TODO: Add your actual database insertion logic here

            // Simulate success
            ErrorMessage = string.Empty;
            RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
        }

        [RelayCommand]
        private void GoBack()
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}