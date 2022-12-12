using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.CommunityToolkit
{
    public partial class BehaviorThirdViewModel : ObservableObject
    {
        [ObservableProperty]
        private string message;

        [RelayCommand]
        private void Search()
        {
            Message = $"{DateTime.Now} Search 결과입니다.";
        }
    }
}
