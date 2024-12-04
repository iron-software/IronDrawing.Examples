using IronSoftware.Drawing;
using System.IO;

// We create an AnyBitmap object. We will then cast other popular types to Anybitmap.
AnyBitmap anyBitmap;

// Cast System.Drawing bitmap to AnyBitmap
System.Drawing.Bitmap bitmapFromBitmap = new System.Drawing.Bitmap(@"FILE_PATH");
anyBitmap = bitmapFromBitmap;

// Cast System image to AnyBitmap
System.Drawing.Image bitmapFromFile = System.Drawing.Image.FromFile(@"FILE_PATH");
anyBitmap = bitmapFromFile;

// Cast SKBitmap to AnyBitmap
SkiaSharp.SKBitmap skiaBitmap = SkiaSharp.SKBitmap.Decode(@"FILE_PATH");
anyBitmap = skiaBitmap;

// Cast SKimage to AnyBitmap
SkiaSharp.SKImage skiaImage = SkiaSharp.SKImage.FromBitmap(SkiaSharp.SKBitmap.Decode(@"FILE_PATH"));
anyBitmap = skiaImage;

// Cast SixLabors Image to AnyBitmap
SixLabors.ImageSharp.Image<SixLabors.ImageSharp.PixelFormats.Rgba32> imgSharp = SixLabors.ImageSharp.Image.Load<SixLabors.ImageSharp.PixelFormats.Rgba32>(@"FILE_PATH");
anyBitmap = imgSharp;

// Cast Maui image to AnyBitmap (not for NET 4.7.2):
byte[] imageAsBytes = File.ReadAllBytes(@"FILE_PATH");
// var mauiPlatformImage = Microsoft.Maui.Graphics.Platform.PlatformImage.FromStream(new MemoryStream(imageAsBytes));

