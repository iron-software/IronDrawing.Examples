***Based on <https://ironsoftware.com/examples/get-number-of-frames-in-anybitmap/>***

This functionality allows users to effortlessly determine the number of frames contained in a multipage GIF or TIFF file.

Convert the target multipage file into an `AnyBitmap` type using the file's path. You can then store the frame count in a variable by utilizing the `AnyBitmap.FromFile(@"FILE_PATH").FrameCount` method.