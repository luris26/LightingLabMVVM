using MauiMobileEmployee.Components.Pages;

namespace MauiMobileEmployee
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmployeePage());
        }
    }
}
