using IronSoftware.Drawing;

// Create a new Color object
Color fromHex = new Color("#191919");
Color fromRgb = new Color(255, 255, 0);
Color fromEnum = Color.Crimson;

// Cast between System.Drawing.Color and IronSoftware.Drawing.Color
System.Drawing.Color drawingColor = System.Drawing.Color.Red;
IronSoftware.Drawing.Color ironColor = drawingColor;

// Get the Alpha, Red, Green, or Blue channel value of a Color
var alpha = ironColor.A;
var red = ironColor.R;
var green = ironColor.G;
var blue = ironColor.B;

// Luminance
ironColor.GetLuminance();


