using IronSoftware.Drawing;
using System;

// Load an AnyBitmap from a file
AnyBitmap sample = AnyBitmap.FromFile(@"FILE_PATH");

// Gets and prints the color depth in terms of bits per pixel
var colorDepth = sample.BitsPerPixel;
Console.WriteLine(colorDepth);
