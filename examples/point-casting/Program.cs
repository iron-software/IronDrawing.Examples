using IronSoftware.Drawing;

Point point = new Point(23, 50);

// Implicit casting from IronSoftware.Drawing.Point to System.Drawing.Point
System.Drawing.Point systemPoint = point;

// Implicit casting from IronSoftware.Drawing.Point to SixLabors.ImageSharp.Point
SixLabors.ImageSharp.Point sixPoint = point;

SixLabors.ImageSharp.PointF pointFloatS = new SixLabors.ImageSharp.PointF(22.5f, 35.5f);

// Implicit casting from SixLabors.ImageSharp.PointF to IronSoftware.Drawing.PointF
PointF pointFloatI = pointFloatS;
