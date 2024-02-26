using MauiMobileEmployee.Models.ModelView;

namespace MauiMobileEmployee.Components.Pages;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		BindingContext = new EmployeeViewModel();

    }
}