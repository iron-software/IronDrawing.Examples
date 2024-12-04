using IronSoftware.Drawing;
using IronSoftware.System.Drawing;
namespace irondrawing.Quickstart
{
    public class Section2
    {
        public void Run()
        {
            ​
            // Create a new Color object
            Color fromHex = new Color("#191919");
            Color fromRgb = new Color(255, 255, 0);
            Color fromEnum = Color.Crimson;
            ​
            // Casting between System.Drawing.Color and IronSoftware.Drawing.Color
            System.Drawing.Color drawingColor = System.Drawing.Color.Red;
            IronSoftware.Drawing.Color ironColor = drawingColor;
            ​
            ironColor.A;
            ironColor.R;
            ironColor.G;
            ironColor.B;
            ​
            // Luminance is a value from 0 (black) to 100 (white) where 50 is the perceptual "middle grey"
            IronDrawingColor.GetLuminance();
        }
    }
}