using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Questions
{
    public static class Section4
    {
        public static void Run()
        {
            private async Task CaptureFrame()
                {
                    await JSRuntime.InvokeAsync<String>("getFrame", DotNetObjectReference.Create(this));
                }
        }
    }
}