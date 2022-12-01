using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiApp1.MVVM.Commanding
{
    public partial class CounterViewModel : ObservableObject
    {
        [ObservableProperty]
        private int counter;

        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }
        public IAsyncRelayCommand IncrementCommandAsnyc { get; }

        public CounterViewModel()
        {
            IncrementCommand = new RelayCommand(IncrementCounterMethod);
            DecrementCommand = new RelayCommand(DecrementCounterMethod);
            IncrementCommandAsnyc = new AsyncRelayCommand(IncrementCounterAsyncMethod);
        }

        private void IncrementCounterMethod() => Counter++;

        private async Task IncrementCounterAsyncMethod()
        {
            await Task.Delay(3000);
            IncrementCounterMethod();
        }

        private void DecrementCounterMethod() => Counter--;
    }
}