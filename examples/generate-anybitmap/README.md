***Based on <https://ironsoftware.com/examples/generate-anybitmap/>***

To effectively utilize the IronDrawing tool to open, read, and manipulate image files, it's essential to create `AnyBitmap` type files. There are several approaches to load image files and produce `AnyBitmap` files.

## File Path

You can load image files directly from your local machine by using the `AnyBitmap.FromFile(@"FILE_PATH")` method. This will generate an `AnyBitmap` file which you then store in an `AnyBitmap` variable.

## Memory Stream

Alternatively, `AnyBitmap` files can be created from a memory stream. To do this, first read the image bytes into a byte array with the `File.ReadAllBytes(@"FILE_PATH")` method. Then, use the `AnyBitmap.FromBytes(byte [])` method to generate and store the `AnyBitmap` file in an `AnyBitmap` variable.

## SVG File

`AnyBitmap` files can also be derived from SVG files using a similar path as file path loading. Nonetheless, loading an SVG file requires additional dependencies such as `SkiaSharp` and `SkiaSharp.Svg`.

## Uniform Resource Identifier (URI)

IronDrawing allows for direct `AnyBitmap` file creation from a URI as well. To do this, instantiate a URI variable (`Uri uri = new Uri("URI_PATH");`), and then use the `AnyBitmap.FromUri(uri)` method to produce the `AnyBitmap` file and store it to an `AnyBitmap` type variable.