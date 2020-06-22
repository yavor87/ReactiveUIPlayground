using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;

namespace basic.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private ObservableAsPropertyHelper<int> _currentCount;

        public MainViewModel()
        {
            IncrementCommand = ReactiveCommand.Create(() => 1);
            DecrementCommand = ReactiveCommand.Create(() => -1);
            _currentCount = Observable.Merge(IncrementCommand, DecrementCommand)
                .Scan(1, (acc, next) => acc += next)
                .ToProperty(this, x => x.Count);
        }

        public ReactiveCommand<Unit, int> IncrementCommand { get; }
        public ReactiveCommand<Unit, int> DecrementCommand { get; }

        public int Count => _currentCount.Value;
    }
}
