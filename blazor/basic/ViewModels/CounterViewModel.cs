using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;

namespace basic.ViewModels
{
    public class CounterViewModel : ReactiveObject
    {
        private ObservableAsPropertyHelper<int> _currentCount;

        public CounterViewModel()
        {
            IncrementCommand = ReactiveCommand.Create(() => 1);
            DecrementCommand = ReactiveCommand.Create(() => -1);
            _currentCount = Observable.Merge(IncrementCommand, DecrementCommand)
                .Scan(1, (acc, next) => acc += next)
                .ToProperty(this, x => x.Count, initialValue: 1);
        }

        public ReactiveCommand<Unit, int> IncrementCommand { get; }
        public ReactiveCommand<Unit, int> DecrementCommand { get; }

        public int Count => _currentCount.Value;
    }
}