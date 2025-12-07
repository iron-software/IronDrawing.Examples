using System.Drawing;
using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Quickstart
{
    public static class Section3
    {
        public static void Run()
        {
            // Declare an IronSoftware.Drawing.Rectangle object
            IronSoftware.Drawing.Rectangle ironRectangle = new IronSoftware.Drawing.Rectangle(5, 5, 50, 50);
            
            // Declare a System.Drawing.Rectangle object
            System.Drawing.Rectangle systemRectangle = new System.Drawing.Rectangle(10, 10, 150, 150);
            
            // Implicitly convert System.Drawing.Rectangle to IronSoftware.Drawing.Rectangle
            // Note: Uncomment and use appropriate conversion methods if available in the IronSoftware.Drawing library
            // ironRectangle = (IronSoftware.Drawing.Rectangle)systemRectangle;
            
            // Output the properties of IronSoftware.Drawing.Rectangle if conversion is successful
            // These Console.WriteLine statements assume this code runs in a console environment
            Console.WriteLine(ironRectangle.X);
            Console.WriteLine(ironRectangle.Y);
            Console.WriteLine(ironRectangle.Width);
            Console.WriteLine(ironRectangle.Height);
        }
    }
}