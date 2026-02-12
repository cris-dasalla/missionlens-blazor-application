using Microsoft.AspNetCore.Components;

namespace MissionLensApp.Components.Layout
{
    public partial class NavMenu
    {
        [Parameter]
        public bool IsMinimized { get; set; }
    }
}
