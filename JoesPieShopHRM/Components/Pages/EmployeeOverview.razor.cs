using JoesPieShopHRM.Components.Services;
using JoesPieShopHRM.Shared.Domain;

namespace JoesPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;
        //initialize
        //public List<Employee> Employees { get; set; } = new List<Employee>();
        private string Title = "Employee Overview";
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }

    }
}
