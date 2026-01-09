using Microsoft.UI.Xaml;
using PrositeCM.Views; // Import your views namespace

namespace PrositeCM
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // Navigate the frame to the Login Page immediately
            AppFrame.Navigate(typeof(LoginPage));
        }
    }
}