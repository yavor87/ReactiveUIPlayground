using ReactiveUI;
using System.Reactive.Disposables;

namespace routed.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(this.ViewModel, x => x.Count, x => x.countBox.Text).DisposeWith(disposables);
                this.BindCommand(this.ViewModel, x => x.IncrementCommand, x => x.incrementBtn);
                this.BindCommand(this.ViewModel, x => x.DecrementCommand, x => x.decrementBtn);
            });
        }
    }
}
