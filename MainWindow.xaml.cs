using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls; // <--- ADD THIS LINE
using PrositeCM.Views;

namespace PrositeCM
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            AppFrame.Navigate(typeof(LoginPage));
        }
    }
}