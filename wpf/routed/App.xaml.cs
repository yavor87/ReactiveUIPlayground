using ReactiveUI;
using Splat;
using System.Windows;

namespace routed
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Locator.CurrentMutable.RegisterViewsForViewModels(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
