using IronSoftware.Drawing;
using System;

// Instantiate a Rectangle (Default measurement unit is pixels)
Rectangle pxCropRect = new Rectangle(15, 25, 150, 175); // (X, Y, Width, Height)

// Convert and print a Rectangle measurement in millimeters
Rectangle mmCropRect = pxCropRect.ConvertTo(MeasurementUnits.Millimeters, 20);
Console.WriteLine(mmCropRect.X);

// Instantiate a RectangleF in millimeters
IronSoftware.Drawing.RectangleF pxCropRectFloat = new IronSoftware.Drawing.RectangleF(10F, 25F, 100F, 175F, MeasurementUnits.Millimeters); // (X, Y, Width, Height, Units)

// Convert and print a RectangleF measurement in pixels
IronSoftware.Drawing.RectangleF mmCropRectFloat = pxCropRectFloat.ConvertTo(MeasurementUnits.Pixels, 30);
Console.WriteLine(mmCropRectFloat.Y);


