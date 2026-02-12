using Microsoft.AspNetCore.Components;

namespace MissionLensApp.Components.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        private bool isMinimized = false;

        private void ToggleSidebar()
        {
            isMinimized = !isMinimized;
        }
    }
}
