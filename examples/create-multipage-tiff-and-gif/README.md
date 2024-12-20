***Based on <https://ironsoftware.com/examples/create-multipage-tiff-and-gif/>***

IronDrawing allows users to merge `AnyBitmap` files into a multipage TIFF or GIF file, giving flexibility in the frame dimensions used to assemble the multipage GIF and TIFF files.

To leverage this feature, you must load the `AnyBitmap` frames using their respective file paths, and then store these into an initialized `List` of `AnyBitmap`. Once your frames are ready, you can compile them into a TIFF file using the `.CreateMultiFrameTiff(List<AnyBitmap>)` method. Alternatively, you can generate a GIF file using the `.CreateMultiFrameGif(List<AnyBitmap>)` method.