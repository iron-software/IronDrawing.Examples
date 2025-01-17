using IronSoftware.Drawing;
using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Quickstart
{
    public static class Section3
    {
        public static void Run()
        {
            ​
            // Create a new Rectangle object
            Rectangle Rectangle = new Rectangle(5, 5, 50, 50);
            ​
            // Casting between System.Drawing.Rectangle and IronSoftware.Drawing.Rectangle
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(10, 10, 150, 150);
            IronSoftware.Drawing.Rectangle ironRectangle = rectangle;
            ​
            ironRectangle.X;
            ironRectangle.Y;
            ironRectangle.Width;
            ironRectangle.Height;
        }
    }
}