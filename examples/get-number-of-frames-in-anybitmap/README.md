***Based on <https://ironsoftware.com/examples/get-number-of-frames-in-anybitmap/>***

This functionality allows users to effortlessly determine the number of frames in multipage GIF or TIFF files.

Users can transform the target multipage file into an `AnyBitmap` object via the file path and then store the number of frames in a variable using the `AnyBitmap.FromFile(@"FILE_PATH").FrameCount` method.