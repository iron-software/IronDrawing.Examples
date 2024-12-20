using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Questions
{
    public static class Section2
    {
        public static void Run()
        {
            protected override async Task OnInitializedAsync()
                {
                    await JSRuntime.InvokeVoidAsync("initializeCamera");
                }
        }
    }
}