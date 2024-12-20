***Based on <https://ironsoftware.com/examples/generate-anybitmap/>***

To utilize the IronDrawing tool for opening, reading, and manipulating image files, it's essential to create `AnyBitmap` files first. There are several techniques to load images and produce `AnyBitmap` files.

## File path

To load image files from your local system, you can use the `AnyBitmap.FromFile(@"FILE_PATH")` method. This reads the image file specified at the `FILE_PATH` and converts it into an `AnyBitmap` object.

## Memory stream

Alternatively, it's possible to create an `AnyBitmap` from a memory stream. First, the image's bytes are extracted and stored in a byte array with the `File.ReadAllBytes(@"FILE_PATH")` method. Then, these bytes are used to create an `AnyBitmap` using the `AnyBitmap.FromBytes(byte[])` method, which loads the array of bytes into an `AnyBitmap` variable.

## SVG file

`AnyBitmap` files can also be created from SVG files using a similar path method as with regular image files. However, loading SVG files requires additional libraries such as `SkiaSharp` and `SkiaSharp.Svg` to handle the SVG data format.

## Uniform Resource Identifier (URI)

The IronDrawing tool is capable of generating `AnyBitmap` files directly from a URI. This involves creating a `Uri` object with `Uri uri = new Uri("URI_PATH");`, and then passing this URI to the `AnyBitmap.FromUri(uri)` method, which creates an `AnyBitmap` file from the content pointed to by the URI.