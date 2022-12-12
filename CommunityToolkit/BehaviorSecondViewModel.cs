using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.CommunityToolkit
{
    public partial class BehaviorSecondViewModel : ObservableObject
    {
        public BehaviorSecondViewModel()
        {
            Progress = 0.0d;
        }

        [ObservableProperty]
        private string message;

        [RelayCommand]
        private void MaxLengthReached()
        {
            Message = "최대 길이에 도달했다";
        }

        [ObservableProperty]
        private double progress;


        [RelayCommand]
        private async void Execute()
        {
            Progress = 0.0d;
            await Task.Delay(500);

            for(int i = 0; i <= 10; i++)
            {
                Progress += 0.1;
                await Task.Delay(500);
            }

        }

    }
}
