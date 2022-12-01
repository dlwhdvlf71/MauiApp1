using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1
{
    /*
     * public partial 클래스로 만들어야 한다.
     * ObservableObject 는 속송변경을 알려준다.
     * */
    public partial class SourceGeneratorViewModel : ObservableObject
    {
        public SourceGeneratorViewModel()
        {
            Name = "Name";
        }

        /*
         * ObservableProperty 사용시 필드명 Pattern
         * 1. lowerCamel
         * 2. _lowerCamel
         * 3. m_lowerCamel
         * */
        [ObservableProperty]
        private string m_name;
        

        [RelayCommand]
        private void ChangeName() => Name = $"{DateTime.Now} Change New Name";

        [RelayCommand]
        private async void Move() => await Shell.Current.GoToAsync("numberpage");

        
    }
}