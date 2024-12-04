using IronSoftware.Drawing;
using System;

// Instantiate 2 points using float parameter
PointF pointFloat = new PointF(22.2f, 25.7f);
PointF pointFloat2 = new PointF(30.2f, 55.7f);

// Check for equality of the double parameter between 2 points
Console.WriteLine(pointFloat.Equals(pointFloat2));
