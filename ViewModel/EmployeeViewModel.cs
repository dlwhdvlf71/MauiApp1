using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    public class EmployeeViewModel
    {
        public ObservableCollection<PersonViewModel> Employees { get; set; }

        public ICommand DeleteCommand { get; private set; }

        public EmployeeViewModel()
        {
            DeleteCommand = new Command((employee) =>
            {
                Employees.Remove(employee as PersonViewModel);
            });
        }


    }
}
