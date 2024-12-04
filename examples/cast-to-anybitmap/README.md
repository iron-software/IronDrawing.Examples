***Based on <https://ironsoftware.com/examples/cast-to-anybitmap/>***

To employ images from various platforms in IronDrawing, it's compulsory to convert them into `AnyBitmap` files. This can be achieved by casting from supported file formats. Below are instructions on how this casting process can be carried out for different image types:

## `System.Drawing.Bitmap`

Conversion from `System.Drawing.Bitmap` to `AnyBitmap` involves loading a bitmap file through `System.Drawing.Bitmap(@"FILE_PATH")`.  Once loaded, this file should be assigned to a new variable of type `AnyBitmap`.

## `System.Drawing.Image`

For images of type `System.Drawing.Image`, cast them by first obtaining the image with `System.Drawing.Image.FromFile(@"FILE_PATH")`. Then, initialize and store it in a variable declared as `AnyBitmap`.

## `SkiaSharp.SKBitmap`

To work with `SkiaSharp.SKBitmap`, create a variable of `SkiaSharp.SKBitmap` and load the bitmap using `SkiaSharp.SKBitmap.Decode(@"FILE_PATH")`. This bitmap can be converted to `AnyBitmap` by assigning it to a variable of that type.

## `SkiaSharp.SKImage`

For converting `SkiaSharp.SKImage` into `AnyBitmap`, start by loading the image file with `SkiaSharp.SKImage.FromBitmap(SkiaSharp.SKBitmap.Decode(@"FILE_PATH"))`. Then, store it in a variable defined as `AnyBitmap`.

## `SixLabors`

Images from `SixLabors` are handled by loading them with `SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(@"FILE_PATH")`. Place the loaded image into a variable of type `SixLabors.ImageSharp.Image<SixLabors.ImageSharp.PixelFormats.Rgba32>`. This image can subsequently be cast to `AnyBitmap` by assigning it to an appropriately typed variable.

## MAUI Image

For MAUI images, ensure you are working in an environment compatible with versions beyond .NET 4.7.2. Load the image by reading its bytes with `File.ReadAllBytes(@"FILE_PATH")`, storing the bytes into a `byte[]` array. Transform these bytes into an image using `Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(byte[]))`. Then, proceed to cast this platform image to `AnyBitmap` by assigning it to a new `AnyBitmap` variable.