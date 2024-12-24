using JoesPieShopHRM.Contracts.Services;
using JoesPieShopHRM.Services;
using JoesPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;
        //initialize
        //public List<Employee> Employees { get; set; } = new List<Employee>();
        private string Title = "Employee Overview";

        //constructure injection is not supported in blazor
        //use inject attribute to inject the service from the container
        [Inject]
        public IDataService? DataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            //Employees = MockDataService.Employees;
            Employees = (await DataService?.GetAllEmployees()).ToList();    
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }

    }
}
