***Based on <https://ironsoftware.com/examples/cast-to-anybitmap/>***

To utilize and modify images within IronDrawing, it's essential that these images are transformed into an `AnyBitmap` format. IronDrawing facilitates the conversion of image files from alternative frameworks into `AnyBitmap` entities. Here, we outline how to convert images from various platforms to `AnyBitmap`.

## `System.Drawing.Bitmap`

To convert a `System.Drawing.Bitmap` into an `AnyBitmap`, begin by loading the bitmap using `System.Drawing.Bitmap` from a specified file path, then transfer the bitmap to a new `AnyBitmap` variable through assignment.

## `System.Drawing.Image`

For images from `System.Drawing`, load the image using `System.Drawing.Image.FromFile(path)` and then assign this image to a new `AnyBitmap` variable to achieve the conversion.

## `SkiaSharp.SKBitmap`

Transforming a `SkiaSharp.SKBitmap` is straightforward. Initialize a `SkiaSharp.SKBitmap` instance, load a bitmap from a file using `SkiaSharp.SKBitmap.Decode(path)`, and assign it to an `AnyBitmap` variable.

## `SkiaSharp.SKImage`

To deal with `SkiaSharp.SKImage`, first decode a `SkiaSharp.SKBitmap` and then create a `SkiaSharp.SKImage` using `SkiaSharp.SKImage.FromBitmap(decodedSKBitmap)`. Finally, convert this to an `AnyBitmap` by assigning it appropriately.

## `SixLabors`

Images managed by `SixLabors` can be cast to `AnyBitmap` too. Load the image directly from a file using `SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(path)`, and then assign it to a `SixLabors.ImageSharp.Image<Rgba32>` instance. This image instance can now be transitioned into an `AnyBitmap`.

## MAUI Image

Converting a MAUI image into an `AnyBitmap` requires a few steps and is compatible with all environments except **NET4.7.2**. Begin by reading the image file into a byte array with `File.ReadAllBytes(path)`, then transform these bytes into an image using `Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(byteArray))`. This image can then be cast and stored as an `AnyBitmap`. 

Following these methods, developers can effectively manage images across different platforms within IronDrawing, promoting versatility and efficiency in image processing tasks.