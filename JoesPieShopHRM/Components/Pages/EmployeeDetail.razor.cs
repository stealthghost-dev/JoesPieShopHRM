using JoesPieShopHRM.Components.Services;
using JoesPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override void OnInitialized()
        {
            Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
        }

        private void ChangeHolidayState(string name)
        {
            Console.WriteLine(name);
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
