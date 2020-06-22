using ReactiveUI;

namespace routed.ViewModels
{
    public class ShellViewModel : ReactiveObject, IScreen
    {
        public ShellViewModel()
        {
            this.Router = new RoutingState();
            this.Router.Navigate.Execute(new MainViewModel(this));
        }

        public RoutingState Router { get; }
    }
}
