using Microsoft.AspNetCore.Components;

namespace JoesPieShopHRM.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; } //wired with property in ProfilePicture.razor

    }
}
