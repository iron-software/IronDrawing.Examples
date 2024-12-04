using IronSoftware.Drawing;
using System.Collections.Generic;

// Create a multipage Tiff with frames of different dimensions
List<AnyBitmap> tiffBitmaps = new List<AnyBitmap>()
{
     AnyBitmap.FromFile("cropframe1.jpg"),
     AnyBitmap.FromFile("frame2.jpg"),
     AnyBitmap.FromFile("cropframe3.jpg")
};
AnyBitmap multiFrameTiff = AnyBitmap.CreateMultiFrameTiff(tiffBitmaps);
multiFrameTiff.SaveAs("multiTiffwcrops.tiff");


// Create a multipage Gif with frames of different dimensions
List<AnyBitmap> gifBitmaps = new List<AnyBitmap>()
{
    AnyBitmap.FromFile("frame1.jpg"),
    AnyBitmap.FromFile("frame2.jpg"),
    AnyBitmap.FromFile("frame3.jpg"),
    AnyBitmap.FromFile("cropframe4.jpg")
};
AnyBitmap multiFrameGif = AnyBitmap.CreateMultiFrameGif(gifBitmaps);
multiFrameGif.SaveAs("multiGif.gif");

