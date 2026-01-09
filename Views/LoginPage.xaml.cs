using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PrositeCM.ViewModels;

namespace PrositeCM.Views
{
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Access the ViewModel logic from the View
            if (DataContext is LoginViewModel viewModel)
            {
                viewModel.Login();
            }
        }
    }
}