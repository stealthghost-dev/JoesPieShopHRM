using JoesPieShopHRM.Contracts.Services;
using JoesPieShopHRM.Services;
using JoesPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IDataService? DataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
            Employee = await DataService?.GetEmployeeById(EmployeeId);
        }

        private void ChangeHolidayState(string name)
        {
            Console.WriteLine(name);
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
