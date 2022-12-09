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
        [ObservableProperty]
        public string message;


        [RelayCommand]
        private void MaxLengthReached()
        {
            Message = "최대 길이에 도달했다";
        }
    }
}
