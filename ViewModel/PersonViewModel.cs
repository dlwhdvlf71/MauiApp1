using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string name;
        int age;

        public string Name 
        {
            get => this.name; 
            set
            {
                SetProperty(ref this.name, value);
            }
        }
        public int Age 
        {
            get => this.age;
            set
            {
                SetProperty(ref this.age, value);
            }
        }

        public static ICollection<PersonViewModel> All { get; private set; }

        static PersonViewModel()
        {

            List<PersonViewModel> list = new List<PersonViewModel>();

            for(int i = 0; i < 10; i++)
            {
                list.Add(new PersonViewModel
                {
                    Name = $"name{i}",
                    Age = i
                });
            }

            All = list;
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
