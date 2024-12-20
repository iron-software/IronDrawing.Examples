***Based on <https://ironsoftware.com/examples/cast-to-anybitmap/>***

To effectively work with various image files in IronDrawing, all images must first be converted into an `AnyBitmap` object. IronDrawing is competent in transforming image files from different platforms into `AnyBitmap` objects. Here are some examples of how this can be achieved across various platforms:

## `System.Drawing.Bitmap`

You can convert a `System.Drawing.Bitmap` to an `AnyBitmap` by first loading the bitmap from a file path with `System.Drawing.Bitmap(@"FILE_PATH")`. After loading, simply assign this bitmap to a variable declared with the `AnyBitmap` type for the conversion.

## `System.Drawing.Image`

For images from `System.Drawing.Image`, initiate the casting process by loading the image using `System.Drawing.Image.FromFile(@"FILE_PATH")`. Once loaded, the image should be stored in a variable defined as `AnyBitmap`.

## `SkiaSharp.SKBitmap`

To convert a `SkiaSharp.SKBitmap`, start by creating an instance of `SkiaSharp.SKBitmap` and load the bitmap using `SkiaSharp.SKBitmap.Decode(@"FILE_PATH")`. Following this, assign the loaded bitmap to an `AnyBitmap` type variable to complete the conversion.

## `SkiaSharp.SKImage`

For converting a `SkiaSharp.SKImage`, load the image by using `SkiaSharp.SKImage.FromBitmap(SkiaSharp.SKBitmap.Decode(@"FILE_PATH")`. The loaded image should then be stored in an `AnyBitmap` type variable to transform it into an `AnyBitmap` object.

## `SixLabors`

Images from the `SixLabors` library can be processed by loading them using `SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(@"FILE_PATH")`. Store this image in a variable of type `SixLabors.ImageSharp.Image<SixLabors.ImageSharp.PixelFormats.Rgba32>` and then cast it to `AnyBitmap` by assigning it to an `AnyBitmap` variable.

## MAUI Image

When working in environments other than .NET 4.7.2, MAUI images can be transformed into `AnyBitmap`. Begin by reading the image bytes from a file path using `File.ReadAllBytes(@"FILE_PATH")`, and store these bytes in a `byte[]`. Convert these bytes into an image using `Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(byte []))`. Finally, cast this image to `AnyBitmap` by assigning it to an `AnyBitmap` type variable.

These examples provide a structured approach to casting different image formats into `AnyBitmap` using IronDrawing, accommodating a variety of popular image processing libraries.