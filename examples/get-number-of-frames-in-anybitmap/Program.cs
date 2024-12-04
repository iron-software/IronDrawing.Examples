using IronSoftware.Drawing;
using System;

// Get and print the number of frames in any multipage GIF or TIFF file
var multiFrameImage = AnyBitmap.FromFile("FILE_PATH").FrameCount;
Console.WriteLine(multiFrameImage);


