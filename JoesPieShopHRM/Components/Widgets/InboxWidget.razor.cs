using JoesPieShopHRM.State;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components.Widgets
{
    public partial class InboxWidget
    {

        [Inject]
        public ApplicationState AppState { get; set; }

        public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            // MessageCount = new Random().Next(10);
            MessageCount = AppState.NumberOfMessages;
        }
    }
}
