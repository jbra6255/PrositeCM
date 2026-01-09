using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace PrositeCM.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        // 1. Define private backing fields
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _errorMessage = string.Empty;

        // 2. Define public properties manually (Standard MVVM)
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public event EventHandler? LoginSuccessful;

        [RelayCommand]
        private void Login()
        {
            if (Username == "admin" && Password == "password")
            {
                ErrorMessage = string.Empty;
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ErrorMessage = "Invalid credentials";
            }
        }
    }
}