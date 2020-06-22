using ReactiveUI;
using Splat;
using System.Windows;

namespace basic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Locator.CurrentMutable.Register(() => new Views.MainView(), typeof(IViewFor<ViewModels.MainViewModel>));
        }
    }
}
