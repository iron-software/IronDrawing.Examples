***Based on <https://ironsoftware.com/examples/get-number-of-frames-in-anybitmap/>***

This functionality allows users to easily determine the number of frames contained within multipage GIF or TIFF files.

To achieve this, the file in question can be converted into an `AnyBitmap` object using its file path. Then, you can store the number of frames in a variable by using the `AnyBitmap.FromFile(@"FILE_PATH").FrameCount` method.