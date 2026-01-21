using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PrositeCM.ViewModels;
using System;

namespace PrositeCM.Views
{
    public sealed partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            this.InitializeComponent();
            this.Loaded += RegisterPage_Loaded;
            this.Unloaded += RegisterPage_Unloaded;
        }

        private void RegisterPage_Loaded(object? sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel viewModel)
            {
                viewModel.RegistrationSuccessful += ViewModel_RegistrationSuccessful;
                viewModel.NavigateBackRequested += ViewModel_NavigateBackRequested;
            }
        }

        private void RegisterPage_Unloaded(object? sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel viewModel)
            {
                viewModel.RegistrationSuccessful -= ViewModel_RegistrationSuccessful;
                viewModel.NavigateBackRequested -= ViewModel_NavigateBackRequested;
            }
        }

        private void ViewModel_RegistrationSuccessful(object? sender, EventArgs e)
        {
            // Registration successful -> Go to Main Project Page (or back to login)
            this.Frame.Navigate(typeof(ProjectSelectionPage));
        }

        private void ViewModel_NavigateBackRequested(object? sender, EventArgs e)
        {
            // User clicked "Already have an account"
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
            else
            {
                this.Frame.Navigate(typeof(LoginPage));
            }
        }

        private void RegisterPasswordBox_PasswordChanged(object? sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel viewModel)
            {
                viewModel.Password = RegisterPasswordBox.Password;
            }
        }
    }
}