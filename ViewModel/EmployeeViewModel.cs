using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    public class EmployeeViewModel
    {
        public ObservableCollection<PersonViewModel> Employees { get; set; }

        public ICommand DeleteEmployeeCommand { get; private set; }

        public EmployeeViewModel()
        {
            DeleteEmployeeCommand = new Command((employee) =>
            {
                Employees.Remove(employee as PersonViewModel);
            });
        }
    }
}