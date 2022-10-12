using MauiApp1.ViewModel;
using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class TestPage : ContentPage
{
    public EmployeeViewModel DefaultViewModel { get; } = new EmployeeViewModel
    {
        Employees = new ObservableCollection<PersonViewModel>
        {
            new PersonViewModel
            {
                Name = "Lee",
                Age = 10
            },
            new PersonViewModel
            {
                Name = "Kim",
                Age = 18
            },
            new PersonViewModel
            {
                Name = "Park",
                Age = 29
            },
            new PersonViewModel
            {
                Name = null,
                Age = 31
            }
        }

    };

    public TestPage()
    {
        InitializeComponent();
    }
}