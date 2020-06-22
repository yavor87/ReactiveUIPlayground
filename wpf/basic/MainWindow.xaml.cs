using System.Windows;

namespace basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.host.ViewModel = new ViewModels.MainViewModel();
        }
    }
}
