***Based on <https://ironsoftware.com/examples/create-multipage-tiff-and-gif/>***

IronDrawing allows users to merge `AnyBitmap` files into multipage TIFF or GIF files, offering flexibility to use various frame dimensions for creating these files.

Here's how you can utilize this capability:

1. First, load each `AnyBitmap` frame by specifying the file path, and store them in a List initialized for `AnyBitmap` types. 
2. To generate a TIFF file, use the method `.CreateMultiFrameTiff(List<AnyBitmap>)`.
3. Alternatively, to produce a GIF file, apply the method `.CreateMultiFrameGif(List<AnyBitmap>)`.

This feature enables efficient handling and transformation of image files in your applications, making it easier to manage complex graphics tasks.