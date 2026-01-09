using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PrositeCM.ViewModels;
using System;

namespace PrositeCM.Views
{
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();

            // Subscribe to the event when the page loads
            this.Loaded += LoginPage_Loaded;
        }

        private void LoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel viewModel)
            {
                // Unsubscribe first to avoid duplicate events if revisited
                viewModel.LoginSuccessful -= ViewModel_LoginSuccessful;
                viewModel.LoginSuccessful += ViewModel_LoginSuccessful;
            }
        }

        private void ViewModel_LoginSuccessful(object sender, EventArgs e)
        {
            // Navigate to the main project page
            this.Frame.Navigate(typeof(ProjectSelectionPage));
        }

        // FIXED: Manually update ViewModel password security
        private void UserPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel viewModel)
            {
                viewModel.Password = UserPasswordBox.Password;
            }
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }
    }
}