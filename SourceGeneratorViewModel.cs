using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1
{
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
        private void ChangeName() => Name = "Change New Name";
    }
}