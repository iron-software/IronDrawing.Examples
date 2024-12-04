using IronSoftware.Drawing;

// Cast between System.Drawing.Rectangle and IronSoftware.Drawing.Rectangle
System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(10, 10, 150, 150);
IronSoftware.Drawing.Rectangle ironRectangle = rectangle;

// Access Rectangle properties:
var x = ironRectangle.X;
var h = ironRectangle.Height;

// Cast between System.Drawing.RectangleF and IronSoftware.Drawing.RectangleF
System.Drawing.RectangleF rectangleF = new System.Drawing.RectangleF(8.8F, 10.2F, 100F, 125F);
IronSoftware.Drawing.RectangleF ironRectangleF = rectangleF;

// Access RectangleF properties:
var yFloat = ironRectangleF.Y;
var wFloat = ironRectangleF.Width;

