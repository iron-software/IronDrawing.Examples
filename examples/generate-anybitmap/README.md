***Based on <https://ironsoftware.com/examples/generate-anybitmap/>***

To utilize the IronDrawing toolkit for managing image files, first, it's necessary to create `AnyBitmap` type files. Here are the different techniques for loading image files and creating `AnyBitmap` files:

### Local File System

For loading images from a local source, utilize the `AnyBitmap.FromFile(@"FILE_PATH")` method. This approach retrieves an image from the specified file path and assigns it to an `AnyBitmap` object, thus producing an `AnyBitmap` type file.

### Memory Stream

Alternatively, `AnyBitmap` files can be created using a memory stream. Initially, the image data is read and stored in byte arrays with the help of `File.ReadAllBytes(@"FILE_PATH")`. Subsequently, the `AnyBitmap` is instantiated from these byte arrays by invoking `AnyBitmap.FromBytes(byte[])`.

### SVG Files

Creation of `AnyBitmap` from SVG files involves a process similar to handling regular file paths. Nevertheless, to import an SVG file into the application, extra libraries like `SkiaSharp` and `SkiaSharp.Svg` must be included.

### Web Resource

Lastly, `AnyBitmap` can be generated directly from a web resource using a URI. Start by declaring a `Uri` type variable to hold the URI path. The `AnyBitmap` file is then formulated by passing this `Uri` variable to the `AnyBitmap.FromUri(uri)` method.