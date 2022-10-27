using System.Diagnostics;

namespace MauiApp1.StackNavigation.Pages;

[QueryProperty(nameof(Number), "number")]
public partial class NumberPage : ContentPage
{
	public string number;

	public string Number
	{
		get { return number; }
		set { number = value; numberLabel.Text = this.Number; Debug.WriteLine($"Set Number {value}"); }
	}

	public NumberPage()
	{
		InitializeComponent();

		numberLabel.Text = this.Number;

		Debug.WriteLine($"Number is {this.Number}");

    }
}