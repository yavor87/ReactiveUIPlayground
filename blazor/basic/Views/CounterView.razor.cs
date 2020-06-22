using System.Reactive;
using basic.ViewModels;

namespace basic.Views
{
    public partial class CounterView
    {
        public CounterView()
        {
            this.ViewModel = new CounterViewModel();
        }
        
        private void IncrementCount()
        {
            this.ViewModel.IncrementCommand.Execute().Subscribe(Observer.Create<int>(_ => { }));
        }

        private void DecrementCount()
        {
            this.ViewModel.DecrementCommand.Execute().Subscribe(Observer.Create<int>(_ => { }));
        }
    }
}