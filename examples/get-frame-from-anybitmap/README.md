***Based on <https://ironsoftware.com/examples/get-frame-from-anybitmap/>***

This functionality allows users to extract and store frames from multipage GIF or TIFF files into any image format of their choice. After extraction, these saved frames can be modified using IronDrawing or other tools from Iron Software.

To leverage this feature, begin by converting the GIF or TIFF file into the `AnyBitmap` type. This is done by loading the file through the `AnyBitmap.FromFile(@"FILE_PATH")` method. If you need to save a specific frame and are aware of the frame's index number, use the `.GetAllFrames.ElementAt(n).SaveAs("FILE_NAME")` method. To access just the first or last frame, apply the `.First()` and `.Last()` methods respectively.

For saving every frame and naming them by frame number, implement a `for` loop to iterate through the frame list and save each using `frames[i].SaveAs("frame " + i + ".jpg")`.