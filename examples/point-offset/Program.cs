using IronSoftware.Drawing;
using System;

PointF pointFloat = new PointF(22.2f, 25.7f);

// Offset method adds offset value to the original point.
pointFloat.Offset(-10, 10);

// Check new x coordinate value after offset
Console.WriteLine(pointFloat.X);

// Check new y coordinate value after offset
Console.WriteLine(pointFloat.Y);
