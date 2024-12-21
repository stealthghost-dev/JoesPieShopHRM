using JoesPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }
        private Employee? _employee;

        protected override void OnParametersSet()
        {
            //react to quickviewpopup being set
            _employee = Employee;
        }
        public void Close()
        {
            _employee = null;
        }
    }
}
