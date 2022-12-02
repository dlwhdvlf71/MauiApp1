using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.InjectableServices;

namespace MauiApp1.DependencyInjection
{
    public partial class IncrementCOunterViewModel : ObservableObject, ITransientService
    {
        private readonly IHelloWorldClass _helloWorld;

        public IncrementCOunterViewModel(IHelloWorldClass helloWorld)
        {
            this._helloWorld = helloWorld;
        }

        [ObservableProperty]
        private int _counter;

        [ObservableProperty]
        private string _message;

        [RelayCommand]
        private void IncrementCounter() => Counter++;

        [RelayCommand]
        private void ChangeMessage() => Message = _helloWorld.Execution();
    }
}