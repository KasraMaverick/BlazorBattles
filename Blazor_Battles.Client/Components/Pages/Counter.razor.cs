using Microsoft.AspNetCore.Components;

namespace Blazor_Battles.Client.Components.Pages
{
    public partial class Counter : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
