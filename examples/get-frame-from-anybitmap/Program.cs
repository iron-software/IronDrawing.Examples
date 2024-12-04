using IronSoftware.Drawing;
using System.Collections.Generic;
using System.Linq;

//Load a GIF or TIFF as AnyBitmap (loads ALL frames)
AnyBitmap gifOrTiff = AnyBitmap.FromFile(@"FILE_PATH");

gifOrTiff.GetAllFrames.First().SaveAs("first.png"); // First frame
gifOrTiff.GetAllFrames.Last().SaveAs("last.png"); // Last frame
gifOrTiff.GetAllFrames.ElementAt(1).SaveAs("second.png"); // n'th frame

// Save every frame of a GIF or TIFF to images on disk
List<AnyBitmap> frames = (List<AnyBitmap>)gifOrTiff.GetAllFrames;
for (int i = 0 ; i < frames.Count ; i++)
{
    frames[i].SaveAs("frame_" + i + ".jpg");
}


