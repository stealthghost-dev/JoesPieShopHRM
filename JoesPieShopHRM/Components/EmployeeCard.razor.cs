using JoesPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components
{
    public partial class EmployeeCard
    {  
        [Parameter]
        public Employee Employee { get; set; } = default!;


        [Parameter]
        //triggered from parent component, triggered and subscribed from child component
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; } 

        protected override void OnInitialized()
        {
            //initialize the component
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("LastName is required");
            }
        }
    }
}
