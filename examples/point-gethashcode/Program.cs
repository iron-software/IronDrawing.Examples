using IronSoftware.Drawing;
using System;

PointF pointFloat = new PointF(22.2f, 25.7f);

int hashCode = pointFloat.GetHashCode();

// Output hash code value of this point
Console.WriteLine(hashCode);
