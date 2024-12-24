using JoesPieShopHRM.State;
using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components
{
    public partial class InboxCounter
    {
        [Inject]
        public ApplicationState AppState { get; set; }

        private int MessageCount;

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);

            AppState.NumberOfMessages = MessageCount;
        }
    }
}
