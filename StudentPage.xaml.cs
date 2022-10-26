using MauiApp1.Models;
using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class StudentPage : ContentPage
{
	public StudentViewModel DefaultViewModel { get; } = new StudentViewModel();

	public StudentPage()
	{
		DefaultViewModel.Students.Add(new Student
		{
			Name = "TEST1",
			Age = 19
		});


		InitializeComponent();
	}
}