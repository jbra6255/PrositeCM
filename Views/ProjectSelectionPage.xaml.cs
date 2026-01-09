using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace PrositeCM.Views
{
    public sealed partial class ProjectSelectionPage : Page
    {
        public ProjectSelectionPage()
        {
            this.InitializeComponent();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to the Login Page
            // Clearing the BackStack prevents the user from clicking "Back" to return to the project list without logging in again
            this.Frame.Navigate(typeof(LoginPage));
            this.Frame.BackStack.Clear();
        }
    }
}
