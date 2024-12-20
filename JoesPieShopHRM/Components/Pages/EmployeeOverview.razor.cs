using JoesPieShopHRM.Components.Services;
using JoesPieShopHRM.Shared.Domain;

namespace JoesPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        //initialize
        //public List<Employee> Employees { get; set; } = new List<Employee>();
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            Employees = MockDataService.Employees;
        }

    }
}
