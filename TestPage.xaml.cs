using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class TestPage : ContentPage
{

	public EmployeeViewModel DefaultViewModel { get; } = new EmployeeViewModel
	{
		Employees = new System.Collections.ObjectModel.ObservableCollection<PersonViewModel>
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
			}
		}
	};




	public TestPage()
	{
		InitializeComponent();


	}



}