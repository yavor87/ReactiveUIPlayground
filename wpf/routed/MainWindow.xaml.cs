using ReactiveUI;

namespace routed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.ViewModel = new ViewModels.ShellViewModel();
            this.OneWayBind(this.ViewModel, x => x.Router, x => x.host.Router);
        }
    }
}
