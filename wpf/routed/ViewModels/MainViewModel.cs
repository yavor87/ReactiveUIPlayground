using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;

namespace routed.ViewModels
{
    public class MainViewModel : ReactiveObject, IRoutableViewModel
    {
        private ObservableAsPropertyHelper<int> _currentCount;

        public MainViewModel(IScreen hostScreen)
        {
            HostScreen = hostScreen;
            IncrementCommand = ReactiveCommand.Create(() => 1);
            DecrementCommand = ReactiveCommand.Create(() => -1);
            _currentCount = Observable.Merge(IncrementCommand, DecrementCommand)
                .Scan(0, (acc, next) => acc += next)
                .ToProperty(this, x => x.Count);
        }

        public ReactiveCommand<Unit, int> IncrementCommand { get; }
        public ReactiveCommand<Unit, int> DecrementCommand { get; }

        public int Count => _currentCount.Value;
        public string UrlPathSegment => "Main";
        public IScreen HostScreen { get; }
    }
}
